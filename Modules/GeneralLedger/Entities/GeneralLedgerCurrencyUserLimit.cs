using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerCurrencyUserLimit Entity
/// </summary>
public class GeneralLedgerCurrencyUserLimit : Entity<GeneralLedgerCurrencyUserLimitId>
{
    private GeneralLedgerCurrencyUserLimit() { }

    /// <summary>
    /// The unique identifier for the GeneralLedgerCurrencyUserLimit
    /// المعرف الفريد لـ GeneralLedgerCurrencyUserLimit
    /// </summary>
    public GeneralLedgerCurrencyUserLimitId Id { get; private set; }

    /// <summary>
    /// CurCode of the GeneralLedgerCurrencyUserLimit
    /// CurCode الخاص بـ GeneralLedgerCurrencyUserLimit
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// UserNumber of the GeneralLedgerCurrencyUserLimit
    /// UserNumber الخاص بـ GeneralLedgerCurrencyUserLimit
    /// </summary>
    public decimal? UserNumber { get; private set; }

    /// <summary>
    /// MaxCurrencyRate of the GeneralLedgerCurrencyUserLimit
    /// MaxCurrencyRate الخاص بـ GeneralLedgerCurrencyUserLimit
    /// </summary>
    public decimal? MaxCurrencyRate { get; private set; }

    /// <summary>
    /// MinCurrencyRate of the GeneralLedgerCurrencyUserLimit
    /// MinCurrencyRate الخاص بـ GeneralLedgerCurrencyUserLimit
    /// </summary>
    public decimal? MinCurrencyRate { get; private set; }

    /// <summary>
    /// CurRate of the GeneralLedgerCurrencyUserLimit
    /// CurRate الخاص بـ GeneralLedgerCurrencyUserLimit
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// MinPaymentRate of the GeneralLedgerCurrencyUserLimit
    /// MinPaymentRate الخاص بـ GeneralLedgerCurrencyUserLimit
    /// </summary>
    public decimal? MinPaymentRate { get; private set; }

    /// <summary>
    /// MaxPaymentRate of the GeneralLedgerCurrencyUserLimit
    /// MaxPaymentRate الخاص بـ GeneralLedgerCurrencyUserLimit
    /// </summary>
    public decimal? MaxPaymentRate { get; private set; }

    /// <summary>
    /// MinReceivedRate of the GeneralLedgerCurrencyUserLimit
    /// MinReceivedRate الخاص بـ GeneralLedgerCurrencyUserLimit
    /// </summary>
    public decimal? MinReceivedRate { get; private set; }

    /// <summary>
    /// MaxReceivedRate of the GeneralLedgerCurrencyUserLimit
    /// MaxReceivedRate الخاص بـ GeneralLedgerCurrencyUserLimit
    /// </summary>
    public decimal? MaxReceivedRate { get; private set; }

    /// <summary>
    /// ConnectionBranchNumber of the GeneralLedgerCurrencyUserLimit
    /// ConnectionBranchNumber الخاص بـ GeneralLedgerCurrencyUserLimit
    /// </summary>
    public decimal? ConnectionBranchNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ExchangeRate
    /// </summary>
    public ExchangeRate ExchangeRate { get; private set; }
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}
