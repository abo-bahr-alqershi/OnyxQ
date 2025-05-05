using System;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Domain.Modules.FinanceAccounting.Entities
{
    /// <summary>
    /// كيان يمثل التسويات المحاسبية للفترة
    /// </summary>
    public class FiscalPeriodAdjustment : Entity<FiscalPeriodAdjustmentId>
    {
        private FiscalPeriodAdjustment() { }

        public FiscalPeriodAdjustment(
            FiscalPeriodAdjustmentId id,
            FiscalPeriodId fiscalPeriodId,
            AdjustmentTypeEnum adjustmentType,
            DateTime adjustmentDate,
            string description,
            string performedBy)
        {
            Id = id;
            FiscalPeriodId = fiscalPeriodId;
            AdjustmentType = adjustmentType;
            AdjustmentDate = adjustmentDate;
            Description = description;
            PerformedBy = performedBy;
            Status = "Pending"; // قيد الانتظار
            CreatedBy = performedBy;
            CreationDate = DateTime.Now;
        }

        /// <summary>
        /// رقم التعريف
        /// </summary>
        public FiscalPeriodAdjustmentId Id { get; private set; }

        /// <summary>
        /// رقم الفترة المحاسبية
        /// </summary>
        public FiscalPeriodId FiscalPeriodId { get; private set; }

        /// <summary>
        /// نوع التسوية
        /// </summary>
        public AdjustmentTypeEnum AdjustmentType { get; private set; }

        /// <summary>
        /// تاريخ التسوية
        /// </summary>
        public DateTime AdjustmentDate { get; private set; }

        /// <summary>
        /// حالة التسوية
        /// </summary>
        public string Status { get; private set; }

        /// <summary>
        /// رقم قيد التسوية
        /// </summary>
        public string AdjustmentJournalEntryId { get; private set; }

        /// <summary>
        /// وصف التسوية
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// المستخدم المنفذ
        /// </summary>
        public string PerformedBy { get; private set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; private set; }

        /// <summary>
        /// المستخدم الذي أنشأ التسوية
        /// </summary>
        public string CreatedBy { get; private set; }

        /// <summary>
        /// تاريخ إنشاء التسوية
        /// </summary>
        public DateTime CreationDate { get; private set; }

        /// <summary>
        /// المستخدم الذي قام بآخر تعديل للتسوية
        /// </summary>
        public string UpdatedBy { get; private set; }

        /// <summary>
        /// تاريخ آخر تعديل للتسوية
        /// </summary>
        public DateTime? UpdateDate { get; private set; }

        /// <summary>
        /// الفترة المحاسبية التي تنتمي إليها التسوية
        /// </summary>
        public FiscalPeriod FiscalPeriod { get; private set; }

        #region Methods

        /// <summary>
        /// تحديث حالة التسوية
        /// </summary>
        public void UpdateStatus(string status, string updatedBy)
        {
            Status = status;
            UpdatedBy = updatedBy;
            UpdateDate = DateTime.Now;
        }

        /// <summary>
        /// تعيين رقم قيد التسوية
        /// </summary>
        public void SetAdjustmentJournalEntryId(string journalEntryId, string updatedBy)
        {
            AdjustmentJournalEntryId = journalEntryId;
            Status = "Processed"; // تمت المعالجة
            UpdatedBy = updatedBy;
            UpdateDate = DateTime.Now;
        }

        /// <summary>
        /// تحديث تفاصيل التسوية
        /// </summary>
        public void UpdateDetails(
            AdjustmentTypeEnum adjustmentType,
            DateTime adjustmentDate,
            string description,
            string notes,
            string updatedBy)
        {
            // لا يمكن تحديث التسوية إذا تمت معالجتها بالفعل
            if (Status == "Processed" || Status == "Completed")
                throw new InvalidOperationException("لا يمكن تحديث تسوية تمت معالجتها بالفعل");

            AdjustmentType = adjustmentType;
            AdjustmentDate = adjustmentDate;
            Description = description;
            Notes = notes;
            UpdatedBy = updatedBy;
            UpdateDate = DateTime.Now;
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
        /// إكمال التسوية
        /// </summary>
        public void CompleteAdjustment(string updatedBy)
        {
            // لا يمكن إكمال التسوية إذا لم تتم معالجتها بعد
            if (Status != "Processed")
                throw new InvalidOperationException("لا يمكن إكمال تسوية لم تتم معالجتها بعد");

            Status = "Completed"; // مكتملة
            UpdatedBy = updatedBy;
            UpdateDate = DateTime.Now;
        }

        /// <summary>
        /// إلغاء التسوية
        /// </summary>
        public void CancelAdjustment(string reason, string updatedBy)
        {
            // لا يمكن إلغاء التسوية إذا تم إكمالها بالفعل
            if (Status == "Completed")
                throw new InvalidOperationException("لا يمكن إلغاء تسوية مكتملة");

            Status = "Cancelled"; // ملغاة
            Notes = (string.IsNullOrEmpty(Notes) ? "" : Notes + Environment.NewLine) + $"سبب الإلغاء: {reason}";
            UpdatedBy = updatedBy;
            UpdateDate = DateTime.Now;
        }

        #endregion
    }
} 