using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// InventoryMachineMaster Entity
/// </summary>
public class InventoryMachineMaster : Entity<InventoryMachineMasterId>
{

    private InventoryMachineMaster() { }

    public InventoryMachineMaster(InventoryMachineMasterId id, decimal? invoiceSerial)
    {
        Id = id;
        InvoiceSerial = invoiceSerial;
    }

    /// <summary>
    /// The unique identifier for the InventoryMachineMaster
    /// المعرف الفريد لـ InventoryMachineMaster
    /// </summary>
    public InventoryMachineMasterId Id { get; private set; }

    /// <summary>
    /// InvoiceNumber of the InventoryMachineMaster
    /// InvoiceNumber الخاص بـ InventoryMachineMaster
    /// </summary>
    public decimal? InvoiceNumber { get; private set; }

    /// <summary>
    /// InvoiceType of the InventoryMachineMaster
    /// InvoiceType الخاص بـ InventoryMachineMaster
    /// </summary>
    public decimal? InvoiceType { get; private set; }

    /// <summary>
    /// InvoiceSerial of the InventoryMachineMaster
    /// InvoiceSerial الخاص بـ InventoryMachineMaster
    /// </summary>
    public decimal? InvoiceSerial { get; private set; }

    /// <summary>
    /// InvoiceDate of the InventoryMachineMaster
    /// InvoiceDate الخاص بـ InventoryMachineMaster
    /// </summary>
    public DateTime? InvoiceDate { get; private set; }

    /// <summary>
    /// InvoiceDescription of the InventoryMachineMaster
    /// InvoiceDescription الخاص بـ InventoryMachineMaster
    /// </summary>
    public string InvoiceDescription { get; private set; }

    /// <summary>
    /// ReferenceNumber of the InventoryMachineMaster
    /// ReferenceNumber الخاص بـ InventoryMachineMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// AnnualFlag of the InventoryMachineMaster
    /// AnnualFlag الخاص بـ InventoryMachineMaster
    /// </summary>
    public decimal? AnnualFlag { get; private set; }

    /// <summary>
    /// UseAttachInvoice of the InventoryMachineMaster
    /// UseAttachInvoice الخاص بـ InventoryMachineMaster
    /// </summary>
    public decimal? UseAttachInvoice { get; private set; }

    /// <summary>
    /// DocTypeRef of the InventoryMachineMaster
    /// DocTypeRef الخاص بـ InventoryMachineMaster
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the InventoryMachineMaster
    /// DocNoRef الخاص بـ InventoryMachineMaster
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the InventoryMachineMaster
    /// DocSerRef الخاص بـ InventoryMachineMaster
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the InventoryMachineMaster
    /// CompanyNumberShort الخاص بـ InventoryMachineMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the InventoryMachineMaster
    /// BranchNumber الخاص بـ InventoryMachineMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the InventoryMachineMaster
    /// BranchYear الخاص بـ InventoryMachineMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the InventoryMachineMaster
    /// BranchUser الخاص بـ InventoryMachineMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// InvoiceNumberReference of the InventoryMachineMaster
    /// InvoiceNumberReference الخاص بـ InventoryMachineMaster
    /// </summary>
    public decimal? InvoiceNumberReference { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the InventoryMachineMaster
    /// ExternalPostFlag الخاص بـ InventoryMachineMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the InventoryMachineMaster
    /// ProcessedFlagFull الخاص بـ InventoryMachineMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// MachineNumber of the InventoryMachineMaster
    /// MachineNumber الخاص بـ InventoryMachineMaster
    /// </summary>
    public decimal? MachineNumber { get; private set; }

    /// <summary>
    /// MachineName of the InventoryMachineMaster
    /// MachineName الخاص بـ InventoryMachineMaster
    /// </summary>
    public string MachineName { get; private set; }

    /// <summary>
    /// InvoiceSubItems of the InventoryMachineMaster
    /// InvoiceSubItems الخاص بـ InventoryMachineMaster
    /// </summary>
    public decimal? InvoiceSubItems { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
