using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesmanCalculateCommissionDetail Entity
/// </summary>
public class SalesmanCalculateCommissionDetail : Entity<SalesmanCalculateCommissionDetailId>
{
    private readonly List<ItemDetail> _itemDetail = new List<ItemDetail>();
    private readonly List<SalesmanCalculateCommissionMaster> _salesmanCalculateCommissionMaster = new List<SalesmanCalculateCommissionMaster>();

    private SalesmanCalculateCommissionDetail() { }

    public SalesmanCalculateCommissionDetail(SalesmanCalculateCommissionDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the SalesmanCalculateCommissionDetail
    /// المعرف الفريد لـ SalesmanCalculateCommissionDetail
    /// </summary>
    public SalesmanCalculateCommissionDetailId Id { get; private set; }

    /// <summary>
    /// CommissionNumber of the SalesmanCalculateCommissionDetail
    /// CommissionNumber الخاص بـ SalesmanCalculateCommissionDetail
    /// </summary>
    public decimal? CommissionNumber { get; private set; }

    /// <summary>
    /// RepCode of the SalesmanCalculateCommissionDetail
    /// RepCode الخاص بـ SalesmanCalculateCommissionDetail
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// PSize of the SalesmanCalculateCommissionDetail
    /// PSize الخاص بـ SalesmanCalculateCommissionDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// CommissionPercent of the SalesmanCalculateCommissionDetail
    /// CommissionPercent الخاص بـ SalesmanCalculateCommissionDetail
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// DueAmt of the SalesmanCalculateCommissionDetail
    /// DueAmt الخاص بـ SalesmanCalculateCommissionDetail
    /// </summary>
    public decimal? DueAmt { get; private set; }

    /// <summary>
    /// CommissionDescription of the SalesmanCalculateCommissionDetail
    /// CommissionDescription الخاص بـ SalesmanCalculateCommissionDetail
    /// </summary>
    public string CommissionDescription { get; private set; }

    /// <summary>
    /// CommissionAmount of the SalesmanCalculateCommissionDetail
    /// CommissionAmount الخاص بـ SalesmanCalculateCommissionDetail
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// SalesAmount of the SalesmanCalculateCommissionDetail
    /// SalesAmount الخاص بـ SalesmanCalculateCommissionDetail
    /// </summary>
    public decimal? SalesAmount { get; private set; }

    /// <summary>
    /// CommissionType of the SalesmanCalculateCommissionDetail
    /// CommissionType الخاص بـ SalesmanCalculateCommissionDetail
    /// </summary>
    public decimal? CommissionType { get; private set; }

    /// <summary>
    /// DstrCommEmpType of the SalesmanCalculateCommissionDetail
    /// DstrCommEmpType الخاص بـ SalesmanCalculateCommissionDetail
    /// </summary>
    public decimal? DstrCommEmpType { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the SalesmanCalculateCommissionDetail
    /// CompanyNumberShort الخاص بـ SalesmanCalculateCommissionDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the SalesmanCalculateCommissionDetail
    /// BranchNumber الخاص بـ SalesmanCalculateCommissionDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the SalesmanCalculateCommissionDetail
    /// BranchYear الخاص بـ SalesmanCalculateCommissionDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the SalesmanCalculateCommissionDetail
    /// BranchUser الخاص بـ SalesmanCalculateCommissionDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemDetail> ItemDetail => _itemDetail;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<SalesmanCalculateCommissionMaster> SalesmanCalculateCommissionMaster => _salesmanCalculateCommissionMaster;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

