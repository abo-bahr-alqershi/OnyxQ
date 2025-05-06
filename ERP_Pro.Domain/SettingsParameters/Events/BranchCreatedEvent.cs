using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.SettingsParameters.Events
{
    /// <summary>
    /// حدث إنشاء فرع
    /// </summary>
    public class BranchCreatedEvent : DomainEventBase
    {
        /// <summary>
        /// المنشئ
        /// </summary>
        /// <param name="branchId">معرف الفرع</param>
        /// <param name="branchCode">رمز الفرع</param>
        /// <param name="branchName">اسم الفرع</param>
        /// <param name="companyId">معرف الشركة</param>
        /// <param name="isMainBranch">هل هو الفرع الرئيسي</param>
        public BranchCreatedEvent(Guid branchId, string branchCode, string branchName, Guid companyId, bool isMainBranch)
        {
            BranchId = branchId;
            BranchCode = branchCode;
            BranchName = branchName;
            CompanyId = companyId;
            IsMainBranch = isMainBranch;
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
        /// هل هو الفرع الرئيسي
        /// </summary>
        public bool IsMainBranch { get; }
    }
} 