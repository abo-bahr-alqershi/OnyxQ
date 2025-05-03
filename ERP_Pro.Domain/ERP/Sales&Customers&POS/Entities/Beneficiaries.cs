/**
 * @class Beneficiaries
 * @description كلاس المستفيدين المستخدم في إدارة وتتبع بيانات المستفيدين في النظام
 * @author OnyxQ Team
 */
public class Beneficiaries
{
    /// <summary>
    /// رقم المستفيد
    /// </summary>
    public int? BnfNo { get; private set; }

    /// <summary>
    /// اسم العائلة للمستفيد
    /// </summary>
    public string? BnfLNm { get; private set; }

    /// <summary>
    /// الاسم الأول للمستفيد
    /// </summary>
    public string? BnfFNm { get; private set; }

    /// <summary>
    /// رقم هاتف المستفيد
    /// </summary>
    public string? BnfTel { get; private set; }

    /// <summary>
    /// عنوان المستفيد
    /// </summary>
    public string? BnfAddrss { get; private set; }

    /// <summary>
    /// الموقع الإلكتروني
    /// </summary>
    public string? WebSite { get; private set; }

    /// <summary>
    /// حالة عدم النشاط
    /// </summary>
    public bool? Inactive { get; private set; }

    /// <summary>
    /// تاريخ تعطيل النشاط
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// سبب تعطيل النشاط
    /// </summary>
    public string? InactiveRes { get; private set; }

    /// <summary>
    /// معرف مستخدم تعطيل النشاط
    /// </summary>
    public int? InactiveUId { get; private set; }

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
    /// رقم التقرير
    /// </summary>
    public int? PrRep { get; private set; }

    /// <summary>
    /// عداد التحديث
    /// </summary>
    public long? UpCnt { get; private set; }
} 