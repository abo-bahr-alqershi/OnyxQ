using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// InstallmentPerformaInvoice Entity
/// </summary>
public class InstallmentPerformaInvoice : Entity<InstallmentPerformaInvoiceId>
{

    private InstallmentPerformaInvoice() { }

    public InstallmentPerformaInvoice(InstallmentPerformaInvoiceId id, decimal? billSerial, decimal? itemNumber, string vendorCode, decimal? itemPaymentYear, decimal? recordNumber)
    {
        Id = id;
        BillSerial = billSerial;
        ItemNumber = itemNumber;
        VendorCode = vendorCode;
        ItemPaymentYear = itemPaymentYear;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// The unique identifier for the InstallmentPerformaInvoice
    /// المعرف الفريد لـ InstallmentPerformaInvoice
    /// </summary>
    public InstallmentPerformaInvoiceId Id { get; private set; }

    /// <summary>
    /// DocType of the InstallmentPerformaInvoice
    /// DocType الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// DocDate of the InstallmentPerformaInvoice
    /// DocDate الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the InstallmentPerformaInvoice
    /// BillDocumentTypeFull الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillNumber of the InstallmentPerformaInvoice
    /// BillNumber الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the InstallmentPerformaInvoice
    /// BillSerial الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// ItemNumber of the InstallmentPerformaInvoice
    /// ItemNumber الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public decimal? ItemNumber { get; private set; }

    /// <summary>
    /// ItemDate of the InstallmentPerformaInvoice
    /// ItemDate الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public DateTime? ItemDate { get; private set; }

    /// <summary>
    /// InvoiceAmount of the InstallmentPerformaInvoice
    /// InvoiceAmount الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public decimal? InvoiceAmount { get; private set; }

    /// <summary>
    /// AccountRate of the InstallmentPerformaInvoice
    /// AccountRate الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// ChequeNumber of the InstallmentPerformaInvoice
    /// ChequeNumber الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// ChequeDueDate of the InstallmentPerformaInvoice
    /// ChequeDueDate الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public DateTime? ChequeDueDate { get; private set; }

    /// <summary>
    /// CostCenterCode of the InstallmentPerformaInvoice
    /// CostCenterCode الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the InstallmentPerformaInvoice
    /// ProjectNumber الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// VendorCode of the InstallmentPerformaInvoice
    /// VendorCode الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the InstallmentPerformaInvoice
    /// AccountCurrency الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// PaidAmount of the InstallmentPerformaInvoice
    /// PaidAmount الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public decimal? PaidAmount { get; private set; }

    /// <summary>
    /// PaidDate of the InstallmentPerformaInvoice
    /// PaidDate الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public DateTime? PaidDate { get; private set; }

    /// <summary>
    /// AdjustmentAmount of the InstallmentPerformaInvoice
    /// AdjustmentAmount الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public decimal? AdjustmentAmount { get; private set; }

    /// <summary>
    /// ReferenceNumber of the InstallmentPerformaInvoice
    /// ReferenceNumber الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DrNo of the InstallmentPerformaInvoice
    /// DrNo الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public decimal? DrNo { get; private set; }

    /// <summary>
    /// ItemPaymentYear of the InstallmentPerformaInvoice
    /// ItemPaymentYear الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public decimal? ItemPaymentYear { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the InstallmentPerformaInvoice
    /// ExternalPostFlag الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// RecordNumber of the InstallmentPerformaInvoice
    /// RecordNumber الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the InstallmentPerformaInvoice
    /// DocSequence الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the InstallmentPerformaInvoice
    /// CompanyNumberShort الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the InstallmentPerformaInvoice
    /// BranchNumber الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the InstallmentPerformaInvoice
    /// BranchYear الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the InstallmentPerformaInvoice
    /// BranchUser الخاص بـ InstallmentPerformaInvoice
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// DocDsc of the InstallmentPerformaInvoice
    /// DocDsc الخاص بـ InstallmentPerformaInvoice
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

