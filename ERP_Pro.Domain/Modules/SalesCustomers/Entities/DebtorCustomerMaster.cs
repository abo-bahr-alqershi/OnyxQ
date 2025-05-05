using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// DebtorCustomerMaster Entity
/// </summary>
public class DebtorCustomerMaster : AggregateRoot<DebtorCustomerMasterId>
{

    private DebtorCustomerMaster() { }

    public DebtorCustomerMaster(DebtorCustomerMasterId id, decimal? drSer)
    {
        Id = id;
        DrSer = drSer;
    }

    /// <summary>
    /// The unique identifier for the DebtorCustomerMaster
    /// المعرف الفريد لـ DebtorCustomerMaster
    /// </summary>
    public DebtorCustomerMasterId Id { get; private set; }

    /// <summary>
    /// DrNo of the DebtorCustomerMaster
    /// DrNo الخاص بـ DebtorCustomerMaster
    /// </summary>
    public decimal? DrNo { get; private set; }

    /// <summary>
    /// DrSer of the DebtorCustomerMaster
    /// DrSer الخاص بـ DebtorCustomerMaster
    /// </summary>
    public decimal? DrSer { get; private set; }

    /// <summary>
    /// DrDate of the DebtorCustomerMaster
    /// DrDate الخاص بـ DebtorCustomerMaster
    /// </summary>
    public DateTime? DrDate { get; private set; }

    /// <summary>
    /// CCode of the DebtorCustomerMaster
    /// CCode الخاص بـ DebtorCustomerMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the DebtorCustomerMaster
    /// CostCenterCode الخاص بـ DebtorCustomerMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the DebtorCustomerMaster
    /// AccountCurrency الخاص بـ DebtorCustomerMaster
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// FDate of the DebtorCustomerMaster
    /// FDate الخاص بـ DebtorCustomerMaster
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the DebtorCustomerMaster
    /// TDate الخاص بـ DebtorCustomerMaster
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the DebtorCustomerMaster
    /// CompanyNumberShort الخاص بـ DebtorCustomerMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the DebtorCustomerMaster
    /// BranchNumber الخاص بـ DebtorCustomerMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the DebtorCustomerMaster
    /// BranchYear الخاص بـ DebtorCustomerMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the DebtorCustomerMaster
    /// BranchUser الخاص بـ DebtorCustomerMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

