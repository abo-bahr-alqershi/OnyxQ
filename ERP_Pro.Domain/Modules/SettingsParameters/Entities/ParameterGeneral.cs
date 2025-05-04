using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SettingsParameters.Entities
{
/// <summary>
/// ParameterGeneral Entity
/// </summary>
public class ParameterGeneral : Entity<ParameterGeneralId>
{

    private ParameterGeneral() { }

    public ParameterGeneral(ParameterGeneralId id, decimal? parameterNumber)
    {
        Id = id;
        ParameterNumber = parameterNumber;
    }

    /// <summary>
    /// The unique identifier for the ParameterGeneral
    /// المعرف الفريد لـ ParameterGeneral
    /// </summary>
    public ParameterGeneralId Id { get; private set; }

    /// <summary>
    /// ParameterNumber of the ParameterGeneral
    /// ParameterNumber الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? ParameterNumber { get; private set; }

    /// <summary>
    /// CostCenterAvailable of the ParameterGeneral
    /// CostCenterAvailable الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? CostCenterAvailable { get; private set; }

    /// <summary>
    /// CostCenterPostFlag of the ParameterGeneral
    /// CostCenterPostFlag الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? CostCenterPostFlag { get; private set; }

    /// <summary>
    /// UseProjects of the ParameterGeneral
    /// UseProjects الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? UseProjects { get; private set; }

    /// <summary>
    /// UseActivity of the ParameterGeneral
    /// UseActivity الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? UseActivity { get; private set; }

    /// <summary>
    /// TypeOfPosting of the ParameterGeneral
    /// TypeOfPosting الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? TypeOfPosting { get; private set; }

    /// <summary>
    /// PostDiscountPercentItems of the ParameterGeneral
    /// PostDiscountPercentItems الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? PostDiscountPercentItems { get; private set; }

    /// <summary>
    /// UseExcel of the ParameterGeneral
    /// UseExcel الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? UseExcel { get; private set; }

    /// <summary>
    /// PathExcel of the ParameterGeneral
    /// PathExcel الخاص بـ ParameterGeneral
    /// </summary>
    public string PathExcel { get; private set; }

    /// <summary>
    /// UseIndividualGeneralLedgerSystem of the ParameterGeneral
    /// UseIndividualGeneralLedgerSystem الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? UseIndividualGeneralLedgerSystem { get; private set; }

    /// <summary>
    /// UseIndividualInvoiceSystem of the ParameterGeneral
    /// UseIndividualInvoiceSystem الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? UseIndividualInvoiceSystem { get; private set; }

    /// <summary>
    /// SpecialProgram of the ParameterGeneral
    /// SpecialProgram الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? SpecialProgram { get; private set; }

    /// <summary>
    /// UseVat of the ParameterGeneral
    /// UseVat الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? UseVat { get; private set; }

    /// <summary>
    /// ActiveVatDate of the ParameterGeneral
    /// ActiveVatDate الخاص بـ ParameterGeneral
    /// </summary>
    public DateTime? ActiveVatDate { get; private set; }

    /// <summary>
    /// UseUnposting of the ParameterGeneral
    /// UseUnposting الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? UseUnposting { get; private set; }

    /// <summary>
    /// HeadType of the ParameterGeneral
    /// HeadType الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? HeadType { get; private set; }

    /// <summary>
    /// ConnectionDetermineTerminal of the ParameterGeneral
    /// ConnectionDetermineTerminal الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? ConnectionDetermineTerminal { get; private set; }

    /// <summary>
    /// ConnectionNotMoreOne of the ParameterGeneral
    /// ConnectionNotMoreOne الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? ConnectionNotMoreOne { get; private set; }

    /// <summary>
    /// UseAuditDocument of the ParameterGeneral
    /// UseAuditDocument الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? UseAuditDocument { get; private set; }

    /// <summary>
    /// ShowEngineeringReport of the ParameterGeneral
    /// ShowEngineeringReport الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? ShowEngineeringReport { get; private set; }

    /// <summary>
    /// ShowParameterReport of the ParameterGeneral
    /// ShowParameterReport الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? ShowParameterReport { get; private set; }

    /// <summary>
    /// ShowExcelButtonReport of the ParameterGeneral
    /// ShowExcelButtonReport الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? ShowExcelButtonReport { get; private set; }

    /// <summary>
    /// LastUpdate of the ParameterGeneral
    /// LastUpdate الخاص بـ ParameterGeneral
    /// </summary>
    public DateTime? LastUpdate { get; private set; }

    /// <summary>
    /// UseVatProfit of the ParameterGeneral
    /// UseVatProfit الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? UseVatProfit { get; private set; }

    /// <summary>
    /// VatProfitPercent of the ParameterGeneral
    /// VatProfitPercent الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? VatProfitPercent { get; private set; }

    /// <summary>
    /// MinProfitAmount of the ParameterGeneral
    /// MinProfitAmount الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? MinProfitAmount { get; private set; }

    /// <summary>
    /// UseBalancedCostCenter of the ParameterGeneral
    /// UseBalancedCostCenter الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? UseBalancedCostCenter { get; private set; }

    /// <summary>
    /// UseBalancedBranch of the ParameterGeneral
    /// UseBalancedBranch الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? UseBalancedBranch { get; private set; }

    /// <summary>
    /// InactiveUserFailEntryCount of the ParameterGeneral
    /// InactiveUserFailEntryCount الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? InactiveUserFailEntryCount { get; private set; }

    /// <summary>
    /// MinUserPasswordLength of the ParameterGeneral
    /// MinUserPasswordLength الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? MinUserPasswordLength { get; private set; }

    /// <summary>
    /// LastDateLogin of the ParameterGeneral
    /// LastDateLogin الخاص بـ ParameterGeneral
    /// </summary>
    public DateTime? LastDateLogin { get; private set; }

    /// <summary>
    /// MaxPostDate of the ParameterGeneral
    /// MaxPostDate الخاص بـ ParameterGeneral
    /// </summary>
    public DateTime? MaxPostDate { get; private set; }

    /// <summary>
    /// ProjectPostFlag of the ParameterGeneral
    /// ProjectPostFlag الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? ProjectPostFlag { get; private set; }

    /// <summary>
    /// ActivityPostFlag of the ParameterGeneral
    /// ActivityPostFlag الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? ActivityPostFlag { get; private set; }

    /// <summary>
    /// EmpNoAuto of the ParameterGeneral
    /// EmpNoAuto الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? EmpNoAuto { get; private set; }

    /// <summary>
    /// EmpNoMaxLen of the ParameterGeneral
    /// EmpNoMaxLen الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? EmpNoMaxLen { get; private set; }

    /// <summary>
    /// EmpNoMinLen of the ParameterGeneral
    /// EmpNoMinLen الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? EmpNoMinLen { get; private set; }

    /// <summary>
    /// EmpPrvTyp of the ParameterGeneral
    /// EmpPrvTyp الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? EmpPrvTyp { get; private set; }

    /// <summary>
    /// ReportForceNumber of the ParameterGeneral
    /// ReportForceNumber الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? ReportForceNumber { get; private set; }

    /// <summary>
    /// UsePriceIncludeVat of the ParameterGeneral
    /// UsePriceIncludeVat الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? UsePriceIncludeVat { get; private set; }

    /// <summary>
    /// MobileFilePath of the ParameterGeneral
    /// MobileFilePath الخاص بـ ParameterGeneral
    /// </summary>
    public string MobileFilePath { get; private set; }

    /// <summary>
    /// VatPeriodType of the ParameterGeneral
    /// VatPeriodType الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? VatPeriodType { get; private set; }

    /// <summary>
    /// NotAllowMoreBranchUserLightPrivilege of the ParameterGeneral
    /// NotAllowMoreBranchUserLightPrivilege الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? NotAllowMoreBranchUserLightPrivilege { get; private set; }

    /// <summary>
    /// LastNameStartEmployeeName of the ParameterGeneral
    /// LastNameStartEmployeeName الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? LastNameStartEmployeeName { get; private set; }

    /// <summary>
    /// NoCheckFccCode of the ParameterGeneral
    /// NoCheckFccCode الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? NoCheckFccCode { get; private set; }

    /// <summary>
    /// AccountDetailSequence of the ParameterGeneral
    /// AccountDetailSequence الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? AccountDetailSequence { get; private set; }

    /// <summary>
    /// TaxPostMethod of the ParameterGeneral
    /// TaxPostMethod الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? TaxPostMethod { get; private set; }

    /// <summary>
    /// StartCreateViewYear of the ParameterGeneral
    /// StartCreateViewYear الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? StartCreateViewYear { get; private set; }

    /// <summary>
    /// TaxCodeLength of the ParameterGeneral
    /// TaxCodeLength الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? TaxCodeLength { get; private set; }

    /// <summary>
    /// StartCreateViewYearInvoice of the ParameterGeneral
    /// StartCreateViewYearInvoice الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? StartCreateViewYearInvoice { get; private set; }

    /// <summary>
    /// EmpNoSqFld of the ParameterGeneral
    /// EmpNoSqFld الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? EmpNoSqFld { get; private set; }

    /// <summary>
    /// DfltExpDirPath of the ParameterGeneral
    /// DfltExpDirPath الخاص بـ ParameterGeneral
    /// </summary>
    public string DfltExpDirPath { get; private set; }

    /// <summary>
    /// DfltExpDirPathDtl of the ParameterGeneral
    /// DfltExpDirPathDtl الخاص بـ ParameterGeneral
    /// </summary>
    public string DfltExpDirPathDtl { get; private set; }

    /// <summary>
    /// WebDocumentLink of the ParameterGeneral
    /// WebDocumentLink الخاص بـ ParameterGeneral
    /// </summary>
    public string WebDocumentLink { get; private set; }

    /// <summary>
    /// BalanceBranchType of the ParameterGeneral
    /// BalanceBranchType الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? BalanceBranchType { get; private set; }

    /// <summary>
    /// VatPostMethod of the ParameterGeneral
    /// VatPostMethod الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? VatPostMethod { get; private set; }

    /// <summary>
    /// UseTdsFlag of the ParameterGeneral
    /// UseTdsFlag الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? UseTdsFlag { get; private set; }

    /// <summary>
    /// MinUserPasswordLetter of the ParameterGeneral
    /// MinUserPasswordLetter الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? MinUserPasswordLetter { get; private set; }

    /// <summary>
    /// MinUserPasswordUpper of the ParameterGeneral
    /// MinUserPasswordUpper الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? MinUserPasswordUpper { get; private set; }

    /// <summary>
    /// MinUserPasswordLower of the ParameterGeneral
    /// MinUserPasswordLower الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? MinUserPasswordLower { get; private set; }

    /// <summary>
    /// MinUserPasswordDigit of the ParameterGeneral
    /// MinUserPasswordDigit الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? MinUserPasswordDigit { get; private set; }

    /// <summary>
    /// MinUserPasswordSpecial of the ParameterGeneral
    /// MinUserPasswordSpecial الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? MinUserPasswordSpecial { get; private set; }

    /// <summary>
    /// UseConnectionSdfa of the ParameterGeneral
    /// UseConnectionSdfa الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? UseConnectionSdfa { get; private set; }

    /// <summary>
    /// EmpNoSqTyp of the ParameterGeneral
    /// EmpNoSqTyp الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? EmpNoSqTyp { get; private set; }

    /// <summary>
    /// UseDocumentApprovedByUserLevel of the ParameterGeneral
    /// UseDocumentApprovedByUserLevel الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? UseDocumentApprovedByUserLevel { get; private set; }

    /// <summary>
    /// UseSendWebMessage of the ParameterGeneral
    /// UseSendWebMessage الخاص بـ ParameterGeneral
    /// </summary>
    public decimal? UseSendWebMessage { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
