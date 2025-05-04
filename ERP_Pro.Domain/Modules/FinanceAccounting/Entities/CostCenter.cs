using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;
using ERP_Pro.Domain.ERP.GeneralLedger.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.PurchasingVendors.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.HumanResources.Entities;
using ERP_Pro.Domain.ERP.GuaranteesWarranties.Entities;
using ERP_Pro.Domain.ERP.ArchivingDocuments.Entities;
using ERP_Pro.Domain.ERP.FormsSurveys.Entities;
using ERP_Pro.Domain.ERP.TaxFees.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل مركز التكلفة ويحتوي على جميع خصائص مراكز التكلفة
/// </summary>
public class CostCenter : Entity<CostCenterId>
{

    private CostCenter() { }

    public CostCenter(CostCenterId id, string costCenterCode)
    {
        Id = id;
        CostCenterCode = costCenterCode;
    }

    /// <summary>
    /// المعرف الفريد لمركز التكلفة
    /// </summary>
    public CostCenterId Id { get; private set; }

    /// <summary>
    /// رقم مركز التكلفة
    /// </summary>
    public decimal? CostCenterNumber { get; private set; }

    /// <summary>
    /// كود مركز التكلفة
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// اسم مركز التكلفة بالعربية
    /// </summary>
    public string CostCenterNameArabic { get; private set; }

    /// <summary>
    /// اسم مركز التكلفة بالإنجليزية
    /// </summary>
    public string CostCenterNameEnglish { get; private set; }

    /// <summary>
    /// مستوى مركز التكلفة
    /// </summary>
    public decimal? CLevel { get; private set; }

    /// <summary>
    /// كود الأب لمركز التكلفة
    /// </summary>
    public string CParent { get; private set; }

    /// <summary>
    /// تسلسل مركز التكلفة
    /// </summary>
    public decimal? CSr { get; private set; }

    /// <summary>
    /// علم التعطيل
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// سبب التعطيل
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// تاريخ التعطيل
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// الرصيد الافتتاحي
    /// </summary>
    public decimal? OpenBalance { get; private set; }

    /// <summary>
    /// الرصيد الحالي
    /// </summary>
    public decimal? CurrBal { get; private set; }

    /// <summary>
    /// علم استيراد الإكسل
    /// </summary>
    public decimal? ImportExcelFlag { get; private set; }

    /// <summary>
    /// استخدام المشروع
    /// </summary>
    public decimal? UseProject { get; private set; }

    /// <summary>
    /// الحقل الأول
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// الحقل الثاني
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// الحقل الثالث
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// الحقل الرابع
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// الحقل الخامس
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// الحقل السادس
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// الحقل السابع
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// الحقل الثامن
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// الحقل التاسع
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// الحقل العاشر
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// علم تعطيل المبيعات
    /// </summary>
    public decimal? InactiveSalesFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// علاقة مرجعية: متعدد إلى واحد
    /// </summary>
    public CostCenterGroup CostCenterGroup { get; private set; }
    /// <summary>
    /// علاقة مرجعية: متعدد إلى واحد
    /// </summary>
    public CostCenterType CostCenterType { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
