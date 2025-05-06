using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Base;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.Common.Interfaces;
using ERP_Pro.Domain.SettingsParameters.Events;
using ERP_Pro.Domain.SettingsParameters.Enums;
using ERP_Pro.Domain.SettingsParameters.ValueObjects;

namespace ERP_Pro.Domain.SettingsParameters.Entities
{
    /// <summary>
    /// كيان السنة المالية
    /// </summary>
    public class FiscalYear : ERP_Pro.Domain.Common.Base.AuditableEntity<Guid>, IAggregateRoot
    {
        private readonly List<IDomainEvent> _domainEvents = new List<IDomainEvent>();
        public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

        /// <summary>
        /// معرف الشركة
        /// </summary>
        public Guid CompanyInfoId { get; private set; }

        /// <summary>
        /// رمز السنة المالية
        /// </summary>
        public string Code { get; private set; }

        /// <summary>
        /// اسم السنة المالية بالعربية
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
        /// مدة السنة المالية بالأيام (تُحسب تلقائياً)
        /// </summary>
        public int Duration { get; private set; }

        /// <summary>
        /// نوع التقويم المستخدم
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
        /// معرف حساب الأرباح المحتجزة
        /// </summary>
        public Guid? RetainedEarningsAccountId { get; private set; }

        /// <summary>
        /// معرف حساب نتيجة النشاط
        /// </summary>
        public Guid? IncomeStatementAccountId { get; private set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; private set; }

        /// <summary>
        /// إعدادات الترحيل
        /// </summary>
        public CarryOverSettings CarryOverSettings { get; private set; }

        /// <summary>
        /// إعدادات التأمين
        /// </summary>
        public LockSettings LockSettings { get; private set; }

        /// <summary>
        /// الفترات المحاسبية ضمن السنة المالية
        /// </summary>
        public virtual ICollection<FiscalPeriod> FiscalPeriods { get; private set; }

        /// <summary>
        /// إعدادات السنة المالية
        /// </summary>
        public virtual ICollection<FiscalYearSetting> FiscalYearSettings { get; private set; }

        /// <summary>
        /// عمليات إقفال السنة المالية
        /// </summary>
        public virtual ICollection<FiscalYearClosing> FiscalYearClosings { get; private set; }

        /// <summary>
        /// الشركة المرتبطة بالسنة المالية
        /// </summary>
        public virtual CompanyInfo CompanyInfo { get; private set; }

        // للاستخدام من قبل EF Core
        protected FiscalYear()
        {
            FiscalPeriods = new HashSet<FiscalPeriod>();
            FiscalYearSettings = new HashSet<FiscalYearSetting>();
            FiscalYearClosings = new HashSet<FiscalYearClosing>();
        }

        /// <summary>
        /// إنشاء سنة مالية جديدة
        /// </summary>
        public FiscalYear(
            Guid companyInfoId,
            string code,
            string nameAr,
            string nameEn,
            DateTime startDate,
            DateTime endDate,
            CalendarTypeEnum calendarType,
            string periodNumberingPattern,
            string notes = null)
        {
            CompanyInfoId = companyInfoId;
            Code = code;
            NameAr = nameAr;
            NameEn = nameEn;
            StartDate = startDate;
            EndDate = endDate;
            CalendarType = calendarType;
            PeriodNumberingPattern = periodNumberingPattern;
            Notes = notes;
            
            Status = FiscalYearStatusEnum.InPreparation;
            IsDefault = false;
            
            // حساب المدة بالأيام
            Duration = (EndDate - StartDate).Days + 1;
            
            // تهيئة المجموعات
            FiscalPeriods = new HashSet<FiscalPeriod>();
            FiscalYearSettings = new HashSet<FiscalYearSetting>();
            FiscalYearClosings = new HashSet<FiscalYearClosing>();
            
            // إعدادات افتراضية
            CarryOverSettings = new CarryOverSettings();
            LockSettings = new LockSettings();
            
            // إضافة حدث إنشاء سنة مالية
            AddDomainEvent(new FiscalYearCreatedEvent(Id, companyInfoId, code, startDate, endDate, Status));
        }

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
            Guid? retainedEarningsAccountId,
            Guid? incomeStatementAccountId,
            string notes)
        {
            // التحقق من أن السنة ليست مغلقة نهائياً
            if (Status == FiscalYearStatusEnum.Closed)
                throw new InvalidOperationException("لا يمكن تعديل سنة مالية مغلقة نهائياً");

            // حفظ الحالة السابقة للمقارنة
            var previousStartDate = StartDate;
            var previousEndDate = EndDate;

            // تحديث البيانات
            NameAr = nameAr;
            NameEn = nameEn;
            StartDate = startDate;
            EndDate = endDate;
            CalendarType = calendarType;
            PeriodNumberingPattern = periodNumberingPattern;
            RetainedEarningsAccountId = retainedEarningsAccountId;
            IncomeStatementAccountId = incomeStatementAccountId;
            Notes = notes;

            // تحديث المدة إذا تغيرت التواريخ
            if (StartDate != previousStartDate || EndDate != previousEndDate)
            {
                Duration = (EndDate - StartDate).Days + 1;
            }

            // إضافة حدث تحديث سنة مالية
            AddDomainEvent(new FiscalYearUpdatedEvent(Id, CompanyInfoId, Code, StartDate, EndDate, Status));
        }

