using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerTaxAccount Entity
/// </summary>
public class GeneralLedgerTaxAccount : Entity<GeneralLedgerTaxAccountId>
{
    private GeneralLedgerTaxAccount() { }

    /// <summary>
    /// The unique identifier for the GeneralLedgerTaxAccount
    /// المعرف الفريد لـ GeneralLedgerTaxAccount
    /// </summary>
    public GeneralLedgerTaxAccountId Id { get; private set; }

    /// <summary>
    /// AccountCode of the GeneralLedgerTaxAccount
    /// AccountCode الخاص بـ GeneralLedgerTaxAccount
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// TaxNumber of the GeneralLedgerTaxAccount
    /// TaxNumber الخاص بـ GeneralLedgerTaxAccount
    /// </summary>
    public decimal? TaxNumber { get; private set; }

    /// <summary>
    /// AgencyNumber of the GeneralLedgerTaxAccount
    /// AgencyNumber الخاص بـ GeneralLedgerTaxAccount
    /// </summary>
    public decimal? AgencyNumber { get; private set; }

    /// <summary>
    /// TaxPercent of the GeneralLedgerTaxAccount
    /// TaxPercent الخاص بـ GeneralLedgerTaxAccount
    /// </summary>
    public decimal? TaxPercent { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Account
    /// </summary>
    public Account Account { get; private set; }
    #endregion
}
}
