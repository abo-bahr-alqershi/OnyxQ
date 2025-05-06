using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Domain.Common.Base;
using ERP_Pro.Domain.Common.Interfaces;
using ERP_Pro.Domain.SettingsParameters.Entities;
using ERP_Pro.Domain.InventoryWarehousing.Entities;

namespace ERP_Pro.Infrastructure.Persistence
{
    /// <summary>
    /// سياق قاعدة البيانات الأساسي للتطبيق
    /// </summary>
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;
        private readonly IDomainEventService _domainEventService;

        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options,
            ICurrentUserService currentUserService,
            IDateTime dateTime,
            IDomainEventService domainEventService) : base(options)
        {
            _currentUserService = currentUserService;
            _dateTime = dateTime;
            _domainEventService = domainEventService;
        }

        // كيانات الشركة والفروع
        public DbSet<CompanyInfo> CompanyInfo { get; set; }
        public DbSet<Branch> Branches { get; set; }
        
        // كيانات التسلسلات الرقمية
        public DbSet<SequenceDefinition> SequenceDefinitions { get; set; }
        public DbSet<UsedNumber> UsedNumbers { get; set; }
        public DbSet<CanceledNumber> CanceledNumbers { get; set; }
        public DbSet<NumberAllocation> NumberAllocations { get; set; }
        public DbSet<NumberGap> NumberGaps { get; set; }
        public DbSet<SequenceAudit> SequenceAudits { get; set; }
        
        // كيانات المستودعات
        public DbSet<Warehouse> Warehouses { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<Entity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        // تعيين معلومات الإنشاء
                        entry.Property("CreatedBy").CurrentValue = _currentUserService.UserId;
                        entry.Property("CreatedAt").CurrentValue = _dateTime.Now;
                        break;
                    case EntityState.Modified:
                        // تعيين معلومات التعديل
                        entry.Property("LastModifiedBy").CurrentValue = _currentUserService.UserId;
                        entry.Property("LastModifiedAt").CurrentValue = _dateTime.Now;
                        break;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }

        public async Task PublishDomainEventAsync(object domainEvent, CancellationToken cancellationToken = default)
        {
            if (domainEvent != null && domainEvent is IDomainEvent)
            {
                await _domainEventService.Publish(domainEvent as IDomainEvent);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
} 