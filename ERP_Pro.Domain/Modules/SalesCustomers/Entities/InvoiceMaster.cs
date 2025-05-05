using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// InvoiceMaster Entity
/// </summary>
public class InvoiceMaster : AggregateRoot<InvoiceMasterId>
{

    private InvoiceMaster() { }

    public InvoiceMaster(InvoiceMasterId id, decimal? invoiceSerial)
    {
        Id = id;
        InvoiceSerial = invoiceSerial;
    }

    /// <summary>
    /// The unique identifier for the InvoiceMaster
    /// المعرف الفريد لـ InvoiceMaster
    /// </summary>
    public InvoiceMasterId Id { get; private set; }

    /// <summary>
    /// InvoiceNumber of the InvoiceMaster
    /// InvoiceNumber الخاص بـ InvoiceMaster
    /// </summary>
    public decimal? InvoiceNumber { get; private set; }

    /// <summary>
    /// InvoiceType of the InvoiceMaster
    /// InvoiceType الخاص بـ InvoiceMaster
    /// </summary>
    public decimal? InvoiceType { get; private set; }

    /// <summary>
    /// InvoiceSerial of the InvoiceMaster
    /// InvoiceSerial الخاص بـ InvoiceMaster
    /// </summary>
    public decimal? InvoiceSerial { get; private set; }

    /// <summary>
    /// InvoiceDate of the InvoiceMaster
    /// InvoiceDate الخاص بـ InvoiceMaster
    /// </summary>
    public DateTime? InvoiceDate { get; private set; }

    /// <summary>
    /// InvoiceDescription of the InvoiceMaster
    /// InvoiceDescription الخاص بـ InvoiceMaster
    /// </summary>
    public string InvoiceDescription { get; private set; }

    /// <summary>
    /// ReferenceNumber of the InvoiceMaster
    /// ReferenceNumber الخاص بـ InvoiceMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// AnnualFlag of the InvoiceMaster
    /// AnnualFlag الخاص بـ InvoiceMaster
    /// </summary>
    public decimal? AnnualFlag { get; private set; }

    /// <summary>
    /// UseAttachInvoice of the InvoiceMaster
    /// UseAttachInvoice الخاص بـ InvoiceMaster
    /// </summary>
    public decimal? UseAttachInvoice { get; private set; }

    /// <summary>
    /// InvoiceNumberReference of the InvoiceMaster
    /// InvoiceNumberReference الخاص بـ InvoiceMaster
    /// </summary>
    public decimal? InvoiceNumberReference { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the InvoiceMaster
    /// ExternalPostFlag الخاص بـ InvoiceMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the InvoiceMaster
    /// ProcessedFlagFull الخاص بـ InvoiceMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// MachineNumber of the InvoiceMaster
    /// MachineNumber الخاص بـ InvoiceMaster
    /// </summary>
    public decimal? MachineNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the InvoiceMaster
    /// CompanyNumberShort الخاص بـ InvoiceMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the InvoiceMaster
    /// BranchNumber الخاص بـ InvoiceMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the InvoiceMaster
    /// BranchYear الخاص بـ InvoiceMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the InvoiceMaster
    /// BranchUser الخاص بـ InvoiceMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

