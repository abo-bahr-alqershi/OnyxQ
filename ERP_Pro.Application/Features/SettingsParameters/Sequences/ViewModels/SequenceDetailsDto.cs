using System;
using System.Collections.Generic;

namespace ERP_Pro.Application.Features.SettingsParameters.Sequences.Models
{
    /// <summary>
    /// نموذج لعرض تفاصيل التسلسل
    /// </summary>
    public class SequenceDetailsDto
    {
        /// <summary>
        /// المعرف
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// الرمز
        /// </summary>
        public string Code { get; set; }
        
        /// <summary>
        /// الاسم بالعربية
        /// </summary>
        public string NameAr { get; set; }
        
        /// <summary>
        /// الاسم بالإنجليزية
        /// </summary>
        public string NameEn { get; set; }
        
        /// <summary>
        /// نوع المستند
        /// </summary>
        public string DocumentType { get; set; }
        
        /// <summary>
        /// المجموعة
        /// </summary>
        public string Group { get; set; }
        
        /// <summary>
        /// الوصف
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// الحالة
        /// </summary>
        public string Status { get; set; }
        
        /// <summary>
        /// قائمة الشاشات المستخدمة
        /// </summary>
        public string UsedInScreens { get; set; }
        
        /// <summary>
        /// البادئة
        /// </summary>
        public string Prefix { get; set; }
        
        /// <summary>
        /// اللاحقة
        /// </summary>
        public string Suffix { get; set; }
        
        /// <summary>
        /// تكوين الرقم التسلسلي
        /// </summary>
        public NumberConfigurationDto NumberConfiguration { get; set; }
        
        /// <summary>
        /// إعدادات نطاق الترقيم
        /// </summary>
        public RangeSettingsDto RangeSettings { get; set; }
        
        /// <summary>
        /// إعدادات الصلاحيات
        /// </summary>
        public PermissionSettingsDto PermissionSettings { get; set; }
        
        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }
        
        /// <summary>
        /// إحصائيات استخدام التسلسل
        /// </summary>
        public UsageStatisticsDto UsageStatistics { get; set; }
        
