using System;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.Modules.FinanceAccounting.Entities
{
    /// <summary>
    /// كيان يمثل عملية تأمين الفترة المحاسبية
    /// </summary>
    public class FiscalPeriodLock : Entity<FiscalPeriodLockId>
    {
        private FiscalPeriodLock() { }

        public FiscalPeriodLock(
            FiscalPeriodLockId id,
            FiscalPeriodId fiscalPeriodId,
            DateTime lockDate,
            string lockType,
            string lockReason,
            string performedBy)
        {
            Id = id;
            FiscalPeriodId = fiscalPeriodId;
            LockDate = lockDate;
            LockType = lockType;
            LockReason = lockReason;
            PerformedBy = performedBy;
            Status = "Active"; // نشط
            CreatedBy = performedBy;
            CreationDate = DateTime.Now;
        }

        /// <summary>
        /// رقم التعريف
        /// </summary>
        public FiscalPeriodLockId Id { get; private set; }

        /// <summary>
        /// رقم الفترة المحاسبية
        /// </summary>
        public FiscalPeriodId FiscalPeriodId { get; private set; }

        /// <summary>
        /// تاريخ التأمين
        /// </summary>
        public DateTime LockDate { get; private set; }

        /// <summary>
        /// نوع التأمين
        /// </summary>
        public string LockType { get; private set; }

        /// <summary>
        /// سبب التأمين
        /// </summary>
        public string LockReason { get; private set; }

        /// <summary>
        /// المستخدم المنفذ
        /// </summary>
        public string PerformedBy { get; private set; }

        /// <summary>
        /// حالة التأمين
        /// </summary>
        public string Status { get; private set; }

        /// <summary>
        /// استثناءات التأمين
        /// </summary>
        public string Exceptions { get; private set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; private set; }

        /// <summary>
        /// المستخدم الذي أنشأ عملية التأمين
        /// </summary>
        public string CreatedBy { get; private set; }

        /// <summary>
        /// تاريخ إنشاء عملية التأمين
        /// </summary>
        public DateTime CreationDate { get; private set; }

        /// <summary>
        /// المستخدم الذي قام بآخر تعديل لعملية التأمين
        /// </summary>
        public string UpdatedBy { get; private set; }

        /// <summary>
        /// تاريخ آخر تعديل لعملية التأمين
        /// </summary>
        public DateTime? UpdateDate { get; private set; }

        /// <summary>
        /// الفترة المحاسبية التي تنتمي إليها عملية التأمين
        /// </summary>
        public FiscalPeriod FiscalPeriod { get; private set; }

        #region Methods

        /// <summary>
        /// تحديث حالة عملية التأمين
        /// </summary>
        public void UpdateStatus(string status, string updatedBy)
        {
            Status = status;
            UpdatedBy = updatedBy;
            UpdateDate = DateTime.Now;
        }

        /// <summary>
        /// إضافة استثناءات للتأمين
        /// </summary>
        public void AddExceptions(string exceptions, string updatedBy)
        {
            Exceptions = exceptions;
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
        /// إلغاء تنشيط عملية التأمين
        /// </summary>
        public void Deactivate(string reason, string updatedBy)
        {
            Status = "Inactive"; // غير نشط
            Notes = (string.IsNullOrEmpty(Notes) ? "" : Notes + Environment.NewLine) + $"سبب إلغاء التنشيط: {reason}";
            UpdatedBy = updatedBy;
            UpdateDate = DateTime.Now;
        }

        #endregion
    }
} 