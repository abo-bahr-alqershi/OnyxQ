using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesPlanDetail Entity
/// </summary>
public class SalesPlanDetail : Entity<SalesPlanDetailId>
{
    private readonly List<SalesPlanMaster> _salesPlanMaster = new List<SalesPlanMaster>();
    private readonly List<Region> _region = new List<Region>();
    private readonly List<Salesman> _salesman = new List<Salesman>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();
    private readonly List<Customer> _customer = new List<Customer>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();

    private SalesPlanDetail() { }

    public SalesPlanDetail(SalesPlanDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the SalesPlanDetail
    /// المعرف الفريد لـ SalesPlanDetail
    /// </summary>
    public SalesPlanDetailId Id { get; private set; }

    /// <summary>
    /// PlanNumber of the SalesPlanDetail
    /// PlanNumber الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? PlanNumber { get; private set; }

    /// <summary>
    /// PlanType of the SalesPlanDetail
    /// PlanType الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? PlanType { get; private set; }

    /// <summary>
    /// PlanDistributionType of the SalesPlanDetail
    /// PlanDistributionType الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? PlanDistributionType { get; private set; }

    /// <summary>
    /// PlanPeriodType of the SalesPlanDetail
    /// PlanPeriodType الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? PlanPeriodType { get; private set; }

    /// <summary>
    /// CGCode of the SalesPlanDetail
    /// CGCode الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? CGCode { get; private set; }

    /// <summary>
    /// CClass of the SalesPlanDetail
    /// CClass الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? CClass { get; private set; }

    /// <summary>
    /// CountryNumber of the SalesPlanDetail
    /// CountryNumber الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// ProvinceNumber of the SalesPlanDetail
    /// ProvinceNumber الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? ProvinceNumber { get; private set; }

    /// <summary>
    /// CityNumber of the SalesPlanDetail
    /// CityNumber الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the SalesPlanDetail
    /// ColumnNumberShort الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// GuarantorCode of the SalesPlanDetail
    /// GuarantorCode الخاص بـ SalesPlanDetail
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// ItemType of the SalesPlanDetail
    /// ItemType الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? ItemType { get; private set; }

    /// <summary>
    /// ItemCode of the SalesPlanDetail
    /// ItemCode الخاص بـ SalesPlanDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the SalesPlanDetail
    /// ItemUnit الخاص بـ SalesPlanDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the SalesPlanDetail
    /// PSize الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// Month of the SalesPlanDetail
    /// Month الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? Month { get; private set; }

    /// <summary>
    /// FDate of the SalesPlanDetail
    /// FDate الخاص بـ SalesPlanDetail
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the SalesPlanDetail
    /// TDate الخاص بـ SalesPlanDetail
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// ItemQuantity of the SalesPlanDetail
    /// ItemQuantity الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// LocalAmount of the SalesPlanDetail
    /// LocalAmount الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? LocalAmount { get; private set; }

    /// <summary>
    /// HighLimit of the SalesPlanDetail
    /// HighLimit الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? HighLimit { get; private set; }

    /// <summary>
    /// LowLimit of the SalesPlanDetail
    /// LowLimit الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? LowLimit { get; private set; }

    /// <summary>
    /// RecordNumber of the SalesPlanDetail
    /// RecordNumber الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// PlanDescription of the SalesPlanDetail
    /// PlanDescription الخاص بـ SalesPlanDetail
    /// </summary>
    public string PlanDescription { get; private set; }

    /// <summary>
    /// SalesAmountPaymentYear of the SalesPlanDetail
    /// SalesAmountPaymentYear الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? SalesAmountPaymentYear { get; private set; }

    /// <summary>
    /// AdditionalPercentagePerYear of the SalesPlanDetail
    /// AdditionalPercentagePerYear الخاص بـ SalesPlanDetail
    /// </summary>
    public string AdditionalPercentagePerYear { get; private set; }

    /// <summary>
    /// EmpNo of the SalesPlanDetail
    /// EmpNo الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// PromoterCode of the SalesPlanDetail
    /// PromoterCode الخاص بـ SalesPlanDetail
    /// </summary>
    public string PromoterCode { get; private set; }

    /// <summary>
    /// CClassTyp of the SalesPlanDetail
    /// CClassTyp الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? CClassTyp { get; private set; }

    /// <summary>
    /// GroupNumber of the SalesPlanDetail
    /// GroupNumber الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    /// <summary>
    /// BranchNumber of the SalesPlanDetail
    /// BranchNumber الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the SalesPlanDetail
    /// BranchYear الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the SalesPlanDetail
    /// CompanyNumberShort الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchUser of the SalesPlanDetail
    /// BranchUser الخاص بـ SalesPlanDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ManagerCode of the SalesPlanDetail
    /// ManagerCode الخاص بـ SalesPlanDetail
    /// </summary>
    public string ManagerCode { get; private set; }

    /// <summary>
    /// SubGroupCode of the SalesPlanDetail
    /// SubGroupCode الخاص بـ SalesPlanDetail
    /// </summary>
    public string SubGroupCode { get; private set; }

    /// <summary>
    /// AssistantNumber of the SalesPlanDetail
    /// AssistantNumber الخاص بـ SalesPlanDetail
    /// </summary>
    public string AssistantNumber { get; private set; }

    /// <summary>
    /// DetailNo of the SalesPlanDetail
    /// DetailNo الخاص بـ SalesPlanDetail
    /// </summary>
    public string DetailNo { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<SalesPlanMaster> SalesPlanMaster => _salesPlanMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Region> Region => _region;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Salesman> Salesman => _salesman;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CostCenter> CostCenter => _costCenter;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Customer> Customer => _customer;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Warehouse> Warehouse => _warehouse;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

