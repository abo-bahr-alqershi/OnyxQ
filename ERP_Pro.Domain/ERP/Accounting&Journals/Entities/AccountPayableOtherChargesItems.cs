/**
 * @class AccountPayableOtherChargesItems
 * @description كلاس عناصر الرسوم الإضافية للحسابات الدائنة المستخدم في تفاصيل وإدارة عناصر الرسوم الإضافية للفواتير
 * @author OnyxQ Team
 */
public class AccountPayableOtherChargesItems
{
    /// <summary>
    /// نوع الفاتورة
    /// </summary>
    public int? BillType { get; private set; }

    /// <summary>
    /// نوع مستند الفاتورة
    /// </summary>
    public short? BillDocType { get; private set; }

    /// <summary>
    /// رقم الفاتورة
    /// </summary>
    public long? BillNo { get; private set; }

    /// <summary>
    /// الرقم المتسلسل للفاتورة
    /// </summary>
    public long BillSer { get; private set; }

    /// <summary>
    /// تاريخ المستند
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// رقم الرسوم
    /// </summary>
    public short? ChrgNo { get; private set; }

    /// <summary>
    /// رمز الحساب
    /// </summary>
    public string? ACode { get; private set; }

    /// <summary>
    /// رمز تفاصيل الحساب
    /// </summary>
    public string? AcCodeDtl { get; private set; }

    /// <summary>
    /// نوع تفاصيل الحساب
    /// </summary>
    public short? AcDtlTyp { get; private set; }

    /// <summary>
    /// عملة الحساب
    /// </summary>
    public string? ACy { get; private set; }

    /// <summary>
    /// معدل الحساب
    /// </summary>
    public int? AcRate { get; private set; }

    /// <summary>
    /// النسبة المئوية
    /// </summary>
    public int? Per { get; private set; }

    /// <summary>
    /// المبلغ
    /// </summary>
    public int? Amt { get; private set; }

    /// <summary>
    /// رمز المستودع
    /// </summary>
    public long? WCode { get; private set; }

    /// <summary>
    /// رمز مركز التكلفة
    /// </summary>
    public string? CcCode { get; private set; }

    /// <summary>
    /// رقم المشروع
    /// </summary>
    public string? PjNo { get; private set; }

    /// <summary>
    /// رقم النشاط
    /// </summary>
    public string? ActvNo { get; private set; }

    /// <summary>
    /// رقم السجل
    /// </summary>
    public long? RcrdNo { get; private set; }

    /// <summary>
    /// رقم نوع الفاتورة
    /// </summary>
    public int? BillTypeNo { get; private set; }

    /// <summary>
    /// رمز العنصر
    /// </summary>
    public string ICode { get; private set; }

    /// <summary>
    /// وحدة قياس العنصر
    /// </summary>
    public string? ItmUnt { get; private set; }

    /// <summary>
    /// حجم العبوة
    /// </summary>
    public long PSize { get; private set; }

    /// <summary>
    /// دفع الفاتورة
    /// </summary>
    public bool? BillPy { get; private set; }

    /// <summary>
    /// ترحيل خارجي
    /// </summary>
    public int? ExternalPost { get; private set; }

    /// <summary>
    /// سعر الوحدة
    /// </summary>
    public int? UnitAmt { get; private set; }

    /// <summary>
    /// رمز الترحيل
    /// </summary>
    public string? PostCode { get; private set; }

    /// <summary>
    /// رقم الشركة
    /// </summary>
    public short CmpNo { get; private set; }

    /// <summary>
    /// رقم الفرع
    /// </summary>
    public int BrnNo { get; private set; }

    /// <summary>
    /// سنة الفرع
    /// </summary>
    public short? BrnYear { get; private set; }

    /// <summary>
    /// مستخدم الفرع
    /// </summary>
    public short? BrnUsr { get; private set; }

    /// <summary>
    /// عداد التحديث
    /// </summary>
    public long? UpCnt { get; private set; }

    /// <summary>
    /// رقم التقرير
    /// </summary>
    public long? PrRep { get; private set; }

    /// <summary>
    /// اسم طرفية الإضافة
    /// </summary>
    public string? AdTrmnlNm { get; private set; }

    /// <summary>
    /// اسم طرفية التحديث
    /// </summary>
    public string? UpTrmnlNm { get; private set; }
} 