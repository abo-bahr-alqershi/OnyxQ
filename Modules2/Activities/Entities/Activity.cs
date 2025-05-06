using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;
using ERP_Pro.Domain.ERP.GeneralLedger.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.PurchasingVendors.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.ProductionManufacturing.Entities;
using ERP_Pro.Domain.ERP.HumanResources.Entities;
using ERP_Pro.Domain.ERP.GuaranteesWarranties.Entities;
using ERP_Pro.Domain.ERP.ArchivingDocuments.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FormsSurveys.Entities;
using ERP_Pro.Domain.ERP.SettingsParameters.Entities;
using ERP_Pro.Domain.ERP.TaxFees.Entities;

using ERP_Pro.Domain.ERP.Activities.ValueObjects;
namespace ERP_Pro.Domain.ERP.Activities.Entities
{
/// <summary>
/// Activity Entity
/// </summary>
public class Activity : Entity<ActivityId>
{

    private Activity() { }

    public Activity(ActivityId id, string activityNumber)
    {
        Id = id;
        ActivityNumber = activityNumber;
    }

    /// <summary>
    /// The unique identifier for the Activity
    /// المعرف الفريد لـ Activity
    /// </summary>
    public ActivityId Id { get; private set; }

    /// <summary>
    /// ActivityNumber of the Activity
    /// ActivityNumber الخاص بـ Activity
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ActivityCode of the Activity
    /// ActivityCode الخاص بـ Activity
    /// </summary>
    public string ActivityCode { get; private set; }

    /// <summary>
    /// ActivityAName of the Activity
    /// ActivityAName الخاص بـ Activity
    /// </summary>
    public string ActivityAName { get; private set; }

    /// <summary>
    /// ActivityEName of the Activity
    /// ActivityEName الخاص بـ Activity
    /// </summary>
    public string ActivityEName { get; private set; }

    /// <summary>
    /// ActivityParent of the Activity
    /// ActivityParent الخاص بـ Activity
    /// </summary>
    public string ActivityParent { get; private set; }

    /// <summary>
    /// ActivityLevel of the Activity
    /// ActivityLevel الخاص بـ Activity
    /// </summary>
    public decimal? ActivityLevel { get; private set; }

    /// <summary>
    /// ActivitySub of the Activity
    /// ActivitySub الخاص بـ Activity
    /// </summary>
    public decimal? ActivitySub { get; private set; }

    /// <summary>
    /// InactiveFlag of the Activity
    /// InactiveFlag الخاص بـ Activity
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the Activity
    /// InactivatedByUserId الخاص بـ Activity
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the Activity
    /// InactiveDate الخاص بـ Activity
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the Activity
    /// InactiveReason الخاص بـ Activity
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// ImportExcelFlag of the Activity
    /// ImportExcelFlag الخاص بـ Activity
    /// </summary>
    public decimal? ImportExcelFlag { get; private set; }

    /// <summary>
    /// Field1 of the Activity
    /// Field1 الخاص بـ Activity
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the Activity
    /// Field2 الخاص بـ Activity
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the Activity
    /// Field3 الخاص بـ Activity
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the Activity
    /// Field4 الخاص بـ Activity
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the Activity
    /// Field5 الخاص بـ Activity
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the Activity
    /// Field6 الخاص بـ Activity
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the Activity
    /// Field7 الخاص بـ Activity
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the Activity
    /// Field8 الخاص بـ Activity
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the Activity
    /// Field9 الخاص بـ Activity
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the Activity
    /// Field10 الخاص بـ Activity
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// ActivityDescription of the Activity
    /// ActivityDescription الخاص بـ Activity
    /// </summary>
    public string ActivityDescription { get; private set; }

    /// <summary>
    /// ProjectNumber of the Activity
    /// ProjectNumber الخاص بـ Activity
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// StageCode of the Activity
    /// StageCode الخاص بـ Activity
    /// </summary>
    public string StageCode { get; private set; }

    /// <summary>
    /// PlanCode of the Activity
    /// PlanCode الخاص بـ Activity
    /// </summary>
    public string PlanCode { get; private set; }

    /// <summary>
    /// ItemCostType of the Activity
    /// ItemCostType الخاص بـ Activity
    /// </summary>
    public decimal? ItemCostType { get; private set; }

    /// <summary>
    /// ItemCode of the Activity
    /// ItemCode الخاص بـ Activity
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// MeasureCode of the Activity
    /// MeasureCode الخاص بـ Activity
    /// </summary>
    public string MeasureCode { get; private set; }

    /// <summary>
    /// CostPrice of the Activity
    /// CostPrice الخاص بـ Activity
    /// </summary>
    public decimal? CostPrice { get; private set; }

    /// <summary>
    /// SalesPrice of the Activity
    /// SalesPrice الخاص بـ Activity
    /// </summary>
    public decimal? SalesPrice { get; private set; }

    /// <summary>
    /// QuantityAmountFlag of the Activity
    /// QuantityAmountFlag الخاص بـ Activity
    /// </summary>
    public decimal? QuantityAmountFlag { get; private set; }

    /// <summary>
    /// CostAccountCode of the Activity
    /// CostAccountCode الخاص بـ Activity
    /// </summary>
    public string CostAccountCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ActivityGroup ActivityGroup { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

