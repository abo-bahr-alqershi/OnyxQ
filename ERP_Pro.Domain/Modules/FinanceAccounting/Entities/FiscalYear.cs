using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Domain.Modules.FinanceAccounting.Entities
{
    /// <summary>
    /// كيان السنة المالية الذي يمثل السنة المالية ويحتوي على جميع خصائص السنوات المالية
    /// </summary>
    public class FiscalYear : AggregateRoot<FiscalYearId>
    {
        // القائمة الداخلية للفترات المحاسبية
        private readonly List<FiscalPeriod> _fiscalPeriods = new();

        // القائمة الداخلية لإعدادات السنة المالية
        private readonly List<FiscalYearSetting> _fiscalYearSettings = new();

        // القائمة الداخلية لعمليات إقفال السنة المالية
        private readonly List<FiscalYearClosing> _fiscalYearClosings = new();

        private FiscalYear() { }

        public FiscalYear(
            FiscalYearId id,
            string code,
            string nameAr,
            string nameEn,
            DateTime startDate,
            DateTime endDate,
            CalendarTypeEnum calendarType)
        {
            Id = id;
            Code = code;
            NameAr = nameAr;
            NameEn = nameEn;
            StartDate = startDate;
            EndDate = endDate;
            Duration = (int)(EndDate - StartDate).TotalDays + 1;
            CalendarType = calendarType;
            Status = FiscalYearStatusEnum.InPreparation;
            IsDefault = false;
            CreatedBy = string.Empty;
            CreationDate = DateTime.Now;
        }

        /// <summary>
        /// رقم التعريف
        /// </summary>
        public FiscalYearId Id { get; private set; }

        /// <summary>
        /// رمز السنة المالية
        /// </summary>
        public string Code { get; private set; }

        /// <summary>
        /// اسم السنة المالية
        /// </summary>
        public string NameAr { get; private set; }

        /// <summary>
        /// اسم السنة المالية بالإنجليزية
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
        /// المدة بالأيام
        /// </summary>
        public int Duration { get; private set; }

        /// <summary>
        /// نوع التقويم
        /// </summary>
        public CalendarTypeEnum CalendarType { get; private set; }

        /// <summary>
        /// حالة السنة المالية
        /// </summary>
        public FiscalYearStatusEnum Status { get; private set; }

        /// <summary>
        /// السنة المالية الافتراضية
        /// </summary>
        public bool IsDefault { get; private set; }

        /// <summary>
        /// نمط ترقيم الفترات
        /// </summary>
        public string PeriodNumberingPattern { get; private set; }

        /// <summary>
        /// حساب الأرباح المحتجزة
        /// </summary>
        public string RetainedEarningsAccountId { get; private set; }

        /// <summary>
        /// حساب نتيجة النشاط
        /// </summary>
        public string IncomeStatementAccountId { get; private set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; private set; }

        /// <summary>
        /// المستخدم الذي أنشأ السنة المالية
        /// </summary>
        public string CreatedBy { get; private set; }

        /// <summary>
        /// تاريخ إنشاء السنة المالية
        /// </summary>
        public DateTime CreationDate { get; private set; }

        /// <summary>
        /// المستخدم الذي قام بآخر تعديل للسنة المالية
        /// </summary>
        public string UpdatedBy { get; private set; }

        /// <summary>
        /// تاريخ آخر تعديل للسنة المالية
        /// </summary>
        public DateTime? UpdateDate { get; private set; }

        /// <summary>
        /// إعدادات الترحيل
        /// </summary>
        public string CarryOverSettings { get; private set; }

        /// <summary>
        /// إعدادات التأمين
        /// </summary>
        public string LockSettings { get; private set; }

        /// <summary>
        /// الفترات المحاسبية للسنة المالية
        /// </summary>
        public IReadOnlyCollection<FiscalPeriod> FiscalPeriods => _fiscalPeriods.AsReadOnly();

        /// <summary>
        /// إعدادات السنة المالية
        /// </summary>
        public IReadOnlyCollection<FiscalYearSetting> FiscalYearSettings => _fiscalYearSettings.AsReadOnly();

        /// <summary>
        /// عمليات إقفال السنة المالية
        /// </summary>
        public IReadOnlyCollection<FiscalYearClosing> FiscalYearClosings => _fiscalYearClosings.AsReadOnly();

        #region Methods

        /// <summary>
        /// تحديث بيانات السنة المالية
        /// </summary>
        public void Update(
            string nameAr,
            string nameEn,
            DateTime startDate,
            DateTime endDate,
            CalendarTypeEnum calendarType,
            string periodNumberingPattern,
            string retainedEarningsAccountId,
            string incomeStatementAccountId,
            string notes,
            string updatedBy)
        {
            if (Status == FiscalYearStatusEnum.PermanentlyClosed)
                throw new InvalidOperationException("لا يمكن تعديل سنة مالية مغلقة نهائياً");

            NameAr = nameAr;
            NameEn = nameEn;
            StartDate = startDate;
            EndDate = endDate;
            Duration = (int)(EndDate - StartDate).TotalDays + 1;
            CalendarType = calendarType;
            PeriodNumberingPattern = periodNumberingPattern;
            RetainedEarningsAccountId = retainedEarningsAccountId;
            IncomeStatementAccountId = incomeStatementAccountId;
            Notes = notes;
            UpdatedBy = updatedBy;
            UpdateDate = DateTime.Now;
        }

        /// <summary>
        /// تغيير حالة السنة المالية
        /// </summary>
        public void ChangeStatus(FiscalYearStatusEnum newStatus, string updatedBy)
        {
            // التحقق من منطق تغيير الحالة
            ValidateStatusChange(newStatus);

            Status = newStatus;
            UpdatedBy = updatedBy;
            UpdateDate = DateTime.Now;
        }

        /// <summary>
        /// تعيين السنة المالية كافتراضية
        /// </summary>
        public void SetAsDefault(string updatedBy)
        {
            IsDefault = true;
            UpdatedBy = updatedBy;
            UpdateDate = DateTime.Now;
        }

        /// <summary>
        /// إلغاء تعيين السنة المالية كافتراضية
        /// </summary>
        public void UnsetDefault(string updatedBy)
        {
            IsDefault = false;
            UpdatedBy = updatedBy;
            UpdateDate = DateTime.Now;
        }

        /// <summary>
        /// إضافة فترة محاسبية جديدة
        /// </summary>
        public void AddFiscalPeriod(FiscalPeriod fiscalPeriod)
        {
            // التحقق من أن الفترة تقع ضمن نطاق السنة المالية
            if (fiscalPeriod.StartDate < StartDate || fiscalPeriod.EndDate > EndDate)
                throw new InvalidOperationException("الفترة المحاسبية يجب أن تقع ضمن نطاق السنة المالية");

            // التحقق من عدم تداخل الفترة مع فترات أخرى
            if (_fiscalPeriods.Any(p => 
                (fiscalPeriod.StartDate >= p.StartDate && fiscalPeriod.StartDate <= p.EndDate) ||
                (fiscalPeriod.EndDate >= p.StartDate && fiscalPeriod.EndDate <= p.EndDate) ||
                (fiscalPeriod.StartDate <= p.StartDate && fiscalPeriod.EndDate >= p.EndDate)))
            {
                throw new InvalidOperationException("الفترة المحاسبية تتداخل مع فترة أخرى");
            }

            _fiscalPeriods.Add(fiscalPeriod);
        }

        /// <summary>
        /// إضافة إعداد للسنة المالية
        /// </summary>
        public void AddSetting(FiscalYearSetting setting)
        {
            _fiscalYearSettings.Add(setting);
        }

        /// <summary>
        /// إضافة عملية إقفال للسنة المالية
        /// </summary>
        public void AddClosing(FiscalYearClosing closing)
        {
            _fiscalYearClosings.Add(closing);
        }

        /// <summary>
        /// التحقق من إمكانية تغيير حالة السنة المالية
        /// </summary>
        private void ValidateStatusChange(FiscalYearStatusEnum newStatus)
        {
            // لا يمكن تغيير السنة المالية المغلقة نهائياً
            if (Status == FiscalYearStatusEnum.PermanentlyClosed)
                throw new InvalidOperationException("لا يمكن تغيير حالة سنة مالية مغلقة نهائياً");

            // لا يمكن تحويل السنة المالية من مغلقة مؤقتاً إلى قيد الإعداد
            if (Status == FiscalYearStatusEnum.TemporarilyClosed && newStatus == FiscalYearStatusEnum.InPreparation)
                throw new InvalidOperationException("لا يمكن تحويل السنة المالية من مغلقة مؤقتاً إلى قيد الإعداد");
            
            // لا يمكن فتح السنة المالية إذا لم تكن هناك فترات محاسبية
            if (newStatus == FiscalYearStatusEnum.Open && !_fiscalPeriods.Any())
                throw new InvalidOperationException("لا يمكن فتح السنة المالية بدون إنشاء فترات محاسبية");
        }

        /// <summary>
        /// الحصول على فترة محاسبية بواسطة الرقم التعريفي
        /// </summary>
        public FiscalPeriod GetPeriodById(FiscalPeriodId id)
        {
            var period = _fiscalPeriods.FirstOrDefault(p => p.Id == id);
            if (period == null)
                throw new InvalidOperationException("الفترة المحاسبية غير موجودة");
            
            return period;
        }

        /// <summary>
        /// الحصول على فترة محاسبية تشمل تاريخ محدد
        /// </summary>
        public FiscalPeriod GetPeriodByDate(DateTime date)
        {
            var period = _fiscalPeriods.FirstOrDefault(p => 
                date >= p.StartDate && date <= p.EndDate);
            
            if (period == null)
                throw new InvalidOperationException("لا توجد فترة محاسبية تغطي التاريخ المحدد");
            
            return period;
        }

        /// <summary>
        /// الحصول على الفترة المحاسبية الأولى
        /// </summary>
        public FiscalPeriod GetFirstPeriod()
        {
            if (!_fiscalPeriods.Any())
                throw new InvalidOperationException("لا توجد فترات محاسبية");
            
            return _fiscalPeriods.OrderBy(p => p.StartDate).First();
        }

        /// <summary>
        /// الحصول على الفترة المحاسبية الأخيرة
        /// </summary>
        public FiscalPeriod GetLastPeriod()
        {
            if (!_fiscalPeriods.Any())
                throw new InvalidOperationException("لا توجد فترات محاسبية");
            
            return _fiscalPeriods.OrderBy(p => p.StartDate).Last();
        }

        #endregion
    }
} 