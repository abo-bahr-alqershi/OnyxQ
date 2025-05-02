public class Employee
{
    /// <summary>الرقم الوظيفي للموظف</summary>
    public string EmployeeNumber { get; private set; }
    /// <summary>اسم الموظف بالعربية</summary>
    public string EmployeeNameArabic { get; private set; }
    /// <summary>اسم الموظف بالإنجليزية</summary>
    public string? EmployeeNameEnglish { get; private set; }
    /// <summary>تاريخ الميلاد</summary>
    public DateTime? BirthDate { get; private set; }
    /// <summary>تاريخ التعيين</summary>
    public DateTime? HireDate { get; private set; }
    /// <summary>الحالة الوظيفية (نشط/غير نشط)</summary>
    public bool? IsActive { get; private set; }
    /// <summary>رقم الهوية الوطنية</summary>
    public string? NationalId { get; private set; }
    /// <summary>الجنسية</summary>
    public string? Nationality { get; private set; }
    /// <summary>رقم الجوال</summary>
    public string? MobileNumber { get; private set; }
    /// <summary>البريد الإلكتروني</summary>
    public string? Email { get; private set; }
    /// <summary>العنوان</summary>
    public string? Address { get; private set; }
    /// <summary>رقم المستخدم الذي أضاف السجل</summary>
    public int? AddedByUserId { get; private set; }
    /// <summary>تاريخ الإضافة</summary>
    public DateTime? AddedDate { get; private set; }
    /// <summary>رقم المستخدم الذي عدّل السجل</summary>
    public int? UpdatedByUserId { get; private set; }
    /// <summary>تاريخ آخر تعديل</summary>
    public DateTime? UpdatedDate { get; private set; }
    /// <summary>عدد مرات التعديل</summary>
    public long? UpdateCount { get; private set; }
    /// <summary>أولوية التقرير</summary>
    public long? ReportPriority { get; private set; }
    /// <summary>اسم الجهاز عند الإضافة</summary>
    public string? AddedTerminal { get; private set; }
    /// <summary>اسم الجهاز عند التعديل</summary>
    public string? UpdatedTerminal { get; private set; }
    /// <summary>رقم الضمان الاجتماعي</summary>
    public long? SocialSecurityNo { get; private set; }
    /// <summary>تاريخ الإعادة للعمل</summary>
    public DateTime? ReinstatementDate { get; private set; }
    /// <summary>رقم المحافظة</summary>
    public long? ProvinceNo { get; private set; }
    /// <summary>نوع فترة العمل</summary>
    public bool? WorkPeriodType { get; private set; }
    /// <summary>نوع عقد الموظف</summary>
    public bool? EmployeeContractType { get; private set; }
    /// <summary>طريقة تتبع الموظف</summary>
    public bool? EmployeeTrackMethod { get; private set; }
    /// <summary>حد التغذية المالية</summary>
    public int? FeedLimitAmount { get; private set; }
    /// <summary>نوع حد التغذية</summary>
    public bool? FeedLimitType { get; private set; }
    /// <summary>نوع نهاية العمل</summary>
    public long? EndWorkType { get; private set; }
    /// <summary>بداية التأمين الطبي</summary>
    public DateTime? EmployeeMedicalStartDate { get; private set; }
    /// <summary>نهاية التأمين الطبي</summary>
    public DateTime? EmployeeMedicalEndDate { get; private set; }
    /// <summary>قيمة مادة النظام الافتراضية</summary>
    public int? DefaultLawArticleValue { get; private set; }
    /// <summary>نوع الحضور</summary>
    public bool? EmployeeAttendanceType { get; private set; }
    /// <summary>نوع جهاز الحضور</summary>
    public bool? AttendanceMobileType { get; private set; }
    /// <summary>نوع التقاط الصورة عبر الجوال</summary>
    public bool? MobileCaptureImageType { get; private set; }
    /// <summary>المنطقة الزمنية للحضور</summary>
    public string? AttendanceTimezone { get; private set; }
    /// <summary>نوع الاتصال بالجوال</summary>
    public bool? MobileConnectType { get; private set; }
    /// <summary>رقم تسلسل جهاز الحضور</summary>
    public string? AttendanceMobileSerial { get; private set; }
    /// <summary>تفعيل الموقع في الحضور</summary>
    public bool? UseAttendanceLocation { get; private set; }
    /// <summary>مزامنة الحضور عبر الجوال</summary>
    public bool? MobileAttendanceSync { get; private set; }
    /// <summary>حساب فيسبوك</summary>
    public string? Facebook { get; private set; }
    /// <summary>حساب تويتر</summary>
    public string? Twitter { get; private set; }
    /// <summary>حساب انستغرام</summary>
    public string? Instagram { get; private set; }
    /// <summary>حساب تيليجرام</summary>
    public string? Telegram { get; private set; }
    /// <summary>حالة احتساب الإجازة الأسبوعية</summary>
    public bool? WeeklyDayoffCalcStatus { get; private set; }
    /// <summary>عدد أيام الشفت المطلوبة للإجازة الأسبوعية</summary>
    public bool? WeeklyDayoffShiftDaysRequired { get; private set; }
    /// <summary>عدد الأيام النظامية للإجازة الأسبوعية</summary>
    public bool? WeeklyDayoffRegularDaysRequired { get; private set; }
    /// <summary>مقارنة أيام الإجازة الأسبوعية بالتساوي</summary>
    public bool? WeeklyDayoffCompareEqual { get; private set; }
    /// <summary>رقم مرجع إجازة أسبوعية</summary>
    public int? WeeklyDayoffRefHolidayNo { get; private set; }
    /// <summary>عدد أيام الأسبوع</summary>
    public bool? WeekDays { get; private set; }
    /// <summary>حد العمر للتأمين الطبي</summary>
    public int? EmployeeMedicalAgeLimit { get; private set; }
    public Employee Employee { get; private set; } // Navigation
    public Employee Employee { get; private set; } // Navigation
    public CurrencyExchangeRate CurrencyExchangeRate { get; private set; } // Navigation
    public Project Project { get; private set; } // Navigation
    public ICollection<Employee> Employees { get; private set; } // Inverse Navigation
    public ICollection<EmployeeBank> EmployeeBanks { get; private set; } // Inverse Navigation
    public ICollection<EmployeeFamily> EmployeeFamilies { get; private set; } // Inverse Navigation
    public ICollection<EmployeeGuarantor> EmployeeGuarantors { get; private set; } // Inverse Navigation
}