        /// <summary>
        /// قائمة نطاقات الأرقام المحجوزة
        /// </summary>
        public List<NumberAllocationDto> NumberAllocations { get; set; } = new List<NumberAllocationDto>();
    }
    
    /// <summary>
    /// نموذج تكوين الرقم التسلسلي
    /// </summary>
    public class NumberConfigurationDto
    {
        /// <summary>
        /// استخدام رمز السنة المالية
        /// </summary>
        public bool IncludeFiscalYearCode { get; set; }
        
        /// <summary>
        /// تنسيق رمز السنة
        /// </summary>
        public string YearFormat { get; set; }
        
        /// <summary>
        /// استخدام رمز الفرع
        /// </summary>
        public bool IncludeBranchCode { get; set; }
        
        /// <summary>
        /// استخدام رمز الإدارة
        /// </summary>
        public bool IncludeDepartmentCode { get; set; }
        
        /// <summary>
        /// استخدام رمز القسم
        /// </summary>
        public bool IncludeSectionCode { get; set; }
        
        /// <summary>
        /// استخدام رمز المستخدم
        /// </summary>
        public bool IncludeUserCode { get; set; }
        
        /// <summary>
        /// عدد خانات الترقيم
        /// </summary>
        public int NumberLength { get; set; }
        
        /// <summary>
        /// فاصل البادئة
        /// </summary>
        public string PrefixSeparator { get; set; }
        
        /// <summary>
        /// فاصل اللاحقة
        /// </summary>
        public string SuffixSeparator { get; set; }
        
        /// <summary>
        /// إكمال الخانات بأصفار
        /// </summary>
        public bool PadWithZeros { get; set; }
        
        /// <summary>
        /// مثال للرقم
        /// </summary>
        public string ExampleNumber { get; set; }
    }
    
    /// <summary>
    /// نموذج إعدادات نطاق الترقيم
    /// </summary>
    public class RangeSettingsDto
    {
        /// <summary>
        /// بداية نطاق الترقيم
        /// </summary>
        public long StartNumber { get; set; }
        
        /// <summary>
        /// نهاية نطاق الترقيم
        /// </summary>
        public long EndNumber { get; set; }
        
        /// <summary>
        /// الرقم الحالي
        /// </summary>
        public long CurrentNumber { get; set; }
        
        /// <summary>
        /// قيمة الزيادة
        /// </summary>
        public int Increment { get; set; }
        
        /// <summary>
        /// إعادة ضبط مع السنة المالية
        /// </summary>
        public bool ResetWithFiscalYear { get; set; }
        
        /// <summary>
        /// إعادة ضبط مع الفرع
        /// </summary>
        public bool ResetWithBranch { get; set; }
        
        /// <summary>
        /// إعادة ضبط مع الشهر
        /// </summary>
        public bool ResetWithMonth { get; set; }
    }
    
    /// <summary>
    /// نموذج إعدادات الصلاحيات
    /// </summary>
    public class PermissionSettingsDto
    {
        /// <summary>
        /// السماح بالتعديل اليدوي
        /// </summary>
        public bool AllowManualEdit { get; set; }
        
        /// <summary>
        /// المستخدمون المصرح لهم بالتعديل
        /// </summary>
        public string ManualEditAllowedUsers { get; set; }
        
        /// <summary>
        /// السماح بإعادة استخدام الأرقام الملغاة
        /// </summary>
        public bool AllowReuseOfCanceledNumbers { get; set; }
        
        /// <summary>
        /// أيام انتظار إعادة استخدام الأرقام الملغاة
        /// </summary>
        public int DaysBeforeReuseOfCanceledNumbers { get; set; }
    }
    
    /// <summary>
    /// نموذج إحصائيات استخدام التسلسل
    /// </summary>
    public class UsageStatisticsDto
    {
        /// <summary>
        /// عدد الأرقام المستخدمة
        /// </summary>
        public int UsedNumbersCount { get; set; }
        
        /// <summary>
        /// عدد الأرقام الملغاة
        /// </summary>
        public int CanceledNumbersCount { get; set; }
        
        /// <summary>
        /// عدد الفجوات
        /// </summary>
        public int GapsCount { get; set; }
        
        /// <summary>
        /// عدد النطاقات المحجوزة
        /// </summary>
        public int AllocationsCount { get; set; }
        
        /// <summary>
        /// معدل الاستخدام اليومي
        /// </summary>
        public double DailyUsageRate { get; set; }
        
        /// <summary>
        /// آخر رقم تم استخدامه
        /// </summary>
        public string LastUsedNumber { get; set; }
        
        /// <summary>
        /// تاريخ آخر استخدام
        /// </summary>
        public DateTime? LastUsageDate { get; set; }
    }
    
    /// <summary>
    /// نموذج نطاق الأرقام المحجوزة
    /// </summary>
    public class NumberAllocationDto
    {
        /// <summary>
        /// المعرف
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// بداية النطاق
        /// </summary>
        public long RangeStart { get; set; }
        
        /// <summary>
        /// نهاية النطاق
        /// </summary>
        public long RangeEnd { get; set; }
        
        /// <summary>
        /// حجم النطاق
        /// </summary>
        public long RangeSize { get; set; }
        
        /// <summary>
        /// سبب الحجز
        /// </summary>
        public string Reason { get; set; }
        
        /// <summary>
        /// اسم الفرع
        /// </summary>
        public string BranchName { get; set; }
        
        /// <summary>
        /// تاريخ الحجز
        /// </summary>
        public DateTime AllocationDate { get; set; }
        
        /// <summary>
        /// تاريخ انتهاء الصلاحية
        /// </summary>
        public DateTime? ExpiryDate { get; set; }
        
        /// <summary>
        /// الحالة
        /// </summary>
        public string Status { get; set; }
        
        /// <summary>
        /// الرقم الحالي
        /// </summary>
        public long CurrentNumber { get; set; }
        
        /// <summary>
        /// نسبة الاستخدام
        /// </summary>
        public double UtilizationPercentage { get; set; }
    }
} 