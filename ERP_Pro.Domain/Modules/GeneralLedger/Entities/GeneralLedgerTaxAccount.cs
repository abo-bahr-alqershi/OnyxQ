using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;
namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerTaxAccount Entity
/// </summary>
public class GeneralLedgerTaxAccount : Entity<GeneralLedgerTaxAccountId>
{

    private GeneralLedgerTaxAccount() { }

    public GeneralLedgerTaxAccount(GeneralLedgerTaxAccountId id, decimal? taxNumber, decimal? agencyNumber)
    {
        Id = id;
        TaxNumber = taxNumber;
        AgencyNumber = agencyNumber;
    }

    /// <summary>
    /// The unique identifier for the GeneralLedgerTaxAccount
    /// المعرف الفريد لـ GeneralLedgerTaxAccount
    /// </summary>
    public GeneralLedgerTaxAccountId Id { get; private set; }

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
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account Account { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

