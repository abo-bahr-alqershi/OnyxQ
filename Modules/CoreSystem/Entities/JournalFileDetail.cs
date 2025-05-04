using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.JudicialLegal.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// JournalFileDetail Entity
/// </summary>
public class JournalFileDetail : Entity<JournalFileDetailId>
{
    private JournalFileDetail() { }

    /// <summary>
    /// The unique identifier for the JournalFileDetail
    /// المعرف الفريد لـ JournalFileDetail
    /// </summary>
    public JournalFileDetailId Id { get; private set; }

    /// <summary>
    /// DocType of the JournalFileDetail
    /// DocType الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// JournalVoucherTypeFull of the JournalFileDetail
    /// JournalVoucherTypeFull الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// JournalDocumentNumber of the JournalFileDetail
    /// JournalDocumentNumber الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? JournalDocumentNumber { get; private set; }

    /// <summary>
    /// JournalSerial of the JournalFileDetail
    /// JournalSerial الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? JournalSerial { get; private set; }

    /// <summary>
    /// AccountCodeExternal of the JournalFileDetail
    /// AccountCodeExternal الخاص بـ JournalFileDetail
    /// </summary>
    public string AccountCodeExternal { get; private set; }

    /// <summary>
    /// AccountCode of the JournalFileDetail
    /// AccountCode الخاص بـ JournalFileDetail
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the JournalFileDetail
    /// AccountDetailCode الخاص بـ JournalFileDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailSubCode of the JournalFileDetail
    /// AccountDetailSubCode الخاص بـ JournalFileDetail
    /// </summary>
    public string AccountDetailSubCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the JournalFileDetail
    /// AccountDetailType الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCodeAnalysisExternal of the JournalFileDetail
    /// AccountCodeAnalysisExternal الخاص بـ JournalFileDetail
    /// </summary>
    public string AccountCodeAnalysisExternal { get; private set; }

    /// <summary>
    /// AccountCurrencyExternal of the JournalFileDetail
    /// AccountCurrencyExternal الخاص بـ JournalFileDetail
    /// </summary>
    public string AccountCurrencyExternal { get; private set; }

    /// <summary>
    /// AccountCurrency of the JournalFileDetail
    /// AccountCurrency الخاص بـ JournalFileDetail
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// JournalDescription of the JournalFileDetail
    /// JournalDescription الخاص بـ JournalFileDetail
    /// </summary>
    public string JournalDescription { get; private set; }

    /// <summary>
    /// DrAmt of the JournalFileDetail
    /// DrAmt الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? DrAmt { get; private set; }

    /// <summary>
    /// CreditAmount of the JournalFileDetail
    /// CreditAmount الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? CreditAmount { get; private set; }

    /// <summary>
    /// DrAmtF of the JournalFileDetail
    /// DrAmtF الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? DrAmtF { get; private set; }

    /// <summary>
    /// CreditAmountForeignShort of the JournalFileDetail
    /// CreditAmountForeignShort الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? CreditAmountForeignShort { get; private set; }

    /// <summary>
    /// AccountRate of the JournalFileDetail
    /// AccountRate الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// CostCenterCode of the JournalFileDetail
    /// CostCenterCode الخاص بـ JournalFileDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// CostCenterCodeExternal of the JournalFileDetail
    /// CostCenterCodeExternal الخاص بـ JournalFileDetail
    /// </summary>
    public string CostCenterCodeExternal { get; private set; }

    /// <summary>
    /// ProjectNumber of the JournalFileDetail
    /// ProjectNumber الخاص بـ JournalFileDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ProjectNumberExternal of the JournalFileDetail
    /// ProjectNumberExternal الخاص بـ JournalFileDetail
    /// </summary>
    public string ProjectNumberExternal { get; private set; }

    /// <summary>
    /// ActivityNumber of the JournalFileDetail
    /// ActivityNumber الخاص بـ JournalFileDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ActivityNumberExternal of the JournalFileDetail
    /// ActivityNumberExternal الخاص بـ JournalFileDetail
    /// </summary>
    public string ActivityNumberExternal { get; private set; }

    /// <summary>
    /// CCode of the JournalFileDetail
    /// CCode الخاص بـ JournalFileDetail
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// VendorCode of the JournalFileDetail
    /// VendorCode الخاص بـ JournalFileDetail
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// RepCode of the JournalFileDetail
    /// RepCode الخاص بـ JournalFileDetail
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the JournalFileDetail
    /// ColumnNumberShort الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// LetterCreditNumber of the JournalFileDetail
    /// LetterCreditNumber الخاص بـ JournalFileDetail
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// GroupNumberFull of the JournalFileDetail
    /// GroupNumberFull الخاص بـ JournalFileDetail
    /// </summary>
    public string GroupNumberFull { get; private set; }

    /// <summary>
    /// CashBankNumber of the JournalFileDetail
    /// CashBankNumber الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? CashBankNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the JournalFileDetail
    /// RecordNumber الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// RecordNumberOrder of the JournalFileDetail
    /// RecordNumberOrder الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? RecordNumberOrder { get; private set; }

    /// <summary>
    /// DocTypeRef of the JournalFileDetail
    /// DocTypeRef الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocJvTypeRef of the JournalFileDetail
    /// DocJvTypeRef الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? DocJvTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the JournalFileDetail
    /// DocNoRef الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the JournalFileDetail
    /// DocSerRef الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocDueDate of the JournalFileDetail
    /// DocDueDate الخاص بـ JournalFileDetail
    /// </summary>
    public DateTime? DocDueDate { get; private set; }

    /// <summary>
    /// BillNumber of the JournalFileDetail
    /// BillNumber الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the JournalFileDetail
    /// BillSerial الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// ItemNumber of the JournalFileDetail
    /// ItemNumber الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? ItemNumber { get; private set; }

    /// <summary>
    /// WorkOrderNumber of the JournalFileDetail
    /// WorkOrderNumber الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? WorkOrderNumber { get; private set; }

    /// <summary>
    /// WorkOrderSerial of the JournalFileDetail
    /// WorkOrderSerial الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? WorkOrderSerial { get; private set; }

    /// <summary>
    /// ReferenceNumber of the JournalFileDetail
    /// ReferenceNumber الخاص بـ JournalFileDetail
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// ChequeNumber of the JournalFileDetail
    /// ChequeNumber الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// DocSequence of the JournalFileDetail
    /// DocSequence الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the JournalFileDetail
    /// CompanyNumberShort الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the JournalFileDetail
    /// BranchNumber الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the JournalFileDetail
    /// BranchYear الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the JournalFileDetail
    /// BranchUser الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// NoteNumber of the JournalFileDetail
    /// NoteNumber الخاص بـ JournalFileDetail
    /// </summary>
    public string NoteNumber { get; private set; }

    /// <summary>
    /// DocBrnNo of the JournalFileDetail
    /// DocBrnNo الخاص بـ JournalFileDetail
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to JournalFileMaster
    /// </summary>
    public JournalFileMaster JournalFileMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to AccountCurrency
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Collector
    /// </summary>
    public Collector Collector { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Customer
    /// </summary>
    public Customer Customer { get; private set; }
    /// <summary>
    /// ManyToOne relationship to VoucherDetails
    /// </summary>
    public VoucherDetails VoucherDetails { get; private set; }
    /// <summary>
    /// ManyToOne relationship to LetterOfCreditMaster
    /// </summary>
    public LetterOfCreditMaster LetterOfCreditMaster { get; private set; }
    #endregion
}
}
