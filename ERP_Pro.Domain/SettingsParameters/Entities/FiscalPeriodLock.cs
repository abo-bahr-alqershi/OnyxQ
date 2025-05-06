using System;
using ERP_Pro.Domain.Common.Base;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Domain.SettingsParameters.Entities
{
    /// <summary>
    /// كيان تأمين الفترة المحاسبية
    /// </summary>
    public class FiscalPeriodLock : ERP_Pro.Domain.Common.Base.AuditableEntity<Guid>
    {
        /// <summary>
        /// معرف الفترة المحاسبية
        /// </summary>
        public Guid FiscalPeriodId { get; private set; }

        /// <summary>
        /// تاريخ بداية التأمين
        /// </summary>
        public DateTime LockStartDate { get; private set; }

        /// <summary>
        /// تاريخ نهاية التأمين
        /// </summary>
        public DateTime? LockEndDate { get; private set; }

        /// <summary>
        /// نوع التأمين
        /// </summary>
        public LockTypeEnum LockType { get; private set; }

        /// <summary>
        /// سبب التأمين
        /// </summary>
        public string Reason { get; private set; }

        /// <summary>
        /// المستخدم الذي قام بالتأمين
        /// </summary>
        public string PerformedBy { get; private set; }

        /// <summary>
        /// المستخدم الذي قام بإلغاء التأمين
        /// </summary>
        public string UnlockedBy { get; private set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; private set; }

        /// <summary>
        /// الفترة المحاسبية المرتبطة
        /// </summary>
        public virtual FiscalPeriod FiscalPeriod { get; private set; }

        // للاستخدام من قبل EF Core
        protected FiscalPeriodLock()
        {
        }

        /// <summary>
        /// إنشاء تأمين للفترة المحاسبية
        /// </summary>
        public FiscalPeriodLock(
            Guid fiscalPeriodId,
            DateTime lockStartDate,
            LockTypeEnum lockType,
            string reason,
            string performedBy,
            string notes = null)
        {
            FiscalPeriodId = fiscalPeriodId;
            LockStartDate = lockStartDate;
            LockType = lockType;
            Reason = reason;
            PerformedBy = performedBy;
            Notes = notes;
            LockEndDate = null;
            UnlockedBy = null;
        }

        /// <summary>
        /// إنهاء تأمين الفترة المحاسبية
        /// </summary>
        public void EndLock(string unlockedBy)
        {
            LockEndDate = DateTime.Now;
            UnlockedBy = unlockedBy;
        }

        /// <summary>
        /// تحديث سبب التأمين
        /// </summary>
        public void UpdateReason(string reason)
        {
            Reason = reason;
        }

        /// <summary>
        /// إضافة ملاحظات
        /// </summary>
        public void AddNotes(string notes)
        {
            Notes = string.IsNullOrEmpty(Notes) 
                ? notes 
                : $"{Notes}{Environment.NewLine}{notes}";
        }
    }
} 