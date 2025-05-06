using System;
using ERP_Pro.Domain.Common.Interfaces;

namespace ERP_Pro.Domain.SettingsParameters.Events
{
    /// <summary>
    /// حدث تحديث بيانات فرع
    /// </summary>
    public class BranchUpdatedEvent : IDomainEvent
    {
        /// <summary>
        /// المنشئ
        /// </summary>
        /// <param name="branchId">معرف الفرع</param>
        /// <param name="branchCode">رمز الفرع</param>
        /// <param name="branchName">اسم الفرع</param>
        /// <param name="companyId">معرف الشركة</param>
        /// <param name="updatedFields">الحقول التي تم تحديثها</param>
        public BranchUpdatedEvent(Guid branchId, string branchCode, string branchName, Guid companyId, string[] updatedFields)
        {
            BranchId = branchId;
            BranchCode = branchCode;
            BranchName = branchName;
            CompanyId = companyId;
            UpdatedFields = updatedFields;
            UpdatedAt = DateTime.UtcNow;
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
        /// الحقول التي تم تحديثها
        /// </summary>
        public string[] UpdatedFields { get; }
        
        /// <summary>
        /// تاريخ التحديث
        /// </summary>
        public DateTime UpdatedAt { get; }
    }
} 