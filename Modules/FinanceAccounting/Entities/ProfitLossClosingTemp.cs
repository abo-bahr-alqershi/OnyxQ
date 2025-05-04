using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// ProfitLossClosingTemp Entity
/// </summary>
public class ProfitLossClosingTemp : Entity<ProfitLossClosingTempId>
{
    private ProfitLossClosingTemp() { }

    /// <summary>
    /// The unique identifier for the ProfitLossClosingTemp
    /// المعرف الفريد لـ ProfitLossClosingTemp
    /// </summary>
    public ProfitLossClosingTempId Id { get; private set; }

    /// <summary>
    /// AccountCode of the ProfitLossClosingTemp
    /// AccountCode الخاص بـ ProfitLossClosingTemp
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the ProfitLossClosingTemp
    /// AccountCurrency الخاص بـ ProfitLossClosingTemp
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountDetailCode of the ProfitLossClosingTemp
    /// AccountDetailCode الخاص بـ ProfitLossClosingTemp
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the ProfitLossClosingTemp
    /// AccountDetailType الخاص بـ ProfitLossClosingTemp
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// CostCenterCode of the ProfitLossClosingTemp
    /// CostCenterCode الخاص بـ ProfitLossClosingTemp
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the ProfitLossClosingTemp
    /// ProjectNumber الخاص بـ ProfitLossClosingTemp
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the ProfitLossClosingTemp
    /// ActivityNumber الخاص بـ ProfitLossClosingTemp
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// CCode of the ProfitLossClosingTemp
    /// CCode الخاص بـ ProfitLossClosingTemp
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// VendorCode of the ProfitLossClosingTemp
    /// VendorCode الخاص بـ ProfitLossClosingTemp
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// CashBankNumber of the ProfitLossClosingTemp
    /// CashBankNumber الخاص بـ ProfitLossClosingTemp
    /// </summary>
    public decimal? CashBankNumber { get; private set; }

    /// <summary>
    /// LetterCreditNumber of the ProfitLossClosingTemp
    /// LetterCreditNumber الخاص بـ ProfitLossClosingTemp
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// Amount of the ProfitLossClosingTemp
    /// Amount الخاص بـ ProfitLossClosingTemp
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// AmountForeign of the ProfitLossClosingTemp
    /// AmountForeign الخاص بـ ProfitLossClosingTemp
    /// </summary>
    public decimal? AmountForeign { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ProfitLossClosingTemp
    /// CompanyNumberShort الخاص بـ ProfitLossClosingTemp
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ProfitLossClosingTemp
    /// BranchNumber الخاص بـ ProfitLossClosingTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to AccountCurrency
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Project
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    #endregion
}
}
