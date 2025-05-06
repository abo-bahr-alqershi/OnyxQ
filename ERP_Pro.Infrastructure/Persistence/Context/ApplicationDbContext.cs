using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Domain.Common.Base;
using ERP_Pro.Domain.FinanceAccounting.Entities;
using Microsoft.EntityFrameworkCore;

namespace ERP_Pro.Infrastructure.Persistence.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        private readonly IDateTime _dateTime;
        private readonly ICurrentUserService _currentUserService;

        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options,
            IDateTime dateTime,
            ICurrentUserService currentUserService) : base(options)
        {
            _dateTime = dateTime;
            _currentUserService = currentUserService;
        }

        // FinanceAccounting - العملات
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<CurrencyExchangeRate> CurrencyExchangeRates { get; set; }
        public DbSet<CurrencyRoundingRule> CurrencyRoundingRules { get; set; }
        public DbSet<CurrencyRiskLimit> CurrencyRiskLimits { get; set; }

        // تجاوز طريقة حفظ التغييرات لإضافة معلومات التعقب
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _currentUserService.UserId;
                        entry.Entity.CreatedAt = _dateTime.Now;
                        break;

                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = _currentUserService.UserId;
                        entry.Entity.LastModifiedAt = _dateTime.Now;
                        break;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
} 