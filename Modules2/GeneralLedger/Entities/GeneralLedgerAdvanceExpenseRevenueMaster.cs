using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;
namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerAdvanceExpenseRevenueMaster Entity
/// </summary>
public class GeneralLedgerAdvanceExpenseRevenueMaster : Entity<GeneralLedgerAdvanceExpenseRevenueMasterId>
{

    private GeneralLedgerAdvanceExpenseRevenueMaster() { }

    public GeneralLedgerAdvanceExpenseRevenueMaster(GeneralLedgerAdvanceExpenseRevenueMasterId id, decimal? docSrl)
    {
        Id = id;
        DocSrl = docSrl;
    }

    /// <summary>
    /// The unique identifier for the GeneralLedgerAdvanceExpenseRevenueMaster
    /// المعرف الفريد لـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public GeneralLedgerAdvanceExpenseRevenueMasterId Id { get; private set; }

    /// <summary>
    /// DocTyp of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// DocTyp الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? DocTyp { get; private set; }

    /// <summary>
    /// TypeNumberShort of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// TypeNumberShort الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// DocNo of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// DocNo الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSrl of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// DocSrl الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// DocMSq of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// DocMSq الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? DocMSq { get; private set; }

    /// <summary>
    /// DocDate of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// DocDate الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AccountDetailAdvanceCode of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// AccountDetailAdvanceCode الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public string AccountDetailAdvanceCode { get; private set; }

    /// <summary>
    /// AccountDetailTypeAdvance of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// AccountDetailTypeAdvance الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? AccountDetailTypeAdvance { get; private set; }

    /// <summary>
    /// AccountDetailSubAdvanceCode of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// AccountDetailSubAdvanceCode الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public string AccountDetailSubAdvanceCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// AccountDetailCode الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// AccountDetailType الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountDetailSubCode of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// AccountDetailSubCode الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public string AccountDetailSubCode { get; private set; }

    /// <summary>
    /// ItemCount of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// ItemCount الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? ItemCount { get; private set; }

    /// <summary>
    /// StartDateShort of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// StartDateShort الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public DateTime? StartDateShort { get; private set; }

    /// <summary>
    /// EndDate of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// EndDate الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public DateTime? EndDate { get; private set; }

    /// <summary>
    /// ReferenceNumber of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// ReferenceNumber الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DocDsc of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// DocDsc الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// CurRate of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// CurRate الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// AmountLocal of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// AmountLocal الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? AmountLocal { get; private set; }

    /// <summary>
    /// AmountForeign of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// AmountForeign الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? AmountForeign { get; private set; }

    /// <summary>
    /// Field1 of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// Field1 الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// Field2 الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// Field3 الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// Field4 الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// Field5 الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// Field6 الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// Field7 الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// Field8 الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// Field9 الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// Field10 الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// CostCenterCode of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// CostCenterCode الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// ProjectNumber الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// ActivityNumber الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// AttachmentNumber of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// AttachmentNumber الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? AttachmentNumber { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// ExternalPostFlag الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// AuditReference of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// AuditReference الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// AuditReferenceDescription الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// AuditReferenceUserId الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// AuditReferenceDate الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// DocPost of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// DocPost الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? DocPost { get; private set; }

    /// <summary>
    /// PostUserId of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// PostUserId الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// PostDate الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// UnpostUserId الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// UnpostDate الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// CompanyNumberShort الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// BranchNumber الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// BranchYear الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// BranchUser الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// DocTypRef of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// DocTypRef الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? DocTypRef { get; private set; }

    /// <summary>
    /// DocSrlRef of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// DocSrlRef الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? DocSrlRef { get; private set; }

    /// <summary>
    /// DocNoRef of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// DocNoRef الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocMSqRef of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// DocMSqRef الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? DocMSqRef { get; private set; }

    /// <summary>
    /// ExpenseDistributionFlag of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// ExpenseDistributionFlag الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? ExpenseDistributionFlag { get; private set; }

    /// <summary>
    /// StandByFlag of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// StandByFlag الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// DocBrnNo of the GeneralLedgerAdvanceExpenseRevenueMaster
    /// DocBrnNo الخاص بـ GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountCurrency AccountCurrencyAcCode { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

