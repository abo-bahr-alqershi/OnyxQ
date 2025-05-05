using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// PeriodCurrencyDifference Entity
/// </summary>
public class PeriodCurrencyDifference : Entity<PeriodCurrencyDifferenceId>
{

    private PeriodCurrencyDifference() { }

    public PeriodCurrencyDifference(PeriodCurrencyDifferenceId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PeriodCurrencyDifference
    /// المعرف الفريد لـ PeriodCurrencyDifference
    /// </summary>
    public PeriodCurrencyDifferenceId Id { get; private set; }

    /// <summary>
    /// PeriodNumberShort of the PeriodCurrencyDifference
    /// PeriodNumberShort الخاص بـ PeriodCurrencyDifference
    /// </summary>
    public decimal? PeriodNumberShort { get; private set; }

    /// <summary>
    /// DocDate of the PeriodCurrencyDifference
    /// DocDate الخاص بـ PeriodCurrencyDifference
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AccountCode of the PeriodCurrencyDifference
    /// AccountCode الخاص بـ PeriodCurrencyDifference
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the PeriodCurrencyDifference
    /// AccountDetailType الخاص بـ PeriodCurrencyDifference
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountDetailCode of the PeriodCurrencyDifference
    /// AccountDetailCode الخاص بـ PeriodCurrencyDifference
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// CCode of the PeriodCurrencyDifference
    /// CCode الخاص بـ PeriodCurrencyDifference
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// VendorCode of the PeriodCurrencyDifference
    /// VendorCode الخاص بـ PeriodCurrencyDifference
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// CashNumber of the PeriodCurrencyDifference
    /// CashNumber الخاص بـ PeriodCurrencyDifference
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the PeriodCurrencyDifference
    /// CostCenterCode الخاص بـ PeriodCurrencyDifference
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the PeriodCurrencyDifference
    /// ProjectNumber الخاص بـ PeriodCurrencyDifference
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the PeriodCurrencyDifference
    /// ActivityNumber الخاص بـ PeriodCurrencyDifference
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// LetterCreditNumber of the PeriodCurrencyDifference
    /// LetterCreditNumber الخاص بـ PeriodCurrencyDifference
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// CurCode of the PeriodCurrencyDifference
    /// CurCode الخاص بـ PeriodCurrencyDifference
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// CurBal of the PeriodCurrencyDifference
    /// CurBal الخاص بـ PeriodCurrencyDifference
    /// </summary>
    public decimal? CurBal { get; private set; }

    /// <summary>
    /// CurBalF of the PeriodCurrencyDifference
    /// CurBalF الخاص بـ PeriodCurrencyDifference
    /// </summary>
    public decimal? CurBalF { get; private set; }

    /// <summary>
    /// CurBalAftr of the PeriodCurrencyDifference
    /// CurBalAftr الخاص بـ PeriodCurrencyDifference
    /// </summary>
    public decimal? CurBalAftr { get; private set; }

    /// <summary>
    /// CurBalDiff of the PeriodCurrencyDifference
    /// CurBalDiff الخاص بـ PeriodCurrencyDifference
    /// </summary>
    public decimal? CurBalDiff { get; private set; }

    /// <summary>
    /// ExchangeRate of the PeriodCurrencyDifference
    /// ExchangeRate الخاص بـ PeriodCurrencyDifference
    /// </summary>
    public decimal? ExchangeRate { get; private set; }

    /// <summary>
    /// CurRate of the PeriodCurrencyDifference
    /// CurRate الخاص بـ PeriodCurrencyDifference
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PeriodCurrencyDifference
    /// CompanyNumberShort الخاص بـ PeriodCurrencyDifference
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PeriodCurrencyDifference
    /// BranchNumber الخاص بـ PeriodCurrencyDifference
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PeriodCurrencyDifference
    /// BranchYear الخاص بـ PeriodCurrencyDifference
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the PeriodCurrencyDifference
    /// BranchUser الخاص بـ PeriodCurrencyDifference
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

