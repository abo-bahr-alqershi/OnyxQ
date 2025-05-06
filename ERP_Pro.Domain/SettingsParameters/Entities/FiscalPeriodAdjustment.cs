using System;
using ERP_Pro.Domain.Common.Base;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Domain.SettingsParameters.Entities
{
    /// <summary>
    /// كيان تسوية الفترة المحاسبية
    /// </summary>
    public class FiscalPeriodAdjustment : ERP_Pro.Domain.Common.Base.AuditableEntity<Guid>
    {
        /// <summary>
        /// معرف الفترة المحاسبية
        /// </summary>
        public Guid FiscalPeriodId { get; private set; }

        /// <summary>
        /// نوع التسوية
        /// </summary>
        public AdjustmentTypeEnum AdjustmentType { get; private set; }

        /// <summary>
        /// تاريخ التسوية
        /// </summary>
        public DateTime AdjustmentDate { get; private set; }

        /// <summary>
        /// وصف التسوية
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// المستخدم الذي قام بالتسوية
        /// </summary>
        public string PerformedBy { get; private set; }

        /// <summary>
        /// معرف قيد التسوية
        /// </summary>
        public Guid? JournalEntryId { get; private set; }

        /// <summary>
        /// حالة التسوية
        /// </summary>
        public string Status { get; private set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; private set; }

        /// <summary>
        /// الفترة المحاسبية المرتبطة
        /// </summary>
        public virtual FiscalPeriod FiscalPeriod { get; private set; }

        // للاستخدام من قبل EF Core
        protected FiscalPeriodAdjustment()
        {
        }

        /// <summary>
        /// إنشاء تسوية للفترة المحاسبية
        /// </summary>
        public FiscalPeriodAdjustment(
            Guid fiscalPeriodId,
            AdjustmentTypeEnum adjustmentType,
            DateTime adjustmentDate,
            string description,
            string performedBy,
            Guid? journalEntryId = null,
            string notes = null)
        {
            FiscalPeriodId = fiscalPeriodId;
            AdjustmentType = adjustmentType;
            AdjustmentDate = adjustmentDate;
            Description = description;
            PerformedBy = performedBy;
            JournalEntryId = journalEntryId;
            Status = "Created";
            Notes = notes;
        }

        /// <summary>
        /// تحديث حالة التسوية
        /// </summary>
        public void UpdateStatus(string status)
        {
            Status = status;
        }

        /// <summary>
        /// تحديث معرف قيد التسوية
        /// </summary>
        public void SetJournalEntryId(Guid journalEntryId)
        {
            JournalEntryId = journalEntryId;
            Status = "Posted";
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