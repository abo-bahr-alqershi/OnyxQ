using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكيان يمثل تفاصيل دخل الشيك ويحتوي على جميع خصائص تفاصيل دخل الشيكات
/// </summary>
public class CheckIncomeDetail : Entity<CheckIncomeDetailId>
{

    private CheckIncomeDetail() { }

    public CheckIncomeDetail(CheckIncomeDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// المعرف الفريد لتفاصيل دخل الشيك
    /// </summary>
    public CheckIncomeDetailId Id { get; private set; }

    /// <summary>
    /// رقم المستند
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// نوع المستند
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// تسلسل المستند
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// كود الصنف
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// كمية الصنف
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// الكمية المجانية
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// كمية الشيك
    /// </summary>
    public decimal? CheckQuantity { get; private set; }

    /// <summary>
    /// كمية الشيك المجانية
    /// </summary>
    public decimal? CheckFreeQuantity { get; private set; }

    /// <summary>
    /// وحدة الصنف
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// حجم العبوة
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// كود مركز التكلفة
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// كود المستودع
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// تاريخ الانتهاء
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// رقم التشغيلة
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// رقم المستند المرجعي
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// نوع المستند المرجعي
    /// </summary>
    public decimal? DocTypeef { get; private set; }

    /// <summary>
    /// تسلسل المستند المرجعي
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// تسلسل المستند المرجعي
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// وصف الصنف
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// الباركود
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// علم استخدام الرقم التسلسلي
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// رقم السجل
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// علم استخدام المرفقات
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// علم استلام المرفقات
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// رقم الشركة المختصر
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// رقم الفرع
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// سنة الفرع
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// مستخدم الفرع
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// طول الصنف
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// عرض الصنف
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ارتفاع الصنف المختصر
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// رقم الصنف المختصر
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// كمية الشيك الجزئية
    /// </summary>
    public decimal? CheckPartialQuantity { get; private set; }

    /// <summary>
    /// حالة الشيك
    /// </summary>
    public decimal? CheckStatus { get; private set; }

    /// <summary>
    /// ملاحظة الشيك
    /// </summary>
    public string CheckNote { get; private set; }

    /// <summary>
    /// كمية العبوة
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// كمية الشيك المجانية السابقة
    /// </summary>
    public decimal? CheckPreviousFreeQuantity { get; private set; }

    /// <summary>
    /// كمية الشيك السابقة
    /// </summary>
    public decimal? CheckPreviousQuantity { get; private set; }

    /// <summary>
    /// وحدة الوزن
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// كمية الوزن
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// رقم الحجة
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// علاقة مرجعية مع مستند دخل الشيك (متعدد إلى واحد)
    /// </summary>
    public CheckIncomeMaster CheckIncomeMaster { get; private set; }
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}

