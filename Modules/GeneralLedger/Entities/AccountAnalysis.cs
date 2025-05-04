using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// AccountAnalysis Entity
/// </summary>
public class AccountAnalysis : Entity<AccountAnalysisId>
{
    private AccountAnalysis() { }

    /// <summary>
    /// The unique identifier for the AccountAnalysis
    /// المعرف الفريد لـ AccountAnalysis
    /// </summary>
    public AccountAnalysisId Id { get; private set; }

    /// <summary>
    /// AnalysisNumber of the AccountAnalysis
    /// AnalysisNumber الخاص بـ AccountAnalysis
    /// </summary>
    public decimal? AnalysisNumber { get; private set; }

    /// <summary>
    /// AnalysisLastName of the AccountAnalysis
    /// AnalysisLastName الخاص بـ AccountAnalysis
    /// </summary>
    public string AnalysisLastName { get; private set; }

    /// <summary>
    /// AnalysisFirstName of the AccountAnalysis
    /// AnalysisFirstName الخاص بـ AccountAnalysis
    /// </summary>
    public string AnalysisFirstName { get; private set; }

    /// <summary>
    /// AnalysisParentNumber of the AccountAnalysis
    /// AnalysisParentNumber الخاص بـ AccountAnalysis
    /// </summary>
    public decimal? AnalysisParentNumber { get; private set; }

    /// <summary>
    /// ChangeOrderNumber of the AccountAnalysis
    /// ChangeOrderNumber الخاص بـ AccountAnalysis
    /// </summary>
    public string ChangeOrderNumber { get; private set; }

    /// <summary>
    /// Notes of the AccountAnalysis
    /// Notes الخاص بـ AccountAnalysis
    /// </summary>
    public string Notes { get; private set; }

    /// <summary>
    /// OrderNumberShort of the AccountAnalysis
    /// OrderNumberShort الخاص بـ AccountAnalysis
    /// </summary>
    public decimal? OrderNumberShort { get; private set; }

    /// <summary>
    /// AccountDetailType of the AccountAnalysis
    /// AccountDetailType الخاص بـ AccountAnalysis
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// FlowType of the AccountAnalysis
    /// FlowType الخاص بـ AccountAnalysis
    /// </summary>
    public decimal? FlowType { get; private set; }

    /// <summary>
    /// UpdateAccounts of the AccountAnalysis
    /// UpdateAccounts الخاص بـ AccountAnalysis
    /// </summary>
    public decimal? UpdateAccounts { get; private set; }

    /// <summary>
    /// MainSubject of the AccountAnalysis
    /// MainSubject الخاص بـ AccountAnalysis
    /// </summary>
    public decimal? MainSubject { get; private set; }

    /// <summary>
    /// AccountLevel of the AccountAnalysis
    /// AccountLevel الخاص بـ AccountAnalysis
    /// </summary>
    public decimal? AccountLevel { get; private set; }
}
}
