using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// EmployeeCommissionCalculationDetail Entity
/// </summary>
public class EmployeeCommissionCalculationDetail : Entity<EmployeeCommissionCalculationDetailId>
{
    private readonly List<ItemMaster> _itemMaster = new List<ItemMaster>();
    private readonly List<EmployeeCommissionCalculationMaster> _employeeCommissionCalculationMaster = new List<EmployeeCommissionCalculationMaster>();

    private EmployeeCommissionCalculationDetail() { }

    public EmployeeCommissionCalculationDetail(EmployeeCommissionCalculationDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the EmployeeCommissionCalculationDetail
    /// المعرف الفريد لـ EmployeeCommissionCalculationDetail
    /// </summary>
    public EmployeeCommissionCalculationDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the EmployeeCommissionCalculationDetail
    /// DocNo الخاص بـ EmployeeCommissionCalculationDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// EmpNo of the EmployeeCommissionCalculationDetail
    /// EmpNo الخاص بـ EmployeeCommissionCalculationDetail
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// ItemUnit of the EmployeeCommissionCalculationDetail
    /// ItemUnit الخاص بـ EmployeeCommissionCalculationDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the EmployeeCommissionCalculationDetail
    /// PSize الخاص بـ EmployeeCommissionCalculationDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// CommissionAmount of the EmployeeCommissionCalculationDetail
    /// CommissionAmount الخاص بـ EmployeeCommissionCalculationDetail
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// CommissionDescriptionShort of the EmployeeCommissionCalculationDetail
    /// CommissionDescriptionShort الخاص بـ EmployeeCommissionCalculationDetail
    /// </summary>
    public string CommissionDescriptionShort { get; private set; }

    /// <summary>
    /// CommissionPercent of the EmployeeCommissionCalculationDetail
    /// CommissionPercent الخاص بـ EmployeeCommissionCalculationDetail
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// NetSalesAmount of the EmployeeCommissionCalculationDetail
    /// NetSalesAmount الخاص بـ EmployeeCommissionCalculationDetail
    /// </summary>
    public decimal? NetSalesAmount { get; private set; }

    /// <summary>
    /// RecordNumber of the EmployeeCommissionCalculationDetail
    /// RecordNumber الخاص بـ EmployeeCommissionCalculationDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// GuarantorCode of the EmployeeCommissionCalculationDetail
    /// GuarantorCode الخاص بـ EmployeeCommissionCalculationDetail
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// ItemType of the EmployeeCommissionCalculationDetail
    /// ItemType الخاص بـ EmployeeCommissionCalculationDetail
    /// </summary>
    public decimal? ItemType { get; private set; }

    /// <summary>
    /// CGroupCode of the EmployeeCommissionCalculationDetail
    /// CGroupCode الخاص بـ EmployeeCommissionCalculationDetail
    /// </summary>
    public decimal? CGroupCode { get; private set; }

    /// <summary>
    /// CClass of the EmployeeCommissionCalculationDetail
    /// CClass الخاص بـ EmployeeCommissionCalculationDetail
    /// </summary>
    public decimal? CClass { get; private set; }

    /// <summary>
    /// BillDocumentType of the EmployeeCommissionCalculationDetail
    /// BillDocumentType الخاص بـ EmployeeCommissionCalculationDetail
    /// </summary>
    public decimal? BillDocumentType { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the EmployeeCommissionCalculationDetail
    /// CompanyNumberShort الخاص بـ EmployeeCommissionCalculationDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the EmployeeCommissionCalculationDetail
    /// BranchNumber الخاص بـ EmployeeCommissionCalculationDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the EmployeeCommissionCalculationDetail
    /// BranchYear الخاص بـ EmployeeCommissionCalculationDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the EmployeeCommissionCalculationDetail
    /// BranchUser الخاص بـ EmployeeCommissionCalculationDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemMaster> ItemMaster => _itemMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<EmployeeCommissionCalculationMaster> EmployeeCommissionCalculationMaster => _employeeCommissionCalculationMaster;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
