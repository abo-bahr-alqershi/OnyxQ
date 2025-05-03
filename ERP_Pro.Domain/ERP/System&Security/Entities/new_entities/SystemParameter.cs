/**
 * @class SystemParameter
 * @description كلاس معلمات النظام المستخدم في تخزين وإدارة إعدادات وخيارات النظام المختلفة
 * @author OnyxQ Team
 */
public class SystemParameter
{
    /// <summary>
    /// رقم المعلمة
    /// </summary>
    public bool? ParameterNumber { get; private set; }
    
    /// <summary>
    /// عرض فقط كشف حساب العملاء المُرحَّل
    /// </summary>
    public bool? ShowPostedOnlyCustomerStatement { get; private set; }
    
    /// <summary>
    /// موافقة تلقائية
    /// </summary>
    public bool? AutoApproved { get; private set; }
    
    /// <summary>
    /// رمز العملة
    /// </summary>
    public string? CurrencyCode { get; private set; }
    
    /// <summary>
    /// انتهاء أمر البيع بعد أيام
    /// </summary>
    public short? SalesOrderExpireAfterDays { get; private set; }
    
    /// <summary>
    /// انتهاء عرض السعر بعد أيام
    /// </summary>
    public short? QuotationExpireAfterDays { get; private set; }
    
    /// <summary>
    /// أيام حجز المنتج
    /// </summary>
    public int? ReservedProductDays { get; private set; }
    
    /// <summary>
    /// نوع أمر البيع
    /// </summary>
    public int? SalesOrderType { get; private set; }
    
    /// <summary>
    /// وصف أمر البيع
    /// </summary>
    public string? SalesOrderDescription { get; private set; }
    
    /// <summary>
    /// نوع عرض السعر
    /// </summary>
    public int? QuotationType { get; private set; }
    
    /// <summary>
    /// وصف عرض السعر
    /// </summary>
    public string? QuotationDescription { get; private set; }
    
    /// <summary>
    /// رمز مركز التكلفة
    /// </summary>
    public string? CostCenterCode { get; private set; }
    
    /// <summary>
    /// رقم المشروع
    /// </summary>
    public string? ProjectNumber { get; private set; }
    
    /// <summary>
    /// رقم النشاط
    /// </summary>
    public string? ActivityNumber { get; private set; }
    
    /// <summary>
    /// رمز المستودع
    /// </summary>
    public string? WarehouseCode { get; private set; }
    
    /// <summary>
    /// رقم مستخدم الفرع
    /// </summary>
    public short? BranchUser { get; private set; }
    
    /// <summary>
    /// معرف مستخدم التحديث
    /// </summary>
    public int? UpdateUserId { get; private set; }
    
    /// <summary>
    /// تاريخ التحديث
    /// </summary>
    public DateTime? UpdateDate { get; private set; }
    
    /// <summary>
    /// رقم الشركة
    /// </summary>
    public short? CompanyNumber { get; private set; }
    
    /// <summary>
    /// سنة الفرع
    /// </summary>
    public short? BranchYear { get; private set; }
    
    /// <summary>
    /// رقم الفرع
    /// </summary>
    public int BranchNumber { get; private set; }
    
    /// <summary>
    /// عداد التحديث
    /// </summary>
    public long? UpdateCounter { get; private set; }
    
    /// <summary>
    /// رقم التقرير
    /// </summary>
    public long? PrintReport { get; private set; }
    
    /// <summary>
    /// اسم طرفية الإضافة
    /// </summary>
    public string? AddTerminalName { get; private set; }
    
    /// <summary>
    /// اسم طرفية التحديث
    /// </summary>
    public string? UpdateTerminalName { get; private set; }
    
    /// <summary>
    /// أيام المنتج الجديد
    /// </summary>
    public int? NewItemProductDays { get; private set; }
    
    /// <summary>
    /// أيام فترة المنتج غير المخزن
    /// </summary>
    public int? ItemNotStorePeriodDays { get; private set; }
    
    /// <summary>
    /// ربط نشاط العميل بالعنصر
    /// </summary>
    public bool? ConnectCustomerItemActivity { get; private set; }
    
    /// <summary>
    /// طريقة تخزين كمية أمر البيع
    /// </summary>
    public short? SalesOrderQuantityStoreMethod { get; private set; }
    
    /// <summary>
    /// حد العميل لأوامر البيع غير المعالجة
    /// </summary>
    public int? CustomerLimitSalesOrderUnprocessed { get; private set; }
}