using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// AdjustInstallmentAccountsPayableMaster Entity
/// </summary>
public class AdjustInstallmentAccountsPayableMaster : Entity<AdjustInstallmentAccountsPayableMasterId>
{

    private AdjustInstallmentAccountsPayableMaster() { }

    public AdjustInstallmentAccountsPayableMaster(AdjustInstallmentAccountsPayableMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the AdjustInstallmentAccountsPayableMaster
    /// المعرف الفريد لـ AdjustInstallmentAccountsPayableMaster
    /// </summary>
    public AdjustInstallmentAccountsPayableMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the AdjustInstallmentAccountsPayableMaster
    /// DocNo الخاص بـ AdjustInstallmentAccountsPayableMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the AdjustInstallmentAccountsPayableMaster
    /// DocSer الخاص بـ AdjustInstallmentAccountsPayableMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the AdjustInstallmentAccountsPayableMaster
    /// DocDate الخاص بـ AdjustInstallmentAccountsPayableMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocTypeRef of the AdjustInstallmentAccountsPayableMaster
    /// DocTypeRef الخاص بـ AdjustInstallmentAccountsPayableMaster
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the AdjustInstallmentAccountsPayableMaster
    /// DocNoRef الخاص بـ AdjustInstallmentAccountsPayableMaster
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the AdjustInstallmentAccountsPayableMaster
    /// DocSerRef الخاص بـ AdjustInstallmentAccountsPayableMaster
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocDateRef of the AdjustInstallmentAccountsPayableMaster
    /// DocDateRef الخاص بـ AdjustInstallmentAccountsPayableMaster
    /// </summary>
    public DateTime? DocDateRef { get; private set; }

    /// <summary>
    /// ProjectNumber of the AdjustInstallmentAccountsPayableMaster
    /// ProjectNumber الخاص بـ AdjustInstallmentAccountsPayableMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// AccountCurrency of the AdjustInstallmentAccountsPayableMaster
    /// AccountCurrency الخاص بـ AdjustInstallmentAccountsPayableMaster
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// DocAmtRef of the AdjustInstallmentAccountsPayableMaster
    /// DocAmtRef الخاص بـ AdjustInstallmentAccountsPayableMaster
    /// </summary>
    public decimal? DocAmtRef { get; private set; }

    /// <summary>
    /// DocDesc of the AdjustInstallmentAccountsPayableMaster
    /// DocDesc الخاص بـ AdjustInstallmentAccountsPayableMaster
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the AdjustInstallmentAccountsPayableMaster
    /// ReferenceNumber الخاص بـ AdjustInstallmentAccountsPayableMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AdjustInstallmentAccountsPayableMaster
    /// CompanyNumberShort الخاص بـ AdjustInstallmentAccountsPayableMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AdjustInstallmentAccountsPayableMaster
    /// BranchNumber الخاص بـ AdjustInstallmentAccountsPayableMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AdjustInstallmentAccountsPayableMaster
    /// BranchYear الخاص بـ AdjustInstallmentAccountsPayableMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AdjustInstallmentAccountsPayableMaster
    /// BranchUser الخاص بـ AdjustInstallmentAccountsPayableMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public VoucherDetails VoucherDetails { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

