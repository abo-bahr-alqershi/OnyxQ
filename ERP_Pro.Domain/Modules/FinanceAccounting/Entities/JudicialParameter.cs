using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// JudicialParameter Entity
/// </summary>
public class JudicialParameter : Entity<JudicialParameterId>
{

    private JudicialParameter() { }

    public JudicialParameter(JudicialParameterId id, decimal? parameterNumber)
    {
        Id = id;
        ParameterNumber = parameterNumber;
    }

    /// <summary>
    /// The unique identifier for the JudicialParameter
    /// المعرف الفريد لـ JudicialParameter
    /// </summary>
    public JudicialParameterId Id { get; private set; }

    /// <summary>
    /// ParameterNumber of the JudicialParameter
    /// ParameterNumber الخاص بـ JudicialParameter
    /// </summary>
    public decimal? ParameterNumber { get; private set; }

    /// <summary>
    /// DocGenJrs of the JudicialParameter
    /// DocGenJrs الخاص بـ JudicialParameter
    /// </summary>
    public decimal? DocGenJrs { get; private set; }

    /// <summary>
    /// AllowDocumentDeleteNumber of the JudicialParameter
    /// AllowDocumentDeleteNumber الخاص بـ JudicialParameter
    /// </summary>
    public decimal? AllowDocumentDeleteNumber { get; private set; }

    /// <summary>
    /// DateGenJrs of the JudicialParameter
    /// DateGenJrs الخاص بـ JudicialParameter
    /// </summary>
    public decimal? DateGenJrs { get; private set; }

    /// <summary>
    /// DateSettingJrs of the JudicialParameter
    /// DateSettingJrs الخاص بـ JudicialParameter
    /// </summary>
    public decimal? DateSettingJrs { get; private set; }

    /// <summary>
    /// UseDeleteJournal of the JudicialParameter
    /// UseDeleteJournal الخاص بـ JudicialParameter
    /// </summary>
    public decimal? UseDeleteJournal { get; private set; }

    /// <summary>
    /// UseModifyJournal of the JudicialParameter
    /// UseModifyJournal الخاص بـ JudicialParameter
    /// </summary>
    public decimal? UseModifyJournal { get; private set; }

    /// <summary>
    /// UseImportToJournal of the JudicialParameter
    /// UseImportToJournal الخاص بـ JudicialParameter
    /// </summary>
    public decimal? UseImportToJournal { get; private set; }

    /// <summary>
    /// UseImportToPost of the JudicialParameter
    /// UseImportToPost الخاص بـ JudicialParameter
    /// </summary>
    public decimal? UseImportToPost { get; private set; }

    /// <summary>
    /// LinkWithExternalDirectories of the JudicialParameter
    /// LinkWithExternalDirectories الخاص بـ JudicialParameter
    /// </summary>
    public decimal? LinkWithExternalDirectories { get; private set; }

    /// <summary>
    /// UseIntermediateDatabase of the JudicialParameter
    /// UseIntermediateDatabase الخاص بـ JudicialParameter
    /// </summary>
    public decimal? UseIntermediateDatabase { get; private set; }

    /// <summary>
    /// DrSmbl of the JudicialParameter
    /// DrSmbl الخاص بـ JudicialParameter
    /// </summary>
    public string DrSmbl { get; private set; }

    /// <summary>
    /// CreditSymbol of the JudicialParameter
    /// CreditSymbol الخاص بـ JudicialParameter
    /// </summary>
    public string CreditSymbol { get; private set; }

    /// <summary>
    /// DrCnfg of the JudicialParameter
    /// DrCnfg الخاص بـ JudicialParameter
    /// </summary>
    public string DrCnfg { get; private set; }

    /// <summary>
    /// CreditConfig of the JudicialParameter
    /// CreditConfig الخاص بـ JudicialParameter
    /// </summary>
    public string CreditConfig { get; private set; }

    /// <summary>
    /// UseImportFromExcel of the JudicialParameter
    /// UseImportFromExcel الخاص بـ JudicialParameter
    /// </summary>
    public decimal? UseImportFromExcel { get; private set; }

    /// <summary>
    /// UseImportFromText of the JudicialParameter
    /// UseImportFromText الخاص بـ JudicialParameter
    /// </summary>
    public decimal? UseImportFromText { get; private set; }

    /// <summary>
    /// UseConnectionAccountExternalBranch of the JudicialParameter
    /// UseConnectionAccountExternalBranch الخاص بـ JudicialParameter
    /// </summary>
    public decimal? UseConnectionAccountExternalBranch { get; private set; }

    /// <summary>
    /// ConnectionAccountDocumentType of the JudicialParameter
    /// ConnectionAccountDocumentType الخاص بـ JudicialParameter
    /// </summary>
    public decimal? ConnectionAccountDocumentType { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
