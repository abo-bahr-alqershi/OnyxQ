using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Base;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.SettingsParameters.Events;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Domain.SettingsParameters.Entities
{
    /// <summary>
    /// كيان الفترة المحاسبية
    /// </summary>
    public class FiscalPeriod : ERP_Pro.Domain.Common.Base.AuditableEntity<Guid>
    {
        /// <summary>
        /// معرف السنة المالية
        /// </summary>
        public Guid FiscalYearId { get; private set; }

        /// <summary>
        /// رقم الفترة التسلسلي
        /// </summary>
        public int PeriodNumber { get; private set; }

        /// <summary>
        /// رمز الفترة
        /// </summary>
        public string Code { get; private set; }

        /// <summary>
        /// اسم الفترة بالعربية
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
        /// ملاحظات
        /// </summary>
        public string Notes { get; private set; }

        /// <summary>
        /// السنة المالية المرتبطة
        /// </summary>
        public virtual FiscalYear FiscalYear { get; private set; }

        /// <summary>
        /// عمليات تأمين الفترة
        /// </summary>
        public virtual ICollection<FiscalPeriodLock> PeriodLocks { get; private set; }

        /// <summary>
        /// تسويات الفترة
        /// </summary>
        public virtual ICollection<FiscalPeriodAdjustment> PeriodAdjustments { get; private set; }

        // للاستخدام من قبل EF Core
        protected FiscalPeriod()
        {
            PeriodLocks = new HashSet<FiscalPeriodLock>();
            PeriodAdjustments = new HashSet<FiscalPeriodAdjustment>();
        }

        /// <summary>
        /// إنشاء فترة محاسبية جديدة
        /// </summary>
        public FiscalPeriod(
            Guid fiscalYearId,
            int periodNumber,
            string code,
            string nameAr,
            string nameEn,
            DateTime startDate,
            DateTime endDate,
            FiscalPeriodTypeEnum periodType,
            string notes = null)
        {
            FiscalYearId = fiscalYearId;
            PeriodNumber = periodNumber;
            Code = code;
            NameAr = nameAr;
            NameEn = nameEn;
            StartDate = startDate;
            EndDate = endDate;
            PeriodType = periodType;
            Notes = notes;
            
            Status = FiscalPeriodStatusEnum.InPreparation;
            IsClosingDefault = false;
            
            PeriodLocks = new HashSet<FiscalPeriodLock>();
            PeriodAdjustments = new HashSet<FiscalPeriodAdjustment>();
            
            // إضافة حدث إنشاء فترة محاسبية
            AddDomainEvent(new FiscalPeriodCreatedEvent(Id, FiscalYearId, PeriodNumber, Code, StartDate, EndDate, Status));
        }

        /// <summary>
        /// تحديث بيانات الفترة المحاسبية
        /// </summary>
        public void Update(
            string nameAr,
            string nameEn,
            DateTime startDate,
            DateTime endDate,
            FiscalPeriodTypeEnum periodType,
            bool isClosingDefault,
            string notes)
        {
            // التحقق من أن الفترة ليست مغلقة نهائياً
            if (Status == FiscalPeriodStatusEnum.Closed || Status == FiscalPeriodStatusEnum.Locked)
                throw new InvalidOperationException("لا يمكن تعديل فترة محاسبية مغلقة نهائياً أو مؤمنة");

            NameAr = nameAr;
            NameEn = nameEn;
            StartDate = startDate;
            EndDate = endDate;
            PeriodType = periodType;
            IsClosingDefault = isClosingDefault;
            Notes = notes;

            // إضافة حدث تحديث فترة محاسبية
            AddDomainEvent(new FiscalPeriodUpdatedEvent(Id, FiscalYearId, PeriodNumber, Code, StartDate, EndDate, Status));
        }

        /// <summary>
        /// تغيير حالة الفترة المحاسبية
        /// </summary>
        public void ChangeStatus(FiscalPeriodStatusEnum newStatus)
        {
            var previousStatus = Status;
            Status = newStatus;
            
            // إضافة حدث تغيير حالة فترة محاسبية
            AddDomainEvent(new FiscalPeriodStatusChangedEvent(Id, FiscalYearId, previousStatus, newStatus));
        }
    }
} 