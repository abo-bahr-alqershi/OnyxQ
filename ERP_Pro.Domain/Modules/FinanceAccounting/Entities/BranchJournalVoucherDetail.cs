using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// BranchJournalVoucherDetail Entity
/// </summary>
public class BranchJournalVoucherDetail : Entity<BranchJournalVoucherDetailId>
{

    private BranchJournalVoucherDetail() { }

    public BranchJournalVoucherDetail(BranchJournalVoucherDetailId id, string accountCode, decimal? recordNumber)
    {
        Id = id;
        AccountCode = accountCode;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// The unique identifier for the BranchJournalVoucherDetail
    /// المعرف الفريد لـ BranchJournalVoucherDetail
    /// </summary>
    public BranchJournalVoucherDetailId Id { get; private set; }

    /// <summary>
    /// JournalVoucherTypeFull of the BranchJournalVoucherDetail
    /// JournalVoucherTypeFull الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// JournalDocumentNumber of the BranchJournalVoucherDetail
    /// JournalDocumentNumber الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? JournalDocumentNumber { get; private set; }

    /// <summary>
    /// AccountCode of the BranchJournalVoucherDetail
    /// AccountCode الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the BranchJournalVoucherDetail
    /// AccountDetailCode الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the BranchJournalVoucherDetail
    /// AccountDetailType الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCurrency of the BranchJournalVoucherDetail
    /// AccountCurrency الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// JournalDescription of the BranchJournalVoucherDetail
    /// JournalDescription الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public string JournalDescription { get; private set; }

    /// <summary>
    /// JournalAmount of the BranchJournalVoucherDetail
    /// JournalAmount الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? JournalAmount { get; private set; }

    /// <summary>
    /// JournalAmountForeign of the BranchJournalVoucherDetail
    /// JournalAmountForeign الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? JournalAmountForeign { get; private set; }

    /// <summary>
    /// AccountRate of the BranchJournalVoucherDetail
    /// AccountRate الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// CostCenterCode of the BranchJournalVoucherDetail
    /// CostCenterCode الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BranchJournalVoucherDetail
    /// ProjectNumber الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the BranchJournalVoucherDetail
    /// ActivityNumber الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// CCode of the BranchJournalVoucherDetail
    /// CCode الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// VendorCode of the BranchJournalVoucherDetail
    /// VendorCode الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// RepCode of the BranchJournalVoucherDetail
    /// RepCode الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the BranchJournalVoucherDetail
    /// ColumnNumberShort الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// LetterCreditNumber of the BranchJournalVoucherDetail
    /// LetterCreditNumber الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// GroupNumberFull of the BranchJournalVoucherDetail
    /// GroupNumberFull الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public string GroupNumberFull { get; private set; }

    /// <summary>
    /// CashBankNumber of the BranchJournalVoucherDetail
    /// CashBankNumber الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? CashBankNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the BranchJournalVoucherDetail
    /// RecordNumber الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// RecordNumberOrder of the BranchJournalVoucherDetail
    /// RecordNumberOrder الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? RecordNumberOrder { get; private set; }

    /// <summary>
    /// DocTypeRef of the BranchJournalVoucherDetail
    /// DocTypeRef الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocJvTypeRef of the BranchJournalVoucherDetail
    /// DocJvTypeRef الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? DocJvTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the BranchJournalVoucherDetail
    /// DocNoRef الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the BranchJournalVoucherDetail
    /// DocSerRef الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocDueDate of the BranchJournalVoucherDetail
    /// DocDueDate الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public DateTime? DocDueDate { get; private set; }

    /// <summary>
    /// BillNumber of the BranchJournalVoucherDetail
    /// BillNumber الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the BranchJournalVoucherDetail
    /// BillSerial الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// CashierNumber of the BranchJournalVoucherDetail
    /// CashierNumber الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? CashierNumber { get; private set; }

    /// <summary>
    /// ItemNumber of the BranchJournalVoucherDetail
    /// ItemNumber الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? ItemNumber { get; private set; }

    /// <summary>
    /// WorkOrderNumber of the BranchJournalVoucherDetail
    /// WorkOrderNumber الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? WorkOrderNumber { get; private set; }

    /// <summary>
    /// WorkOrderSerial of the BranchJournalVoucherDetail
    /// WorkOrderSerial الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? WorkOrderSerial { get; private set; }

    /// <summary>
    /// ReferenceNumber of the BranchJournalVoucherDetail
    /// ReferenceNumber الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// ChequeNumber of the BranchJournalVoucherDetail
    /// ChequeNumber الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// NoteNumber of the BranchJournalVoucherDetail
    /// NoteNumber الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public string NoteNumber { get; private set; }

    /// <summary>
    /// DocSequence of the BranchJournalVoucherDetail
    /// DocSequence الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchJournalVoucherDetail
    /// ExternalPostFlag الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// DocBrnNo of the BranchJournalVoucherDetail
    /// DocBrnNo الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// Note of the BranchJournalVoucherDetail
    /// Note الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public string Note { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchJournalVoucherDetail
    /// CompanyNumberShort الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchJournalVoucherDetail
    /// BranchNumber الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchJournalVoucherDetail
    /// BranchYear الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchJournalVoucherDetail
    /// BranchUser الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ContractNumber of the BranchJournalVoucherDetail
    /// ContractNumber الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? ContractNumber { get; private set; }

    /// <summary>
    /// ContractSerialShort of the BranchJournalVoucherDetail
    /// ContractSerialShort الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? ContractSerialShort { get; private set; }

    /// <summary>
    /// ContractBatch of the BranchJournalVoucherDetail
    /// ContractBatch الخاص بـ BranchJournalVoucherDetail
    /// </summary>
    public decimal? ContractBatch { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public JournalVoucherMaster JournalVoucherMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
