using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;
using ERP_Pro.Domain.ERP.GeneralLedger.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.PurchasingVendors.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.ProductionManufacturing.Entities;
using ERP_Pro.Domain.ERP.HumanResources.Entities;
using ERP_Pro.Domain.ERP.GuaranteesWarranties.Entities;
using ERP_Pro.Domain.ERP.SettingsParameters.Entities;
using ERP_Pro.Domain.ERP.TaxFees.Entities;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Entities
{
/// <summary>
/// Project Entity
/// </summary>
public class Project : Entity<ProjectId>
{

    private Project() { }

    public Project(ProjectId id, string projectNumber)
    {
        Id = id;
        ProjectNumber = projectNumber;
    }

    /// <summary>
    /// The unique identifier for the Project
    /// المعرف الفريد لـ Project
    /// </summary>
    public ProjectId Id { get; private set; }

    /// <summary>
    /// ProjectNumber of the Project
    /// ProjectNumber الخاص بـ Project
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ProjectCode of the Project
    /// ProjectCode الخاص بـ Project
    /// </summary>
    public string ProjectCode { get; private set; }

    /// <summary>
    /// ProjectNameArabic of the Project
    /// ProjectNameArabic الخاص بـ Project
    /// </summary>
    public string ProjectNameArabic { get; private set; }

    /// <summary>
    /// ProjectNameEnglish of the Project
    /// ProjectNameEnglish الخاص بـ Project
    /// </summary>
    public string ProjectNameEnglish { get; private set; }

    /// <summary>
    /// ProjectParent of the Project
    /// ProjectParent الخاص بـ Project
    /// </summary>
    public string ProjectParent { get; private set; }

    /// <summary>
    /// ProjectLevel of the Project
    /// ProjectLevel الخاص بـ Project
    /// </summary>
    public decimal? ProjectLevel { get; private set; }

    /// <summary>
    /// ProjectSub of the Project
    /// ProjectSub الخاص بـ Project
    /// </summary>
    public decimal? ProjectSub { get; private set; }

    /// <summary>
    /// InactiveFlag of the Project
    /// InactiveFlag الخاص بـ Project
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the Project
    /// InactivatedByUserId الخاص بـ Project
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the Project
    /// InactiveDate الخاص بـ Project
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the Project
    /// InactiveReason الخاص بـ Project
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// ImportExcelFlag of the Project
    /// ImportExcelFlag الخاص بـ Project
    /// </summary>
    public decimal? ImportExcelFlag { get; private set; }

    /// <summary>
    /// StartDate of the Project
    /// StartDate الخاص بـ Project
    /// </summary>
    public DateTime? StartDate { get; private set; }

    /// <summary>
    /// EndDate of the Project
    /// EndDate الخاص بـ Project
    /// </summary>
    public DateTime? EndDate { get; private set; }

    /// <summary>
    /// Address of the Project
    /// Address الخاص بـ Project
    /// </summary>
    public string Address { get; private set; }

    /// <summary>
    /// ProjectAdmin of the Project
    /// ProjectAdmin الخاص بـ Project
    /// </summary>
    public string ProjectAdmin { get; private set; }

    /// <summary>
    /// ProjectDescription of the Project
    /// ProjectDescription الخاص بـ Project
    /// </summary>
    public string ProjectDescription { get; private set; }

    /// <summary>
    /// ProjectNotes of the Project
    /// ProjectNotes الخاص بـ Project
    /// </summary>
    public string ProjectNotes { get; private set; }

    /// <summary>
    /// CurCode of the Project
    /// CurCode الخاص بـ Project
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// ProjectCost of the Project
    /// ProjectCost الخاص بـ Project
    /// </summary>
    public decimal? ProjectCost { get; private set; }

    /// <summary>
    /// ExchangeRate of the Project
    /// ExchangeRate الخاص بـ Project
    /// </summary>
    public decimal? ExchangeRate { get; private set; }

    /// <summary>
    /// CountryNumber of the Project
    /// CountryNumber الخاص بـ Project
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// CityNumber of the Project
    /// CityNumber الخاص بـ Project
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// ProvinceNumber of the Project
    /// ProvinceNumber الخاص بـ Project
    /// </summary>
    public decimal? ProvinceNumber { get; private set; }

    /// <summary>
    /// RegionCode of the Project
    /// RegionCode الخاص بـ Project
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// BidDate of the Project
    /// BidDate الخاص بـ Project
    /// </summary>
    public DateTime? BidDate { get; private set; }

    /// <summary>
    /// ContractSpecialDate of the Project
    /// ContractSpecialDate الخاص بـ Project
    /// </summary>
    public DateTime? ContractSpecialDate { get; private set; }

    /// <summary>
    /// CCode of the Project
    /// CCode الخاص بـ Project
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CodeNumberProjectManager of the Project
    /// CodeNumberProjectManager الخاص بـ Project
    /// </summary>
    public decimal? CodeNumberProjectManager { get; private set; }

    /// <summary>
    /// CodeTypeShort of the Project
    /// CodeTypeShort الخاص بـ Project
    /// </summary>
    public decimal? CodeTypeShort { get; private set; }

    /// <summary>
    /// CodeNumberProjectGroupSpecial of the Project
    /// CodeNumberProjectGroupSpecial الخاص بـ Project
    /// </summary>
    public decimal? CodeNumberProjectGroupSpecial { get; private set; }

    /// <summary>
    /// CodeNumberProjectSpecial of the Project
    /// CodeNumberProjectSpecial الخاص بـ Project
    /// </summary>
    public decimal? CodeNumberProjectSpecial { get; private set; }

    /// <summary>
    /// ProjectStatus of the Project
    /// ProjectStatus الخاص بـ Project
    /// </summary>
    public decimal? ProjectStatus { get; private set; }

    /// <summary>
    /// PmsConditionNumber of the Project
    /// PmsConditionNumber الخاص بـ Project
    /// </summary>
    public decimal? PmsConditionNumber { get; private set; }

    /// <summary>
    /// Field1 of the Project
    /// Field1 الخاص بـ Project
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the Project
    /// Field2 الخاص بـ Project
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the Project
    /// Field3 الخاص بـ Project
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the Project
    /// Field4 الخاص بـ Project
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the Project
    /// Field5 الخاص بـ Project
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the Project
    /// Field6 الخاص بـ Project
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the Project
    /// Field7 الخاص بـ Project
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the Project
    /// Field8 الخاص بـ Project
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the Project
    /// Field9 الخاص بـ Project
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the Project
    /// Field10 الخاص بـ Project
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// Field21 of the Project
    /// Field21 الخاص بـ Project
    /// </summary>
    public DateTime? Field21 { get; private set; }

    /// <summary>
    /// Field22 of the Project
    /// Field22 الخاص بـ Project
    /// </summary>
    public DateTime? Field22 { get; private set; }

    /// <summary>
    /// Field23 of the Project
    /// Field23 الخاص بـ Project
    /// </summary>
    public DateTime? Field23 { get; private set; }

    /// <summary>
    /// Field24 of the Project
    /// Field24 الخاص بـ Project
    /// </summary>
    public DateTime? Field24 { get; private set; }

    /// <summary>
    /// Field25 of the Project
    /// Field25 الخاص بـ Project
    /// </summary>
    public DateTime? Field25 { get; private set; }

    /// <summary>
    /// Field26 of the Project
    /// Field26 الخاص بـ Project
    /// </summary>
    public DateTime? Field26 { get; private set; }

    /// <summary>
    /// Field27 of the Project
    /// Field27 الخاص بـ Project
    /// </summary>
    public DateTime? Field27 { get; private set; }

    /// <summary>
    /// Field28 of the Project
    /// Field28 الخاص بـ Project
    /// </summary>
    public DateTime? Field28 { get; private set; }

    /// <summary>
    /// Field29 of the Project
    /// Field29 الخاص بـ Project
    /// </summary>
    public DateTime? Field29 { get; private set; }

    /// <summary>
    /// Field30 of the Project
    /// Field30 الخاص بـ Project
    /// </summary>
    public DateTime? Field30 { get; private set; }

    /// <summary>
    /// Field31 of the Project
    /// Field31 الخاص بـ Project
    /// </summary>
    public decimal? Field31 { get; private set; }

    /// <summary>
    /// Field32 of the Project
    /// Field32 الخاص بـ Project
    /// </summary>
    public decimal? Field32 { get; private set; }

    /// <summary>
    /// Field33 of the Project
    /// Field33 الخاص بـ Project
    /// </summary>
    public decimal? Field33 { get; private set; }

    /// <summary>
    /// Field34 of the Project
    /// Field34 الخاص بـ Project
    /// </summary>
    public decimal? Field34 { get; private set; }

    /// <summary>
    /// Field35 of the Project
    /// Field35 الخاص بـ Project
    /// </summary>
    public decimal? Field35 { get; private set; }

    /// <summary>
    /// Field36 of the Project
    /// Field36 الخاص بـ Project
    /// </summary>
    public decimal? Field36 { get; private set; }

    /// <summary>
    /// Field37 of the Project
    /// Field37 الخاص بـ Project
    /// </summary>
    public decimal? Field37 { get; private set; }

    /// <summary>
    /// Field38 of the Project
    /// Field38 الخاص بـ Project
    /// </summary>
    public decimal? Field38 { get; private set; }

    /// <summary>
    /// Field39 of the Project
    /// Field39 الخاص بـ Project
    /// </summary>
    public decimal? Field39 { get; private set; }

    /// <summary>
    /// Field40 of the Project
    /// Field40 الخاص بـ Project
    /// </summary>
    public decimal? Field40 { get; private set; }

    /// <summary>
    /// UseActive of the Project
    /// UseActive الخاص بـ Project
    /// </summary>
    public decimal? UseActive { get; private set; }

    /// <summary>
    /// AccountsCostFlag of the Project
    /// AccountsCostFlag الخاص بـ Project
    /// </summary>
    public decimal? AccountsCostFlag { get; private set; }

    /// <summary>
    /// MaxExecutionPercent of the Project
    /// MaxExecutionPercent الخاص بـ Project
    /// </summary>
    public decimal? MaxExecutionPercent { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ProjectGroup ProjectGroup { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
