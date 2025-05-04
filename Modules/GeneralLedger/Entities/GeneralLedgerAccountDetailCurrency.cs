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

    /// <summary>
    /// The unique identifier for the GeneralLedgerAccountDetailCurrency
    /// المعرف الفريد لـ GeneralLedgerAccountDetailCurrency
    /// </summary>
    public GeneralLedgerAccountDetailCurrencyId Id { get; private set; }

    /// <summary>
    /// AccountDetailCode of the GeneralLedgerAccountDetailCurrency
    /// AccountDetailCode الخاص بـ GeneralLedgerAccountDetailCurrency
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the GeneralLedgerAccountDetailCurrency
    /// AccountDetailType الخاص بـ GeneralLedgerAccountDetailCurrency
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// CurCode of the GeneralLedgerAccountDetailCurrency
    /// CurCode الخاص بـ GeneralLedgerAccountDetailCurrency
    /// </summary>
    public string CurCode { get; private set; }

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
    /// ManyToOne relationship to ExchangeRate
    /// </summary>
    public ExchangeRate ExchangeRate { get; private set; }
    /// <summary>
    /// ManyToOne relationship to GeneralLedgerAccountDetail
    /// </summary>
    public GeneralLedgerAccountDetail GeneralLedgerAccountDetail { get; private set; }
    /// <summary>
    /// One-to-many relationship: GeneralLedgerAccountDetailCurrency to GeneralLedgerAccountDetailPrivilege
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerAccountDetailPrivilege> GeneralLedgerAccountDetailPrivileges { get; private set; }
    /// <summary>
    /// One-to-many relationship: GeneralLedgerAccountDetailCurrency to User
    /// </summary>
    public IReadOnlyCollection<User> Users { get; private set; }
    #endregion
}
}
