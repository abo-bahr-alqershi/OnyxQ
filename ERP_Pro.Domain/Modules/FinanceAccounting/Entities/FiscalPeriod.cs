using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Domain.Modules.FinanceAccounting.Entities
{
    /// <summary>
    /// كيان يمثل فترة محاسبية ضمن السنة المالية
    /// </summary>
    public class FiscalPeriod : Entity<FiscalPeriodId>
    {
        // القائمة الداخلية لعمليات تأمين الفترة المحاسبية
        private readonly List<FiscalPeriodLock> _fiscalPeriodLocks = new();

        // القائمة الداخلية للتسويات المحاسبية للفترة
        private readonly List<FiscalPeriodAdjustment> _fiscalPeriodAdjustments = new();

        private FiscalPeriod() { }

        public FiscalPeriod(
            FiscalPeriodId id,
            FiscalYearId fiscalYearId,
            int periodNumber,
            string code,
            string nameAr,
            string nameEn,
            DateTime startDate,
            DateTime endDate,
            FiscalPeriodTypeEnum periodType)
        {
            Id = id;
            FiscalYearId = fiscalYearId;
            PeriodNumber = periodNumber;
            Code = code;
            NameAr = nameAr;
            NameEn = nameEn;
            StartDate = startDate;
            EndDate = endDate;
            PeriodType = periodType;
            Status = FiscalPeriodStatusEnum.Open;
            IsClosingDefault = false;
            CreatedBy = string.Empty;
            CreationDate = DateTime.Now;
        }

        /// <summary>
        /// رقم التعريف
        /// </summary>
        public FiscalPeriodId Id { get; private set; }

        /// <summary>
        /// رقم السنة المالية
        /// </summary>
        public FiscalYearId FiscalYearId { get; private set; }

        /// <summary>
        /// رقم الفترة
        /// </summary>
        public int PeriodNumber { get; private set; }

        /// <summary>
        /// رمز الفترة
        /// </summary>
        public string Code { get; private set; }

        /// <summary>
        /// اسم الفترة
        /// </summary>
        public string NameAr { get; private set; }

        /// <summary>
        /// اسم الفترة بالإنجليزية
        /// </summary>
        public string NameEn { get; private set; }

        /// <summary>
        /// تاريخ البداية
        /// </summary>
        public DateTime StartDate { get; private set; }

        /// <summary>
        /// تاريخ النهاية
        /// </summary>
        public DateTime EndDate { get; private set; }

        /// <summary>
        /// نوع الفترة
        /// </summary>
        public FiscalPeriodTypeEnum PeriodType { get; private set; }

        /// <summary>
        /// حالة الفترة
        /// </summary>
        public FiscalPeriodStatusEnum Status { get; private set; }

        /// <summary>
        /// الفترة الافتراضية للإقفال
        /// </summary>
        public bool IsClosingDefault { get; private set; }

        /// <summary>
        /// رمز الفترة في التقويم
        /// </summary>
        public string CalendarReference { get; private set; }

        /// <summary>
        /// تاريخ آخر إغلاق
        /// </summary>
        public DateTime? LastClosingDate { get; private set; }

        /// <summary>
        /// تاريخ آخر إعادة فتح
        /// </summary>
        public DateTime? LastReopenDate { get; private set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; private set; }

        /// <summary>
        /// المستخدم الذي أنشأ الفترة المحاسبية
        /// </summary>
        public string CreatedBy { get; private set; }

        /// <summary>
        /// تاريخ إنشاء الفترة المحاسبية
        /// </summary>
        public DateTime CreationDate { get; private set; }

        /// <summary>
        /// المستخدم الذي قام بآخر تعديل للفترة المحاسبية
        /// </summary>
        public string UpdatedBy { get; private set; }

        /// <summary>
        /// تاريخ آخر تعديل للفترة المحاسبية
        /// </summary>
        public DateTime? UpdateDate { get; private set; }

        /// <summary>
        /// السنة المالية التي تنتمي إليها الفترة
        /// </summary>
        public FiscalYear FiscalYear { get; private set; }

        /// <summary>
        /// عمليات تأمين الفترة المحاسبية
        /// </summary>
        public IReadOnlyCollection<FiscalPeriodLock> FiscalPeriodLocks => _fiscalPeriodLocks.AsReadOnly();

        /// <summary>
        /// التسويات المحاسبية للفترة
        /// </summary>
        public IReadOnlyCollection<FiscalPeriodAdjustment> FiscalPeriodAdjustments => _fiscalPeriodAdjustments.AsReadOnly();

        #region Methods

        /// <summary>
        /// تحديث بيانات الفترة المحاسبية
        /// </summary>
        public void Update(
            string nameAr,
            string nameEn,
            DateTime startDate,
            DateTime endDate,
            FiscalPeriodTypeEnum periodType,
            string calendarReference,
            string notes,
            string updatedBy)
        {
            if (Status == FiscalPeriodStatusEnum.PermanentlyLocked)
                throw new InvalidOperationException("لا يمكن تعديل فترة محاسبية مغلقة نهائياً");

            NameAr = nameAr;
            NameEn = nameEn;
            StartDate = startDate;
            EndDate = endDate;
            PeriodType = periodType;
            CalendarReference = calendarReference;
            Notes = notes;
            UpdatedBy = updatedBy;
            UpdateDate = DateTime.Now;
        }

        /// <summary>
        /// تغيير حالة الفترة المحاسبية
        /// </summary>
        public void ChangeStatus(FiscalPeriodStatusEnum newStatus, string updatedBy)
        {
            // التحقق من منطق تغيير الحالة
            ValidateStatusChange(newStatus);

            Status = newStatus;

            // تحديث تواريخ الإغلاق أو إعادة الفتح
            if (newStatus == FiscalPeriodStatusEnum.TemporarilyLocked || newStatus == FiscalPeriodStatusEnum.PermanentlyLocked)
            {
                LastClosingDate = DateTime.Now;
            }
            else if (newStatus == FiscalPeriodStatusEnum.Open)
            {
                LastReopenDate = DateTime.Now;
            }

            UpdatedBy = updatedBy;
            UpdateDate = DateTime.Now;
        }

        /// <summary>
        /// تعيين الفترة كفترة افتراضية للإقفال
        /// </summary>
        public void SetAsClosingDefault(string updatedBy)
        {
            IsClosingDefault = true;
            UpdatedBy = updatedBy;
            UpdateDate = DateTime.Now;
        }

        /// <summary>
        /// إلغاء تعيين الفترة كفترة افتراضية للإقفال
        /// </summary>
        public void UnsetClosingDefault(string updatedBy)
        {
            IsClosingDefault = false;
            UpdatedBy = updatedBy;
            UpdateDate = DateTime.Now;
        }

        /// <summary>
        /// إضافة عملية تأمين للفترة المحاسبية
        /// </summary>
        public void AddLock(FiscalPeriodLock periodLock)
        {
            _fiscalPeriodLocks.Add(periodLock);
        }

        /// <summary>
        /// إضافة تسوية محاسبية للفترة
        /// </summary>
        public void AddAdjustment(FiscalPeriodAdjustment adjustment)
        {
            _fiscalPeriodAdjustments.Add(adjustment);
        }

        /// <summary>
        /// التحقق من إمكانية تغيير حالة الفترة المحاسبية
        /// </summary>
        private void ValidateStatusChange(FiscalPeriodStatusEnum newStatus)
        {
            // لا يمكن تغيير الفترة المحاسبية المغلقة نهائياً
            if (Status == FiscalPeriodStatusEnum.PermanentlyLocked)
                throw new InvalidOperationException("لا يمكن تغيير حالة فترة محاسبية مغلقة نهائياً");

            // لا يمكن تحويل الفترة المحاسبية من مغلقة مؤقتاً إلى مغلقة نهائياً إذا كانت الفترة الأخيرة
            // وكان هناك فترات سابقة غير مغلقة نهائياً (للتسلسل المنطقي للإغلاق)
            // هذا منطق متقدم يتطلب التحقق من الفترات الأخرى في نفس السنة المالية
        }

        #endregion
    }
} 