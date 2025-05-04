using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.JudicialLegal.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Entities
{
/// <summary>
/// RequestJournalDetail Entity
/// </summary>
public class RequestJournalDetail : Entity<RequestJournalDetailId>
{
    private RequestJournalDetail() { }

    /// <summary>
    /// The unique identifier for the RequestJournalDetail
    /// المعرف الفريد لـ RequestJournalDetail
    /// </summary>
    public RequestJournalDetailId Id { get; private set; }

    /// <summary>
    /// JournalVoucherTypeFull of the RequestJournalDetail
    /// JournalVoucherTypeFull الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// JournalDocumentNumber of the RequestJournalDetail
    /// JournalDocumentNumber الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? JournalDocumentNumber { get; private set; }

    /// <summary>
    /// JournalSerial of the RequestJournalDetail
    /// JournalSerial الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? JournalSerial { get; private set; }

    /// <summary>
    /// AccountCode of the RequestJournalDetail
    /// AccountCode الخاص بـ RequestJournalDetail
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the RequestJournalDetail
    /// AccountDetailCode الخاص بـ RequestJournalDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailSubCode of the RequestJournalDetail
    /// AccountDetailSubCode الخاص بـ RequestJournalDetail
    /// </summary>
    public string AccountDetailSubCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the RequestJournalDetail
    /// AccountDetailType الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCurrency of the RequestJournalDetail
    /// AccountCurrency الخاص بـ RequestJournalDetail
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// JournalDescription of the RequestJournalDetail
    /// JournalDescription الخاص بـ RequestJournalDetail
    /// </summary>
    public string JournalDescription { get; private set; }

    /// <summary>
    /// JournalAmount of the RequestJournalDetail
    /// JournalAmount الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? JournalAmount { get; private set; }

    /// <summary>
    /// JournalAmountForeign of the RequestJournalDetail
    /// JournalAmountForeign الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? JournalAmountForeign { get; private set; }

    /// <summary>
    /// AccountRate of the RequestJournalDetail
    /// AccountRate الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// CostCenterCode of the RequestJournalDetail
    /// CostCenterCode الخاص بـ RequestJournalDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the RequestJournalDetail
    /// ProjectNumber الخاص بـ RequestJournalDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// RepCode of the RequestJournalDetail
    /// RepCode الخاص بـ RequestJournalDetail
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the RequestJournalDetail
    /// ColumnNumberShort الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// LetterCreditNumber of the RequestJournalDetail
    /// LetterCreditNumber الخاص بـ RequestJournalDetail
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// GroupNumberFull of the RequestJournalDetail
    /// GroupNumberFull الخاص بـ RequestJournalDetail
    /// </summary>
    public string GroupNumberFull { get; private set; }

    /// <summary>
    /// ActivityNumber of the RequestJournalDetail
    /// ActivityNumber الخاص بـ RequestJournalDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// NoteNumber of the RequestJournalDetail
    /// NoteNumber الخاص بـ RequestJournalDetail
    /// </summary>
    public string NoteNumber { get; private set; }

    /// <summary>
    /// DocBrnNo of the RequestJournalDetail
    /// DocBrnNo الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// RecordNumber of the RequestJournalDetail
    /// RecordNumber الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// RecordNumberOrder of the RequestJournalDetail
    /// RecordNumberOrder الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? RecordNumberOrder { get; private set; }

    /// <summary>
    /// DocTypeRef of the RequestJournalDetail
    /// DocTypeRef الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocJvTypeRef of the RequestJournalDetail
    /// DocJvTypeRef الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? DocJvTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the RequestJournalDetail
    /// DocNoRef الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the RequestJournalDetail
    /// DocSerRef الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocDueDate of the RequestJournalDetail
    /// DocDueDate الخاص بـ RequestJournalDetail
    /// </summary>
    public DateTime? DocDueDate { get; private set; }

    /// <summary>
    /// Note of the RequestJournalDetail
    /// Note الخاص بـ RequestJournalDetail
    /// </summary>
    public string Note { get; private set; }

    /// <summary>
    /// BillNumber of the RequestJournalDetail
    /// BillNumber الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the RequestJournalDetail
    /// BillSerial الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// ItemNumber of the RequestJournalDetail
    /// ItemNumber الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? ItemNumber { get; private set; }

    /// <summary>
    /// WorkOrderNumber of the RequestJournalDetail
    /// WorkOrderNumber الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? WorkOrderNumber { get; private set; }

    /// <summary>
    /// WorkOrderSerial of the RequestJournalDetail
    /// WorkOrderSerial الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? WorkOrderSerial { get; private set; }

    /// <summary>
    /// ReferenceNumber of the RequestJournalDetail
    /// ReferenceNumber الخاص بـ RequestJournalDetail
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// ChequeNumber of the RequestJournalDetail
    /// ChequeNumber الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// DocSequence of the RequestJournalDetail
    /// DocSequence الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the RequestJournalDetail
    /// CompanyNumberShort الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the RequestJournalDetail
    /// BranchNumber الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the RequestJournalDetail
    /// BranchYear الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the RequestJournalDetail
    /// BranchUser الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the RequestJournalDetail
    /// CalcTypeNumberTax الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the RequestJournalDetail
    /// ExternalPostFlag الخاص بـ RequestJournalDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// Field1Alt of the RequestJournalDetail
    /// Field1Alt الخاص بـ RequestJournalDetail
    /// </summary>
    public string Field1Alt { get; private set; }

    /// <summary>
    /// Field2Alt of the RequestJournalDetail
    /// Field2Alt الخاص بـ RequestJournalDetail
    /// </summary>
    public string Field2Alt { get; private set; }

    /// <summary>
    /// Field3Alt of the RequestJournalDetail
    /// Field3Alt الخاص بـ RequestJournalDetail
    /// </summary>
    public string Field3Alt { get; private set; }

    /// <summary>
    /// Field4Alt of the RequestJournalDetail
    /// Field4Alt الخاص بـ RequestJournalDetail
    /// </summary>
    public string Field4Alt { get; private set; }

    /// <summary>
    /// Field5Alt of the RequestJournalDetail
    /// Field5Alt الخاص بـ RequestJournalDetail
    /// </summary>
    public string Field5Alt { get; private set; }

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
    /// ManyToOne relationship to RequestJournalMaster
    /// </summary>
    public RequestJournalMaster RequestJournalMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Salesman
    /// </summary>
    public Salesman Salesman { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Collector
    /// </summary>
    public Collector Collector { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to LetterOfCreditMaster
    /// </summary>
    public LetterOfCreditMaster LetterOfCreditMaster { get; private set; }
    #endregion
}
}
