using System;
using ERP_Pro.Domain.Common.Interfaces;

namespace ERP_Pro.Domain.SettingsParameters.Events
{
    /// <summary>
    /// حدث تغيير حالة فرع
    /// </summary>
    public class BranchStatusChangedEvent : IDomainEvent
    {
        /// <summary>
        /// المنشئ
        /// </summary>
        /// <param name="branchId">معرف الفرع</param>
        /// <param name="branchCode">رمز الفرع</param>
        /// <param name="branchName">اسم الفرع</param>
        /// <param name="oldStatus">الحالة القديمة</param>
        /// <param name="newStatus">الحالة الجديدة</param>
        public BranchStatusChangedEvent(Guid branchId, string branchCode, string branchName, string oldStatus, string newStatus)
        {
            BranchId = branchId;
            BranchCode = branchCode;
            BranchName = branchName;
            OldStatus = oldStatus;
            NewStatus = newStatus;
            ChangedAt = DateTime.UtcNow;
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
        /// الحالة القديمة
        /// </summary>
        public string OldStatus { get; }
        
        /// <summary>
        /// الحالة الجديدة
        /// </summary>
        public string NewStatus { get; }
        
        /// <summary>
        /// تاريخ التغيير
        /// </summary>
        public DateTime ChangedAt { get; }
    }
} 