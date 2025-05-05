using System;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Domain.Modules.FinanceAccounting.Entities
{
    /// <summary>
    /// كيان يمثل عملية إقفال السنة المالية
    /// </summary>
    public class FiscalYearClosing : Entity<FiscalYearClosingId>
    {
        private FiscalYearClosing() { }

        public FiscalYearClosing(
            FiscalYearClosingId id,
            FiscalYearId fiscalYearId,
            DateTime closingDate,
            ClosingTypeEnum closingType,
            string performedBy)
        {
            Id = id;
            FiscalYearId = fiscalYearId;
            ClosingDate = closingDate;
            ClosingType = closingType;
            Status = "InProgress"; // قيد التنفيذ
            PerformedBy = performedBy;
            CreatedBy = performedBy;
            CreationDate = DateTime.Now;
        }

        /// <summary>
        /// رقم التعريف
        /// </summary>
        public FiscalYearClosingId Id { get; private set; }

        /// <summary>
        /// رقم السنة المالية
        /// </summary>
        public FiscalYearId FiscalYearId { get; private set; }

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
        /// المستخدم المنفذ
        /// </summary>
        public string PerformedBy { get; private set; }

        /// <summary>
        /// رقم قيد الإقفال
        /// </summary>
        public string ClosingJournalEntryId { get; private set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; private set; }

        /// <summary>
        /// سجل الإجراءات
        /// </summary>
        public string ActionLog { get; private set; }

        /// <summary>
        /// المستخدم الذي أنشأ عملية الإقفال
        /// </summary>
        public string CreatedBy { get; private set; }

        /// <summary>
        /// تاريخ إنشاء عملية الإقفال
        /// </summary>
        public DateTime CreationDate { get; private set; }

        /// <summary>
        /// المستخدم الذي قام بآخر تعديل لعملية الإقفال
        /// </summary>
        public string UpdatedBy { get; private set; }

        /// <summary>
        /// تاريخ آخر تعديل لعملية الإقفال
        /// </summary>
        public DateTime? UpdateDate { get; private set; }

        /// <summary>
        /// السنة المالية التي تنتمي إليها عملية الإقفال
        /// </summary>
        public FiscalYear FiscalYear { get; private set; }

        #region Methods

        /// <summary>
        /// تحديث حالة عملية الإقفال
        /// </summary>
        public void UpdateStatus(string status, string updatedBy)
        {
            Status = status;
            UpdatedBy = updatedBy;
            UpdateDate = DateTime.Now;

            AppendToActionLog($"تم تغيير الحالة إلى {status} بواسطة {updatedBy} في {DateTime.Now}");
        }

        /// <summary>
        /// تعيين رقم قيد الإقفال
        /// </summary>
        public void SetClosingJournalEntryId(string journalEntryId, string updatedBy)
        {
            ClosingJournalEntryId = journalEntryId;
            UpdatedBy = updatedBy;
            UpdateDate = DateTime.Now;

            AppendToActionLog($"تم تعيين قيد الإقفال {journalEntryId} بواسطة {updatedBy} في {DateTime.Now}");
        }

        /// <summary>
        /// إضافة ملاحظات
        /// </summary>
        public void AddNotes(string notes, string updatedBy)
        {
            Notes = notes;
            UpdatedBy = updatedBy;
            UpdateDate = DateTime.Now;
        }

        /// <summary>
        /// إضافة إجراء إلى سجل الإجراءات
        /// </summary>
        public void AppendToActionLog(string action)
        {
            if (string.IsNullOrEmpty(ActionLog))
            {
                ActionLog = action;
            }
            else
            {
                ActionLog += Environment.NewLine + action;
            }
        }

        /// <summary>
        /// اكتمال عملية الإقفال
        /// </summary>
        public void CompleteClosing(string updatedBy)
        {
            Status = "Completed"; // مكتمل
            UpdatedBy = updatedBy;
            UpdateDate = DateTime.Now;

            AppendToActionLog($"تم اكتمال عملية الإقفال بنجاح بواسطة {updatedBy} في {DateTime.Now}");
        }

        /// <summary>
        /// فشل عملية الإقفال
        /// </summary>
        public void FailClosing(string reason, string updatedBy)
        {
            Status = "Failed"; // فشل
            Notes = (string.IsNullOrEmpty(Notes) ? "" : Notes + Environment.NewLine) + $"سبب الفشل: {reason}";
            UpdatedBy = updatedBy;
            UpdateDate = DateTime.Now;

            AppendToActionLog($"فشلت عملية الإقفال بسبب {reason} بواسطة {updatedBy} في {DateTime.Now}");
        }

        #endregion
    }
} 