using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.SettingsParameters.Events
{
    /// <summary>
    /// حدث حذف فرع
    /// </summary>
    public class BranchDeletedEvent : DomainEvent
    {
        /// <summary>
        /// المنشئ
        /// </summary>
        /// <param name="branchId">معرف الفرع</param>
        /// <param name="branchCode">رمز الفرع</param>
        /// <param name="branchName">اسم الفرع</param>
        /// <param name="companyId">معرف الشركة</param>
        /// <param name="deleteDependents">هل تم حذف العناصر المرتبطة</param>
        public BranchDeletedEvent(Guid branchId, string branchCode, string branchName, Guid companyId, bool deleteDependents)
        {
            BranchId = branchId;
            BranchCode = branchCode;
            BranchName = branchName;
            CompanyId = companyId;
            DeleteDependents = deleteDependents;
            DeletedAt = DateTime.UtcNow;
        }
        
        /// <summary>
        /// معرف الفرع
        /// </summary>
        public Guid BranchId { get; }
        
        /// <summary>
        /// رمز الفرع
        /// </summary>
        public string BranchCode { get; }
        
        /// <summary>
        /// اسم الفرع
        /// </summary>
        public string BranchName { get; }
        
        /// <summary>
        /// معرف الشركة
        /// </summary>
        public Guid CompanyId { get; }
        
        /// <summary>
        /// هل تم حذف العناصر المرتبطة
        /// </summary>
        public bool DeleteDependents { get; }
        
        /// <summary>
        /// تاريخ الحذف
        /// </summary>
        public DateTime DeletedAt { get; }
    }
} 