using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// CashManagementMaster Entity
/// </summary>
public class CashManagementMaster : Entity<CashManagementMasterId>
{

    private CashManagementMaster() { }

    public CashManagementMaster(CashManagementMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the CashManagementMaster
    /// المعرف الفريد لـ CashManagementMaster
    /// </summary>
    public CashManagementMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the CashManagementMaster
    /// DocNo الخاص بـ CashManagementMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the CashManagementMaster
    /// DocSer الخاص بـ CashManagementMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the CashManagementMaster
    /// DocDate الخاص بـ CashManagementMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocDesc of the CashManagementMaster
    /// DocDesc الخاص بـ CashManagementMaster
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// CashBalanceLocation of the CashManagementMaster
    /// CashBalanceLocation الخاص بـ CashManagementMaster
    /// </summary>
    public decimal? CashBalanceLocation { get; private set; }

    /// <summary>
    /// DiffAmtLoc of the CashManagementMaster
    /// DiffAmtLoc الخاص بـ CashManagementMaster
    /// </summary>
    public decimal? DiffAmtLoc { get; private set; }

    /// <summary>
    /// Person1 of the CashManagementMaster
    /// Person1 الخاص بـ CashManagementMaster
    /// </summary>
    public string Person1 { get; private set; }

    /// <summary>
    /// Person2 of the CashManagementMaster
    /// Person2 الخاص بـ CashManagementMaster
    /// </summary>
    public string Person2 { get; private set; }

    /// <summary>
    /// Person3 of the CashManagementMaster
    /// Person3 الخاص بـ CashManagementMaster
    /// </summary>
    public string Person3 { get; private set; }

    /// <summary>
    /// Person4 of the CashManagementMaster
    /// Person4 الخاص بـ CashManagementMaster
    /// </summary>
    public string Person4 { get; private set; }

    /// <summary>
    /// Person5 of the CashManagementMaster
    /// Person5 الخاص بـ CashManagementMaster
    /// </summary>
    public string Person5 { get; private set; }

    /// <summary>
    /// Person6 of the CashManagementMaster
    /// Person6 الخاص بـ CashManagementMaster
    /// </summary>
    public string Person6 { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CashManagementMaster
    /// CompanyNumberShort الخاص بـ CashManagementMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CashManagementMaster
    /// BranchNumber الخاص بـ CashManagementMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CashManagementMaster
    /// BranchYear الخاص بـ CashManagementMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CashManagementMaster
    /// BranchUser الخاص بـ CashManagementMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public HandCash HandCash { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
