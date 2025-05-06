using System;
using System.Collections.Generic;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.ViewModels
{
    /// <summary>
    /// نموذج تفاصيل الفترة المحاسبية
    /// </summary>
    public class FiscalPeriodDetailsDto
    {
        /// <summary>
        /// المعرف
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// معرف السنة المالية
        /// </summary>
        public Guid FiscalYearId { get; set; }

        /// <summary>
        /// رمز السنة المالية
        /// </summary>
        public string FiscalYearCode { get; set; }
        
        /// <summary>
        /// اسم السنة المالية
        /// </summary>
        public string FiscalYearName { get; set; }

        /// <summary>
        /// رقم الفترة التسلسلي
        /// </summary>
        public int PeriodNumber { get; set; }

        /// <summary>
        /// رمز الفترة
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// اسم الفترة بالعربية
        /// </summary>
        public string NameAr { get; set; }

        /// <summary>
        /// اسم الفترة بالإنجليزية
        /// </summary>
        public string NameEn { get; set; }

        /// <summary>
        /// تاريخ البداية
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// تاريخ النهاية
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// نوع الفترة
        /// </summary>
        public FiscalPeriodTypeEnum PeriodType { get; set; }

        /// <summary>
        /// اسم نوع الفترة
        /// </summary>
        public string PeriodTypeName { get; set; }

        /// <summary>
        /// حالة الفترة
        /// </summary>
        public FiscalPeriodStatusEnum Status { get; set; }

        /// <summary>
        /// اسم حالة الفترة
        /// </summary>
        public string StatusName { get; set; }

        /// <summary>
        /// الفترة الافتراضية للإقفال
        /// </summary>
        public bool IsClosingDefault { get; set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// تاريخ الإنشاء
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// اسم منشئ الفترة المحاسبية
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// تاريخ آخر تحديث
        /// </summary>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// اسم آخر من قام بالتعديل
        /// </summary>
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// عمليات تأمين الفترة
        /// </summary>
        public List<FiscalPeriodLockDto> PeriodLocks { get; set; }

        /// <summary>
        /// تسويات الفترة
        /// </summary>
        public List<FiscalPeriodAdjustmentDto> PeriodAdjustments { get; set; }

        /// <summary>
        /// عدد القيود المحاسبية المرتبطة بالفترة
        /// </summary>
        public int JournalEntriesCount { get; set; }

        /// <summary>
        /// الفترة الحالية
        /// </summary>
        public bool IsCurrent { get; set; }

        /// <summary>
        /// المنشئ
        /// </summary>
        public FiscalPeriodDetailsDto()
        {
            PeriodLocks = new List<FiscalPeriodLockDto>();
            PeriodAdjustments = new List<FiscalPeriodAdjustmentDto>();
        }
    }

    /// <summary>
    /// نموذج تأمين الفترة المحاسبية
    /// </summary>
    public class FiscalPeriodLockDto
    {
        /// <summary>
        /// المعرف
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// معرف الفترة المحاسبية
        /// </summary>
        public Guid FiscalPeriodId { get; set; }

        /// <summary>
        /// تاريخ بداية التأمين
        /// </summary>
        public DateTime LockStartDate { get; set; }

        /// <summary>
        /// تاريخ نهاية التأمين
        /// </summary>
        public DateTime? LockEndDate { get; set; }

        /// <summary>
        /// نوع التأمين
        /// </summary>
        public LockTypeEnum LockType { get; set; }

        /// <summary>
        /// اسم نوع التأمين
        /// </summary>
        public string LockTypeName { get; set; }

        /// <summary>
        /// سبب التأمين
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// المستخدم الذي قام بالتأمين
        /// </summary>
        public string PerformedBy { get; set; }

        /// <summary>
        /// المستخدم الذي قام بإلغاء التأمين
        /// </summary>
        public string UnlockedBy { get; set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// تاريخ الإنشاء
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// حالة التأمين (نشط/منتهي)
        /// </summary>
        public bool IsActive { get; set; }
    }

    /// <summary>
    /// نموذج تسوية الفترة المحاسبية
    /// </summary>
    public class FiscalPeriodAdjustmentDto
    {
        /// <summary>
        /// المعرف
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// معرف الفترة المحاسبية
        /// </summary>
        public Guid FiscalPeriodId { get; set; }

        /// <summary>
        /// نوع التسوية
        /// </summary>
        public AdjustmentTypeEnum AdjustmentType { get; set; }

        /// <summary>
        /// اسم نوع التسوية
        /// </summary>
        public string AdjustmentTypeName { get; set; }

        /// <summary>
        /// تاريخ التسوية
        /// </summary>
        public DateTime AdjustmentDate { get; set; }

        /// <summary>
        /// وصف التسوية
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// المستخدم الذي قام بالتسوية
        /// </summary>
        public string PerformedBy { get; set; }

        /// <summary>
        /// معرف قيد التسوية
        /// </summary>
        public Guid? JournalEntryId { get; set; }

        /// <summary>
        /// رقم قيد التسوية
        /// </summary>
        public string JournalEntryNumber { get; set; }

        /// <summary>
        /// حالة التسوية
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// تاريخ الإنشاء
        /// </summary>
        public DateTime Created { get; set; }
    }
} 