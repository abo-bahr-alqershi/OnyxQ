using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.JudicialLegal.Entities;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// JournalVoucherDetail Entity
/// </summary>
public class JournalVoucherDetail : Entity<JournalVoucherDetailId>
{

    private JournalVoucherDetail() { }

    public JournalVoucherDetail(JournalVoucherDetailId id, decimal? recordNumber)
    {
        Id = id;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// The unique identifier for the JournalVoucherDetail
    /// المعرف الفريد لـ JournalVoucherDetail
    /// </summary>
    public JournalVoucherDetailId Id { get; private set; }

    /// <summary>
    /// JournalVoucherTypeFull of the JournalVoucherDetail
    /// JournalVoucherTypeFull الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// JournalDocumentNumber of the JournalVoucherDetail
    /// JournalDocumentNumber الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? JournalDocumentNumber { get; private set; }

    /// <summary>
    /// AccountDetailCode of the JournalVoucherDetail
    /// AccountDetailCode الخاص بـ JournalVoucherDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailSubCode of the JournalVoucherDetail
    /// AccountDetailSubCode الخاص بـ JournalVoucherDetail
    /// </summary>
    public string AccountDetailSubCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the JournalVoucherDetail
    /// AccountDetailType الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// JournalDescription of the JournalVoucherDetail
    /// JournalDescription الخاص بـ JournalVoucherDetail
    /// </summary>
    public string JournalDescription { get; private set; }

    /// <summary>
    /// JournalAmount of the JournalVoucherDetail
    /// JournalAmount الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? JournalAmount { get; private set; }

    /// <summary>
    /// JournalAmountForeign of the JournalVoucherDetail
    /// JournalAmountForeign الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? JournalAmountForeign { get; private set; }

    /// <summary>
    /// AccountRate of the JournalVoucherDetail
    /// AccountRate الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// GroupNumberFull of the JournalVoucherDetail
    /// GroupNumberFull الخاص بـ JournalVoucherDetail
    /// </summary>
    public string GroupNumberFull { get; private set; }

    /// <summary>
    /// CashBankNumber of the JournalVoucherDetail
    /// CashBankNumber الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? CashBankNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the JournalVoucherDetail
    /// RecordNumber الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// RecordNumberOrder of the JournalVoucherDetail
    /// RecordNumberOrder الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? RecordNumberOrder { get; private set; }

    /// <summary>
    /// DocTypeRef of the JournalVoucherDetail
    /// DocTypeRef الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocJvTypeRef of the JournalVoucherDetail
    /// DocJvTypeRef الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? DocJvTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the JournalVoucherDetail
    /// DocNoRef الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the JournalVoucherDetail
    /// DocSerRef الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocDueDate of the JournalVoucherDetail
    /// DocDueDate الخاص بـ JournalVoucherDetail
    /// </summary>
    public DateTime? DocDueDate { get; private set; }

    /// <summary>
    /// BillNumber of the JournalVoucherDetail
    /// BillNumber الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the JournalVoucherDetail
    /// BillSerial الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// CashierNumber of the JournalVoucherDetail
    /// CashierNumber الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? CashierNumber { get; private set; }

    /// <summary>
    /// ItemNumber of the JournalVoucherDetail
    /// ItemNumber الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? ItemNumber { get; private set; }

    /// <summary>
    /// WorkOrderNumber of the JournalVoucherDetail
    /// WorkOrderNumber الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? WorkOrderNumber { get; private set; }

    /// <summary>
    /// WorkOrderSerial of the JournalVoucherDetail
    /// WorkOrderSerial الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? WorkOrderSerial { get; private set; }

    /// <summary>
    /// ReferenceNumber of the JournalVoucherDetail
    /// ReferenceNumber الخاص بـ JournalVoucherDetail
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// ContractNumber of the JournalVoucherDetail
    /// ContractNumber الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? ContractNumber { get; private set; }

    /// <summary>
    /// ContractSerialShort of the JournalVoucherDetail
    /// ContractSerialShort الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? ContractSerialShort { get; private set; }

    /// <summary>
    /// ContractBatch of the JournalVoucherDetail
    /// ContractBatch الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? ContractBatch { get; private set; }

    /// <summary>
    /// ChequeNumber of the JournalVoucherDetail
    /// ChequeNumber الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// NoteNumber of the JournalVoucherDetail
    /// NoteNumber الخاص بـ JournalVoucherDetail
    /// </summary>
    public string NoteNumber { get; private set; }

    /// <summary>
    /// DocSequence of the JournalVoucherDetail
    /// DocSequence الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the JournalVoucherDetail
    /// ExternalPostFlag الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// DocBrnNo of the JournalVoucherDetail
    /// DocBrnNo الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// Note of the JournalVoucherDetail
    /// Note الخاص بـ JournalVoucherDetail
    /// </summary>
    public string Note { get; private set; }

    /// <summary>
    /// DocSequenceRef of the JournalVoucherDetail
    /// DocSequenceRef الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// RecordNumberReference of the JournalVoucherDetail
    /// RecordNumberReference الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? RecordNumberReference { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the JournalVoucherDetail
    /// CompanyNumberShort الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the JournalVoucherDetail
    /// BranchNumber الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the JournalVoucherDetail
    /// BranchYear الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the JournalVoucherDetail
    /// BranchUser الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the JournalVoucherDetail
    /// CalcTypeNumberTax الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// TaxPercent of the JournalVoucherDetail
    /// TaxPercent الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? TaxPercent { get; private set; }

    /// <summary>
    /// TaxAmount of the JournalVoucherDetail
    /// TaxAmount الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? TaxAmount { get; private set; }

    /// <summary>
    /// HoursDocumentTypeRef of the JournalVoucherDetail
    /// HoursDocumentTypeRef الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? HoursDocumentTypeRef { get; private set; }

    /// <summary>
    /// HoursDocumentSerialRef of the JournalVoucherDetail
    /// HoursDocumentSerialRef الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? HoursDocumentSerialRef { get; private set; }

    /// <summary>
    /// HoursDocumentNumberReference of the JournalVoucherDetail
    /// HoursDocumentNumberReference الخاص بـ JournalVoucherDetail
    /// </summary>
    public decimal? HoursDocumentNumberReference { get; private set; }

    /// <summary>
    /// Field1Alt of the JournalVoucherDetail
    /// Field1Alt الخاص بـ JournalVoucherDetail
    /// </summary>
    public string Field1Alt { get; private set; }

    /// <summary>
    /// Field2Alt of the JournalVoucherDetail
    /// Field2Alt الخاص بـ JournalVoucherDetail
    /// </summary>
    public string Field2Alt { get; private set; }

    /// <summary>
    /// Field3Alt of the JournalVoucherDetail
    /// Field3Alt الخاص بـ JournalVoucherDetail
    /// </summary>
    public string Field3Alt { get; private set; }

    /// <summary>
    /// Field4Alt of the JournalVoucherDetail
    /// Field4Alt الخاص بـ JournalVoucherDetail
    /// </summary>
    public string Field4Alt { get; private set; }

    /// <summary>
    /// Field5Alt of the JournalVoucherDetail
    /// Field5Alt الخاص بـ JournalVoucherDetail
    /// </summary>
    public string Field5Alt { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Salesman Salesman { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Collector Collector { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Customer Customer { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public VoucherDetails VoucherDetails { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public LetterOfCreditMaster LetterOfCreditMaster { get; private set; }
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

