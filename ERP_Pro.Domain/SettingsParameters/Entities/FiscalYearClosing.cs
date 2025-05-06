using System;
using ERP_Pro.Domain.Common.Base;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Domain.SettingsParameters.Entities
{
    /// <summary>
    /// كيان إقفال السنة المالية
    /// </summary>
    public class FiscalYearClosing : ERP_Pro.Domain.Common.Base.AuditableEntity<Guid>
    {
        /// <summary>
        /// معرف السنة المالية
        /// </summary>
        public Guid FiscalYearId { get; private set; }

        /// <summary>
        /// تاريخ الإقفال
        /// </summary>
        public DateTime ClosingDate { get; private set; }

        /// <summary>
        /// نوع الإقفال
        /// </summary>
        public ClosingTypeEnum ClosingType { get; private set; }

        /// <summary>
        /// حالة الإقفال
        /// </summary>
        public string Status { get; private set; }

        /// <summary>
        /// المستخدم المنفذ للإقفال
        /// </summary>
        public string PerformedBy { get; private set; }

        /// <summary>
        /// معرف قيد الإقفال
        /// </summary>
        public Guid? ClosingJournalEntryId { get; private set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; private set; }

        /// <summary>
        /// سجل الإجراءات
        /// </summary>
        public string ActionLog { get; private set; }

        /// <summary>
        /// السنة المالية المرتبطة
        /// </summary>
        public virtual FiscalYear FiscalYear { get; private set; }

        // للاستخدام من قبل EF Core
        protected FiscalYearClosing()
        {
        }

        /// <summary>
        /// إنشاء عملية إقفال للسنة المالية
        /// </summary>
        public FiscalYearClosing(
            Guid fiscalYearId,
            DateTime closingDate,
            ClosingTypeEnum closingType,
            string notes)
        {
            FiscalYearId = fiscalYearId;
            ClosingDate = closingDate;
            ClosingType = closingType;
            Status = "Initiated";
            Notes = notes;
            ActionLog = $"Closing initiated on {DateTime.Now}";
        }

        /// <summary>
        /// تحديث معرف قيد الإقفال
        /// </summary>
        public void SetClosingJournalEntryId(Guid journalEntryId)
        {
            ClosingJournalEntryId = journalEntryId;
            UpdateActionLog($"Journal entry {journalEntryId} linked on {DateTime.Now}");
        }

        /// <summary>
        /// تحديث حالة الإقفال
        /// </summary>
        public void UpdateStatus(string status)
        {
            Status = status;
            UpdateActionLog($"Status updated to {status} on {DateTime.Now}");
        }

        /// <summary>
        /// تسجيل المستخدم المنفذ للإقفال
        /// </summary>
        public void SetPerformedBy(string username)
        {
            PerformedBy = username;
            UpdateActionLog($"Performed by {username} on {DateTime.Now}");
        }

        /// <summary>
        /// تحديث سجل الإجراءات
        /// </summary>
        private void UpdateActionLog(string action)
        {
            ActionLog = string.IsNullOrEmpty(ActionLog) 
                ? action 
                : $"{ActionLog}{Environment.NewLine}{action}";
        }
    }
} 