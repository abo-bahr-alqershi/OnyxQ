using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// DebtorCustomerDetail Entity
/// </summary>
public class DebtorCustomerDetail : Entity<DebtorCustomerDetailId>
{

    private DebtorCustomerDetail() { }

    public DebtorCustomerDetail(DebtorCustomerDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the DebtorCustomerDetail
    /// المعرف الفريد لـ DebtorCustomerDetail
    /// </summary>
    public DebtorCustomerDetailId Id { get; private set; }

    /// <summary>
    /// DrNo of the DebtorCustomerDetail
    /// DrNo الخاص بـ DebtorCustomerDetail
    /// </summary>
    public decimal? DrNo { get; private set; }

    /// <summary>
    /// CCode of the DebtorCustomerDetail
    /// CCode الخاص بـ DebtorCustomerDetail
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the DebtorCustomerDetail
    /// CostCenterCode الخاص بـ DebtorCustomerDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// DocSer of the DebtorCustomerDetail
    /// DocSer الخاص بـ DebtorCustomerDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocNo of the DebtorCustomerDetail
    /// DocNo الخاص بـ DebtorCustomerDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocType of the DebtorCustomerDetail
    /// DocType الخاص بـ DebtorCustomerDetail
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// DocDate of the DebtorCustomerDetail
    /// DocDate الخاص بـ DebtorCustomerDetail
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AccountCurrency of the DebtorCustomerDetail
    /// AccountCurrency الخاص بـ DebtorCustomerDetail
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// DocAmt of the DebtorCustomerDetail
    /// DocAmt الخاص بـ DebtorCustomerDetail
    /// </summary>
    public decimal? DocAmt { get; private set; }

    /// <summary>
    /// LocalAmount of the DebtorCustomerDetail
    /// LocalAmount الخاص بـ DebtorCustomerDetail
    /// </summary>
    public decimal? LocalAmount { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the DebtorCustomerDetail
    /// CompanyNumberShort الخاص بـ DebtorCustomerDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the DebtorCustomerDetail
    /// BranchNumber الخاص بـ DebtorCustomerDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the DebtorCustomerDetail
    /// BranchYear الخاص بـ DebtorCustomerDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the DebtorCustomerDetail
    /// BranchUser الخاص بـ DebtorCustomerDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ItemNumber of the DebtorCustomerDetail
    /// ItemNumber الخاص بـ DebtorCustomerDetail
    /// </summary>
    public decimal? ItemNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public DebtorCustomerMaster DebtorCustomerMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

