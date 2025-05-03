/**
 * @class AccountPayableOtherCharges
 * @description كلاس الرسوم الإضافية للحسابات الدائنة المستخدم في إدارة وتتبع الرسوم الإضافية على الفواتير
 * @author OnyxQ Team
 */
public class AccountPayableOtherCharges
{
    /// <summary>
    /// نوع الفاتورة
    /// </summary>
    public int BillType { get; private set; }

    /// <summary>
    /// نوع مستند الفاتورة
    /// </summary>
    public short BillDocType { get; private set; }

    /// <summary>
    /// رقم الفاتورة
    /// </summary>
    public long BillNo { get; private set; }

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
    public string ACode { get; private set; }

    /// <summary>
    /// عملة الحساب
    /// </summary>
    public string ACy { get; private set; }

    /// <summary>
    /// معدل الحساب
    /// </summary>
    public int AcRate { get; private set; }

    /// <summary>
    /// النسبة المئوية
    /// </summary>
    public int? Per { get; private set; }

    /// <summary>
    /// المبلغ
    /// </summary>
    public int? Amt { get; private set; }

    /// <summary>
    /// نوع فاتورة الرسوم
    /// </summary>
    public int? ChrgBillType { get; private set; }

    /// <summary>
    /// رقم السجل
    /// </summary>
    public long? RcrdNo { get; private set; }

    /// <summary>
    /// دفع الفاتورة
    /// </summary>
    public bool? BillPy { get; private set; }

    /// <summary>
    /// ترحيل خارجي
    /// </summary>
    public int? ExternalPost { get; private set; }

    /// <summary>
    /// مبلغ ضريبة القيمة المضافة
    /// </summary>
    public int? VatAmt { get; private set; }

    /// <summary>
    /// نسبة ضريبة القيمة المضافة
    /// </summary>
    public int? VatPer { get; private set; }

    /// <summary>
    /// استخدام ضريبة القيمة المضافة
    /// </summary>
    public int? UseVat { get; private set; }

    /// <summary>
    /// رمز تفاصيل الحساب
    /// </summary>
    public string? AcCodeDtl { get; private set; }

    /// <summary>
    /// نوع تفاصيل الحساب
    /// </summary>
    public short? AcDtlTyp { get; private set; }

    /// <summary>
    /// رقم الشركة
    /// </summary>
    public short CmpNo { get; private set; }

    /// <summary>
    /// رقم الفرع
    /// </summary>
    public int? BrnNo { get; private set; }

    /// <summary>
    /// سنة الفرع
    /// </summary>
    public short? BrnYear { get; private set; }

    /// <summary>
    /// مستخدم الفرع
    /// </summary>
    public short? BrnUsr { get; private set; }

    /// <summary>
    /// اسم طرفية الإضافة
    /// </summary>
    public string? AdTrmnlNm { get; private set; }

    /// <summary>
    /// اسم طرفية التحديث
    /// </summary>
    public string? UpTrmnlNm { get; private set; }

    /// <summary>
    /// استخدام ضريبة الاستقطاع
    /// </summary>
    public int? UseTds { get; private set; }
} 