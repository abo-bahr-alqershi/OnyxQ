/**
 * @class BankCreditCardCommissionRate
 * @description كلاس معدلات عمولات البطاقات الائتمانية البنكية المستخدم في تخزين وإدارة نسب وقيم العمولات للبطاقات الائتمانية
 * @author OnyxQ Team
 */
public class BankCreditCardCommissionRate
{
    /// <summary>
    /// رقم البنك
    /// </summary>
    public int BankNumber { get; private set; }

    /// <summary>
    /// نوع البطاقة الائتمانية
    /// </summary>
    public short CreditCardType { get; private set; }

    /// <summary>
    /// نسبة العمولة
    /// </summary>
    public decimal CommissionPercentage { get; private set; }

    /// <summary>
    /// فترة التسوية بالأيام
    /// </summary>
    public int SettlementPeriodDays { get; private set; }

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
}