/**
 * @class CustomerLoyaltyPointTracker
 * @description كلاس متتبع نقاط الولاء للعملاء المستخدم في إدارة وتتبع نقاط برنامج الولاء للعملاء النقديين
 * @author OnyxQ Team
 */
public class CustomerLoyaltyPointTracker
{
    /// <summary>
    /// رمز العميل
    /// </summary>
    public string CustCode { get; private set; }

    /// <summary>
    /// رقم نوع النقاط
    /// </summary>
    public int PointTypNo { get; private set; }

    /// <summary>
    /// تاريخ تفعيل نوع النقاط
    /// </summary>
    public DateTime? PointTypActvDate { get; private set; }

    /// <summary>
    /// رقم بطاقة الخصم
    /// </summary>
    public string? CrdNoDisc { get; private set; }

    /// <summary>
    /// معرف مستخدم التحديث
    /// </summary>
    public int? UpUId { get; private set; }

    /// <summary>
    /// تاريخ التحديث
    /// </summary>
    public DateTime? UpDate { get; private set; }

    /// <summary>
    /// اسم طرفية التحديث
    /// </summary>
    public string? UpTrmnlNm { get; private set; }

    /// <summary>
    /// عداد التحديث
    /// </summary>
    public long? UpCnt { get; private set; }

    /// <summary>
    /// رقم التقرير
    /// </summary>
    public long? PrRep { get; private set; }

    /// <summary>
    /// اسم المجموعة بالعربية
    /// </summary>
    public string? GroupName { get; private set; }

    /// <summary>
    /// اسم المجموعة بالإنجليزية
    /// </summary>
    public string? GroupEName { get; private set; }

    /// <summary>
    /// معرف مستخدم الإضافة
    /// </summary>
    public int? AdUId { get; private set; }

    /// <summary>
    /// تاريخ الإضافة
    /// </summary>
    public DateTime? AdDate { get; private set; }

    /// <summary>
    /// اسم طرفية الإضافة
    /// </summary>
    public string? AdTrmnlNm { get; private set; }

    /// <summary>
    /// رمز الحساب
    /// </summary>
    public string? ACode { get; private set; }

    /// <summary>
    /// عملة الحساب
    /// </summary>
    public string? ACy { get; private set; }

    /// <summary>
    /// الرصيد الافتتاحي المحلي
    /// </summary>
    public int? OpenBalL { get; private set; }

    /// <summary>
    /// الرصيد الافتتاحي الأجنبي
    /// </summary>
    public int? OpenBalF { get; private set; }

    /// <summary>
    /// الرصيد الحالي المحلي
    /// </summary>
    public int? CurrBalL { get; private set; }

    /// <summary>
    /// الرصيد الحالي الأجنبي
    /// </summary>
    public int? CurrBalF { get; private set; }

    /// <summary>
    /// غير نشط
    /// </summary>
    public bool? Inactive { get; private set; }

    /// <summary>
    /// الحد الأدنى للمبلغ
    /// </summary>
    public int? MinLmtAmt { get; private set; }

    /// <summary>
    /// الحد الأقصى للمبلغ
    /// </summary>
    public int? MaxLmtAmt { get; private set; }

    /// <summary>
    /// الحد الأقصى لمبلغ المعاملة
    /// </summary>
    public int? MaxLmtTrnsAmt { get; private set; }

    /// <summary>
    /// الحد الأدنى لمبلغ المعاملة
    /// </summary>
    public int? MinLmtTrnsAmt { get; private set; }

    /// <summary>
    /// تجاوز الحد
    /// </summary>
    public bool? PassLmt { get; private set; }

    /// <summary>
    /// تاريخ تعطيل النشاط
    /// </summary>
    public DateTime? InactiveDate { get; private set; }
} 