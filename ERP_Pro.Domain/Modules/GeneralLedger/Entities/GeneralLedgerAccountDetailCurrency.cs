using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerAccountDetailCurrency Entity
/// </summary>
public class GeneralLedgerAccountDetailCurrency : Entity<GeneralLedgerAccountDetailCurrencyId>
{

    private GeneralLedgerAccountDetailCurrency() { }

    public GeneralLedgerAccountDetailCurrency(GeneralLedgerAccountDetailCurrencyId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the GeneralLedgerAccountDetailCurrency
    /// المعرف الفريد لـ GeneralLedgerAccountDetailCurrency
    /// </summary>
    public GeneralLedgerAccountDetailCurrencyId Id { get; private set; }

    /// <summary>
    /// InactiveFlagAlt of the GeneralLedgerAccountDetailCurrency
    /// InactiveFlagAlt الخاص بـ GeneralLedgerAccountDetailCurrency
    /// </summary>
    public decimal? InactiveFlagAlt { get; private set; }

    /// <summary>
    /// InactiveReasonAlt of the GeneralLedgerAccountDetailCurrency
    /// InactiveReasonAlt الخاص بـ GeneralLedgerAccountDetailCurrency
    /// </summary>
    public string InactiveReasonAlt { get; private set; }

    /// <summary>
    /// InactiveDateAlt of the GeneralLedgerAccountDetailCurrency
    /// InactiveDateAlt الخاص بـ GeneralLedgerAccountDetailCurrency
    /// </summary>
    public DateTime? InactiveDateAlt { get; private set; }

    /// <summary>
    /// InactiveUserId of the GeneralLedgerAccountDetailCurrency
    /// InactiveUserId الخاص بـ GeneralLedgerAccountDetailCurrency
    /// </summary>
    public decimal? InactiveUserId { get; private set; }

    /// <summary>
    /// UsedFlag of the GeneralLedgerAccountDetailCurrency
    /// UsedFlag الخاص بـ GeneralLedgerAccountDetailCurrency
    /// </summary>
    public decimal? UsedFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ExchangeRate ExchangeRate { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public GeneralLedgerAccountDetail GeneralLedgerAccountDetail { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
