using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;
namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerVoucherTypeAccount Entity
/// </summary>
public class GeneralLedgerVoucherTypeAccount : Entity<GeneralLedgerVoucherTypeAccountId>
{

    private GeneralLedgerVoucherTypeAccount() { }

    public GeneralLedgerVoucherTypeAccount(GeneralLedgerVoucherTypeAccountId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the GeneralLedgerVoucherTypeAccount
    /// المعرف الفريد لـ GeneralLedgerVoucherTypeAccount
    /// </summary>
    public GeneralLedgerVoucherTypeAccountId Id { get; private set; }

    /// <summary>
    /// AccountCode of the GeneralLedgerVoucherTypeAccount
    /// AccountCode الخاص بـ GeneralLedgerVoucherTypeAccount
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the GeneralLedgerVoucherTypeAccount
    /// AccountDetailCode الخاص بـ GeneralLedgerVoucherTypeAccount
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the GeneralLedgerVoucherTypeAccount
    /// AccountDetailType الخاص بـ GeneralLedgerVoucherTypeAccount
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public VoucherType VoucherType { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

