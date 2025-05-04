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
/// CostCenter Entity
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
    /// The unique identifier for the CostCenter
    /// المعرف الفريد لـ CostCenter
    /// </summary>
    public CostCenterId Id { get; private set; }

    /// <summary>
    /// CostCenterNumber of the CostCenter
    /// CostCenterNumber الخاص بـ CostCenter
    /// </summary>
    public decimal? CostCenterNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the CostCenter
    /// CostCenterCode الخاص بـ CostCenter
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// CostCenterNameArabic of the CostCenter
    /// CostCenterNameArabic الخاص بـ CostCenter
    /// </summary>
    public string CostCenterNameArabic { get; private set; }

    /// <summary>
    /// CostCenterNameEnglish of the CostCenter
    /// CostCenterNameEnglish الخاص بـ CostCenter
    /// </summary>
    public string CostCenterNameEnglish { get; private set; }

    /// <summary>
    /// CLevel of the CostCenter
    /// CLevel الخاص بـ CostCenter
    /// </summary>
    public decimal? CLevel { get; private set; }

    /// <summary>
    /// CParent of the CostCenter
    /// CParent الخاص بـ CostCenter
    /// </summary>
    public string CParent { get; private set; }

    /// <summary>
    /// CSr of the CostCenter
    /// CSr الخاص بـ CostCenter
    /// </summary>
    public decimal? CSr { get; private set; }

    /// <summary>
    /// InactiveFlag of the CostCenter
    /// InactiveFlag الخاص بـ CostCenter
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the CostCenter
    /// InactiveReason الخاص بـ CostCenter
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the CostCenter
    /// InactiveDate الخاص بـ CostCenter
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// OpenBalance of the CostCenter
    /// OpenBalance الخاص بـ CostCenter
    /// </summary>
    public decimal? OpenBalance { get; private set; }

    /// <summary>
    /// CurrBal of the CostCenter
    /// CurrBal الخاص بـ CostCenter
    /// </summary>
    public decimal? CurrBal { get; private set; }

    /// <summary>
    /// ImportExcelFlag of the CostCenter
    /// ImportExcelFlag الخاص بـ CostCenter
    /// </summary>
    public decimal? ImportExcelFlag { get; private set; }

    /// <summary>
    /// UseProject of the CostCenter
    /// UseProject الخاص بـ CostCenter
    /// </summary>
    public decimal? UseProject { get; private set; }

    /// <summary>
    /// Field1 of the CostCenter
    /// Field1 الخاص بـ CostCenter
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the CostCenter
    /// Field2 الخاص بـ CostCenter
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the CostCenter
    /// Field3 الخاص بـ CostCenter
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the CostCenter
    /// Field4 الخاص بـ CostCenter
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the CostCenter
    /// Field5 الخاص بـ CostCenter
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the CostCenter
    /// Field6 الخاص بـ CostCenter
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the CostCenter
    /// Field7 الخاص بـ CostCenter
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the CostCenter
    /// Field8 الخاص بـ CostCenter
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the CostCenter
    /// Field9 الخاص بـ CostCenter
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the CostCenter
    /// Field10 الخاص بـ CostCenter
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// InactiveSalesFlag of the CostCenter
    /// InactiveSalesFlag الخاص بـ CostCenter
    /// </summary>
    public decimal? InactiveSalesFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenterGroup CostCenterGroup { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenterType CostCenterType { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
