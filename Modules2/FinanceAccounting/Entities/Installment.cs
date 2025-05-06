using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// Installment Entity
/// </summary>
public class Installment : Entity<InstallmentId>
{

    private Installment() { }

    public Installment(InstallmentId id, decimal? billSerial, decimal? itemNumber, string cCode, decimal? itemPaymentYear, decimal? recordNumber)
    {
        Id = id;
        BillSerial = billSerial;
        ItemNumber = itemNumber;
        CCode = cCode;
        ItemPaymentYear = itemPaymentYear;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// The unique identifier for the Installment
    /// المعرف الفريد لـ Installment
    /// </summary>
    public InstallmentId Id { get; private set; }

    /// <summary>
    /// DocType of the Installment
    /// DocType الخاص بـ Installment
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the Installment
    /// BillDocumentTypeFull الخاص بـ Installment
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillNumber of the Installment
    /// BillNumber الخاص بـ Installment
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the Installment
    /// BillSerial الخاص بـ Installment
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// DocDate of the Installment
    /// DocDate الخاص بـ Installment
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// ItemNumber of the Installment
    /// ItemNumber الخاص بـ Installment
    /// </summary>
    public decimal? ItemNumber { get; private set; }

    /// <summary>
    /// ItemDate of the Installment
    /// ItemDate الخاص بـ Installment
    /// </summary>
    public DateTime? ItemDate { get; private set; }

    /// <summary>
    /// InvoiceAmount of the Installment
    /// InvoiceAmount الخاص بـ Installment
    /// </summary>
    public decimal? InvoiceAmount { get; private set; }

    /// <summary>
    /// AccountRate of the Installment
    /// AccountRate الخاص بـ Installment
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// ChequeNumber of the Installment
    /// ChequeNumber الخاص بـ Installment
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// ChequeDueDate of the Installment
    /// ChequeDueDate الخاص بـ Installment
    /// </summary>
    public DateTime? ChequeDueDate { get; private set; }

    /// <summary>
    /// CostCenterCode of the Installment
    /// CostCenterCode الخاص بـ Installment
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the Installment
    /// ProjectNumber الخاص بـ Installment
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// CCode of the Installment
    /// CCode الخاص بـ Installment
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the Installment
    /// AccountCurrency الخاص بـ Installment
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// PaidAmount of the Installment
    /// PaidAmount الخاص بـ Installment
    /// </summary>
    public decimal? PaidAmount { get; private set; }

    /// <summary>
    /// PaidDate of the Installment
    /// PaidDate الخاص بـ Installment
    /// </summary>
    public DateTime? PaidDate { get; private set; }

    /// <summary>
    /// AdjustmentAmount of the Installment
    /// AdjustmentAmount الخاص بـ Installment
    /// </summary>
    public decimal? AdjustmentAmount { get; private set; }

    /// <summary>
    /// ReferenceNumber of the Installment
    /// ReferenceNumber الخاص بـ Installment
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DrNo of the Installment
    /// DrNo الخاص بـ Installment
    /// </summary>
    public decimal? DrNo { get; private set; }

    /// <summary>
    /// ItemPaymentYear of the Installment
    /// ItemPaymentYear الخاص بـ Installment
    /// </summary>
    public decimal? ItemPaymentYear { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the Installment
    /// ExternalPostFlag الخاص بـ Installment
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// RecordNumber of the Installment
    /// RecordNumber الخاص بـ Installment
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the Installment
    /// DocSequence الخاص بـ Installment
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the Installment
    /// CompanyNumberShort الخاص بـ Installment
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the Installment
    /// BranchNumber الخاص بـ Installment
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the Installment
    /// BranchYear الخاص بـ Installment
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the Installment
    /// BranchUser الخاص بـ Installment
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// DocDsc of the Installment
    /// DocDsc الخاص بـ Installment
    /// </summary>
    public string DocDsc { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

