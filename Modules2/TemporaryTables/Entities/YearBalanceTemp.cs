using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;
namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// YearBalanceTemp Entity
/// </summary>
public class YearBalanceTemp : Entity<YearBalanceTempId>
{

    private YearBalanceTemp() { }

    public YearBalanceTemp(YearBalanceTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the YearBalanceTemp
    /// المعرف الفريد لـ YearBalanceTemp
    /// </summary>
    public YearBalanceTempId Id { get; private set; }

    /// <summary>
    /// CostCenterCode of the YearBalanceTemp
    /// CostCenterCode الخاص بـ YearBalanceTemp
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the YearBalanceTemp
    /// AccountCurrency الخاص بـ YearBalanceTemp
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountSmCode of the YearBalanceTemp
    /// AccountSmCode الخاص بـ YearBalanceTemp
    /// </summary>
    public decimal? AccountSmCode { get; private set; }

    /// <summary>
    /// OpeningBalance of the YearBalanceTemp
    /// OpeningBalance الخاص بـ YearBalanceTemp
    /// </summary>
    public decimal? OpeningBalance { get; private set; }

    /// <summary>
    /// OpeningYear of the YearBalanceTemp
    /// OpeningYear الخاص بـ YearBalanceTemp
    /// </summary>
    public decimal? OpeningYear { get; private set; }

    /// <summary>
    /// Balance of the YearBalanceTemp
    /// Balance الخاص بـ YearBalanceTemp
    /// </summary>
    public decimal? Balance { get; private set; }

    /// <summary>
    /// Year of the YearBalanceTemp
    /// Year الخاص بـ YearBalanceTemp
    /// </summary>
    public decimal? Year { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the YearBalanceTemp
    /// CompanyNumberShort الخاص بـ YearBalanceTemp
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the YearBalanceTemp
    /// BranchNumber الخاص بـ YearBalanceTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the YearBalanceTemp
    /// BranchYear الخاص بـ YearBalanceTemp
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the YearBalanceTemp
    /// BranchUser الخاص بـ YearBalanceTemp
    /// </summary>
    public decimal? BranchUser { get; private set; }

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