        /// <summary>
        /// تغيير حالة السنة المالية
        /// </summary>
        public void ChangeStatus(FiscalYearStatusEnum newStatus)
        {
            // التحقق من صحة الانتقال بين الحالات
            ValidateStatusChange(newStatus);

            var previousStatus = Status;
            Status = newStatus;
            
            // إضافة حدث تغيير حالة سنة مالية
            AddDomainEvent(new FiscalYearStatusChangedEvent(Id, CompanyInfoId, previousStatus, newStatus));
        }

        /// <summary>
        /// التحقق من صحة تغيير الحالة
        /// </summary>
        private void ValidateStatusChange(FiscalYearStatusEnum newStatus)
        {
            // يمكن التغيير من حالة التحضير إلى حالة النشاط فقط
            if (Status == FiscalYearStatusEnum.InPreparation && newStatus != FiscalYearStatusEnum.Active)
                throw new InvalidOperationException("يمكن تغيير حالة السنة المالية في مرحلة التحضير إلى نشطة فقط");

            // يمكن التغيير من حالة النشاط إلى حالة الإغلاق المؤقت أو غير نشط فقط
            if (Status == FiscalYearStatusEnum.Active && 
                newStatus != FiscalYearStatusEnum.Inactive && 
                newStatus != FiscalYearStatusEnum.TemporarilyClosed)
                throw new InvalidOperationException("يمكن تغيير حالة السنة المالية النشطة إلى غير نشطة أو مغلقة مؤقتاً فقط");

            // يمكن التغيير من حالة الإغلاق المؤقت إلى حالة النشاط أو الإغلاق النهائي فقط
            if (Status == FiscalYearStatusEnum.TemporarilyClosed && 
                newStatus != FiscalYearStatusEnum.Active && 
                newStatus != FiscalYearStatusEnum.Closed)
                throw new InvalidOperationException("يمكن تغيير حالة السنة المالية المغلقة مؤقتاً إلى نشطة أو مغلقة نهائياً فقط");

            // لا يمكن تغيير حالة السنة المالية المغلقة نهائياً
            if (Status == FiscalYearStatusEnum.Closed)
                throw new InvalidOperationException("لا يمكن تغيير حالة السنة المالية المغلقة نهائياً");
        }

        /// <summary>
        /// تعيين السنة المالية كسنة افتراضية
        /// </summary>
        public void SetAsDefault()
        {
            // التحقق من أن السنة المالية نشطة
            if (Status != FiscalYearStatusEnum.Active)
                throw new InvalidOperationException("يمكن تعيين السنة المالية النشطة فقط كسنة افتراضية");

            IsDefault = true;
        }

        /// <summary>
        /// إلغاء تعيين السنة المالية كسنة افتراضية
        /// </summary>
        public void UnsetAsDefault()
        {
            IsDefault = false;
        }

        /// <summary>
        /// إغلاق السنة المالية نهائياً
        /// </summary>
        public void Close(ClosingTypeEnum closingType, string notes)
        {
            // التحقق من أن السنة المالية مغلقة مؤقتاً
            if (Status != FiscalYearStatusEnum.TemporarilyClosed)
                throw new InvalidOperationException("يجب أن تكون السنة المالية مغلقة مؤقتاً قبل إغلاقها نهائياً");

            // التحقق من وجود الإعدادات اللازمة للإقفال
            if (RetainedEarningsAccountId == null || IncomeStatementAccountId == null)
                throw new InvalidOperationException("يجب تحديد حسابات الإقفال قبل إغلاق السنة المالية");

            // إضافة سجل عملية الإقفال
            var closing = new FiscalYearClosing(Id, DateTime.Now, closingType, notes);
            FiscalYearClosings.Add(closing);

            // تغيير حالة السنة المالية
            Status = FiscalYearStatusEnum.Closed;

            // إضافة حدث إقفال سنة مالية
            AddDomainEvent(new FiscalYearClosedEvent(Id, CompanyInfoId, closing.Id, closingType));
        }

        /// <summary>
        /// إعادة فتح سنة مالية مغلقة مؤقتاً
        /// </summary>
        public void Reopen()
        {
            // التحقق من أن السنة المالية مغلقة مؤقتاً
            if (Status != FiscalYearStatusEnum.TemporarilyClosed)
                throw new InvalidOperationException("يمكن إعادة فتح السنة المالية المغلقة مؤقتاً فقط");

            // تغيير حالة السنة المالية
            Status = FiscalYearStatusEnum.Active;

            // إضافة حدث تغيير حالة سنة مالية
            AddDomainEvent(new FiscalYearStatusChangedEvent(Id, CompanyInfoId, FiscalYearStatusEnum.TemporarilyClosed, FiscalYearStatusEnum.Active));
        }

        /// <summary>
        /// تحديث إعدادات الترحيل
        /// </summary>
        public void UpdateCarryOverSettings(CarryOverSettings settings)
        {
            CarryOverSettings = settings;
        }

        /// <summary>
        /// تحديث إعدادات التأمين
        /// </summary>
        public void UpdateLockSettings(LockSettings settings)
        {
            LockSettings = settings;
        }

        /// <summary>
        /// إضافة حدث نطاق
        /// </summary>
        public void AddDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }

        /// <summary>
        /// إزالة حدث نطاق
        /// </summary>
        public void RemoveDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Remove(domainEvent);
        }

        /// <summary>
        /// مسح جميع أحداث النطاق
        /// </summary>
        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }
    }
} 