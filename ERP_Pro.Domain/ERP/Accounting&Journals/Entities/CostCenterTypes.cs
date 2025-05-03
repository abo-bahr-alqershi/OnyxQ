/**
 * @class CostCenterTypes
 * @description كلاس أنواع مراكز التكلفة المستخدم في تصنيف وإدارة أنواع مراكز التكلفة المختلفة في النظام
 * @author OnyxQ Team
 */
public class CostCenterTypes
{
    /// <summary>
    /// نوع مركز التكلفة
    /// </summary>
    public int? CcType { get; private set; }

    /// <summary>
    /// اسم مركز التكلفة بالعربية
    /// </summary>
    public string CcName { get; private set; }

    /// <summary>
    /// اسم مركز التكلفة بالإنجليزية
    /// </summary>
    public string? CcEName { get; private set; }

    /// <summary>
    /// يتأثر بالحركات
    /// </summary>
    public bool? AffectedByTrans { get; private set; }

    /// <summary>
    /// معرف مستخدم الإضافة
    /// </summary>
    public int? AdUId { get; private set; }

    /// <summary>
    /// تاريخ الإضافة
    /// </summary>
    public DateTime? AdDate { get; private set; }

    /// <summary>
    /// معرف مستخدم التحديث
    /// </summary>
    public int? UpUId { get; private set; }

    /// <summary>
    /// تاريخ التحديث
    /// </summary>
    public DateTime? UpDate { get; private set; }

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