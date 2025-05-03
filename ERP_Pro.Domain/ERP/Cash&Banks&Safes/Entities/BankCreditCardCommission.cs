/**
 * @class BankCreditCardCommission
 * @description كلاس عمولات البطاقات الائتمانية البنكية المستخدم في تخزين وإدارة عمولات البطاقات الائتمانية للبنوك
 * @author OnyxQ Team
 */
public class BankCreditCardCommission
{
    /// <summary>
    /// رقم البنك
    /// </summary>
    public long? BankNumber { get; private set; }

    /// <summary>
    /// نوع البطاقة الائتمانية
    /// </summary>
    public short? CreditCardType { get; private set; }

    /// <summary>
    /// نسبة العمولة
    /// </summary>
    public int? CommissionPercentage { get; private set; }

    /// <summary>
    /// فترة الاستحقاق
    /// </summary>
    public short? DuePeriod { get; private set; }

    /// <summary>
    /// معرف مستخدم الإضافة
    /// </summary>
    public int? AddUserId { get; private set; }

    /// <summary>
    /// تاريخ الإضافة
    /// </summary>
    public DateTime? AddDate { get; private set; }

    /// <summary>
    /// معرف مستخدم التحديث
    /// </summary>
    public int? UpdateUserId { get; private set; }

    /// <summary>
    /// تاريخ التحديث
    /// </summary>
    public DateTime? UpdateDate { get; private set; }

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
    /// الحد الأقصى لنسبة العمولة
    /// </summary>
    public int? MaxCommissionPercentage { get; private set; }

    /// <summary>
    /// الحد الأقصى لمبلغ العمولة
    /// </summary>
    public int? MaxCommissionAmount { get; private set; }

    /// <summary>
    /// عملة الحد الأقصى للعمولة
    /// </summary>
    public string? MaxCommissionCurrency { get; private set; }

    /// <summary>
    /// مبلغ العمولة
    /// </summary>
    public int? CommissionAmount { get; private set; }
} 