using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// ProfitLossClosingTemp Entity
/// </summary>
public class ProfitLossClosingTemp : Entity<ProfitLossClosingTempId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<AccountCurrency> _accountCurrency = new List<AccountCurrency>();
    private readonly List<Project> _project = new List<Project>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();

    private ProfitLossClosingTemp() { }

    public ProfitLossClosingTemp(ProfitLossClosingTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the ProfitLossClosingTemp
    /// المعرف الفريد لـ ProfitLossClosingTemp
    /// </summary>
    public ProfitLossClosingTempId Id { get; private set; }

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
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Activity> Activity => _activity;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<AccountCurrency> AccountCurrency => _accountCurrency;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Project> Project => _project;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CostCenter> CostCenter => _costCenter;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

