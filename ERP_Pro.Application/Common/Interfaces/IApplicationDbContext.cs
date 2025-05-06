using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ERP_Pro.Domain.SettingsParameters.Entities;
using ERP_Pro.Domain.InventoryWarehousing.Entities;

namespace ERP_Pro.Application.Common.Interfaces
{
    /// <summary>
    /// واجهة سياق قاعدة البيانات للتطبيق
    /// </summary>
    public interface IApplicationDbContext
    {
        // كيانات الشركة والفروع
        DbSet<CompanyInfo> CompanyInfo { get; set; }
        DbSet<Branch> Branches { get; set; }
        
        // كيانات التسلسلات الرقمية
        DbSet<SequenceDefinition> SequenceDefinitions { get; set; }
        DbSet<UsedNumber> UsedNumbers { get; set; }
        DbSet<CanceledNumber> CanceledNumbers { get; set; }
        DbSet<NumberAllocation> NumberAllocations { get; set; }
        DbSet<NumberGap> NumberGaps { get; set; }
        DbSet<SequenceAudit> SequenceAudits { get; set; }
        
        // كيانات المستودعات
        DbSet<Warehouse> Warehouses { get; set; }
        
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// نشر حدث نطاق
        /// </summary>
        Task PublishDomainEventAsync(object domainEvent, CancellationToken cancellationToken = default);
    }
} 