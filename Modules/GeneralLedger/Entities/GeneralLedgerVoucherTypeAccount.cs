using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerVoucherTypeAccount Entity
/// </summary>
public class GeneralLedgerVoucherTypeAccount : Entity<GeneralLedgerVoucherTypeAccountId>
{
    private GeneralLedgerVoucherTypeAccount() { }

    /// <summary>
    /// The unique identifier for the GeneralLedgerVoucherTypeAccount
    /// المعرف الفريد لـ GeneralLedgerVoucherTypeAccount
    /// </summary>
    public GeneralLedgerVoucherTypeAccountId Id { get; private set; }

    /// <summary>
    /// VendorType of the GeneralLedgerVoucherTypeAccount
    /// VendorType الخاص بـ GeneralLedgerVoucherTypeAccount
    /// </summary>
    public decimal? VendorType { get; private set; }

    /// <summary>
    /// VendorTypeNumber of the GeneralLedgerVoucherTypeAccount
    /// VendorTypeNumber الخاص بـ GeneralLedgerVoucherTypeAccount
    /// </summary>
    public decimal? VendorTypeNumber { get; private set; }

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
    /// ManyToOne relationship to VoucherType
    /// </summary>
    public VoucherType VoucherType { get; private set; }
    #endregion
}
}
