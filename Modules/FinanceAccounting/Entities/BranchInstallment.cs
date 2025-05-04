using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// BranchInstallment Entity
/// </summary>
public class BranchInstallment : Entity<BranchInstallmentId>
{
    private BranchInstallment() { }

    /// <summary>
    /// The unique identifier for the BranchInstallment
    /// المعرف الفريد لـ BranchInstallment
    /// </summary>
    public BranchInstallmentId Id { get; private set; }

    /// <summary>
    /// DocType of the BranchInstallment
    /// DocType الخاص بـ BranchInstallment
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the BranchInstallment
    /// BillDocumentTypeFull الخاص بـ BranchInstallment
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillNumber of the BranchInstallment
    /// BillNumber الخاص بـ BranchInstallment
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the BranchInstallment
    /// BillSerial الخاص بـ BranchInstallment
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// DocDate of the BranchInstallment
    /// DocDate الخاص بـ BranchInstallment
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// ItemNumber of the BranchInstallment
    /// ItemNumber الخاص بـ BranchInstallment
    /// </summary>
    public decimal? ItemNumber { get; private set; }

    /// <summary>
    /// ItemDate of the BranchInstallment
    /// ItemDate الخاص بـ BranchInstallment
    /// </summary>
    public DateTime? ItemDate { get; private set; }

    /// <summary>
    /// InvoiceAmount of the BranchInstallment
    /// InvoiceAmount الخاص بـ BranchInstallment
    /// </summary>
    public decimal? InvoiceAmount { get; private set; }

    /// <summary>
    /// AccountRate of the BranchInstallment
    /// AccountRate الخاص بـ BranchInstallment
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// ChequeNumber of the BranchInstallment
    /// ChequeNumber الخاص بـ BranchInstallment
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// ChequeDueDate of the BranchInstallment
    /// ChequeDueDate الخاص بـ BranchInstallment
    /// </summary>
    public DateTime? ChequeDueDate { get; private set; }

    /// <summary>
    /// CostCenterCode of the BranchInstallment
    /// CostCenterCode الخاص بـ BranchInstallment
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BranchInstallment
    /// ProjectNumber الخاص بـ BranchInstallment
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the BranchInstallment
    /// ActivityNumber الخاص بـ BranchInstallment
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// CCode of the BranchInstallment
    /// CCode الخاص بـ BranchInstallment
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the BranchInstallment
    /// AccountCurrency الخاص بـ BranchInstallment
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// PaidAmount of the BranchInstallment
    /// PaidAmount الخاص بـ BranchInstallment
    /// </summary>
    public decimal? PaidAmount { get; private set; }

    /// <summary>
    /// PaidDate of the BranchInstallment
    /// PaidDate الخاص بـ BranchInstallment
    /// </summary>
    public DateTime? PaidDate { get; private set; }

    /// <summary>
    /// AdjustmentAmount of the BranchInstallment
    /// AdjustmentAmount الخاص بـ BranchInstallment
    /// </summary>
    public decimal? AdjustmentAmount { get; private set; }

    /// <summary>
    /// ReferenceNumber of the BranchInstallment
    /// ReferenceNumber الخاص بـ BranchInstallment
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DrNo of the BranchInstallment
    /// DrNo الخاص بـ BranchInstallment
    /// </summary>
    public decimal? DrNo { get; private set; }

    /// <summary>
    /// ItemPaymentYear of the BranchInstallment
    /// ItemPaymentYear الخاص بـ BranchInstallment
    /// </summary>
    public decimal? ItemPaymentYear { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchInstallment
    /// ExternalPostFlag الخاص بـ BranchInstallment
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// RecordNumber of the BranchInstallment
    /// RecordNumber الخاص بـ BranchInstallment
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the BranchInstallment
    /// DocSequence الخاص بـ BranchInstallment
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// DocDsc of the BranchInstallment
    /// DocDsc الخاص بـ BranchInstallment
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchInstallment
    /// CompanyNumberShort الخاص بـ BranchInstallment
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchInstallment
    /// BranchNumber الخاص بـ BranchInstallment
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchInstallment
    /// BranchYear الخاص بـ BranchInstallment
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchInstallment
    /// BranchUser الخاص بـ BranchInstallment
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    #endregion
}
}
