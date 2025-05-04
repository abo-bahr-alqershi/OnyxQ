using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// CurrencyDifferenceTemp Entity
/// </summary>
public class CurrencyDifferenceTemp : Entity<CurrencyDifferenceTempId>
{
    private CurrencyDifferenceTemp() { }

    /// <summary>
    /// The unique identifier for the CurrencyDifferenceTemp
    /// المعرف الفريد لـ CurrencyDifferenceTemp
    /// </summary>
    public CurrencyDifferenceTempId Id { get; private set; }

    /// <summary>
    /// AccountCode of the CurrencyDifferenceTemp
    /// AccountCode الخاص بـ CurrencyDifferenceTemp
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CurrencyDifferenceTemp
    /// CompanyNumberShort الخاص بـ CurrencyDifferenceTemp
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CurrencyDifferenceTemp
    /// BranchNumber الخاص بـ CurrencyDifferenceTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CurrencyDifferenceTemp
    /// BranchYear الخاص بـ CurrencyDifferenceTemp
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CurrencyDifferenceTemp
    /// BranchUser الخاص بـ CurrencyDifferenceTemp
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Account
    /// </summary>
    public Account Account { get; private set; }
    #endregion
}
}
