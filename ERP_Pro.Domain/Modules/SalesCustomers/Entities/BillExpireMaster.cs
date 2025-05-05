using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// BillExpireMaster Entity
/// </summary>
public class BillExpireMaster : AggregateRoot<BillExpireMasterId>
{

    private BillExpireMaster() { }

    public BillExpireMaster(BillExpireMasterId id, decimal? billSerial)
    {
        Id = id;
        BillSerial = billSerial;
    }

    /// <summary>
    /// The unique identifier for the BillExpireMaster
    /// المعرف الفريد لـ BillExpireMaster
    /// </summary>
    public BillExpireMasterId Id { get; private set; }

    /// <summary>
    /// BillNumber of the BillExpireMaster
    /// BillNumber الخاص بـ BillExpireMaster
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the BillExpireMaster
    /// BillSerial الخاص بـ BillExpireMaster
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// BillDate of the BillExpireMaster
    /// BillDate الخاص بـ BillExpireMaster
    /// </summary>
    public DateTime? BillDate { get; private set; }

    /// <summary>
    /// BillAmount of the BillExpireMaster
    /// BillAmount الخاص بـ BillExpireMaster
    /// </summary>
    public decimal? BillAmount { get; private set; }

    /// <summary>
    /// AccountCurrency of the BillExpireMaster
    /// AccountCurrency الخاص بـ BillExpireMaster
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// GateFlag of the BillExpireMaster
    /// GateFlag الخاص بـ BillExpireMaster
    /// </summary>
    public decimal? GateFlag { get; private set; }

    /// <summary>
    /// AccountDescription of the BillExpireMaster
    /// AccountDescription الخاص بـ BillExpireMaster
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// ReferenceNumber of the BillExpireMaster
    /// ReferenceNumber الخاص بـ BillExpireMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// ReceiveVoucherNumber of the BillExpireMaster
    /// ReceiveVoucherNumber الخاص بـ BillExpireMaster
    /// </summary>
    public decimal? ReceiveVoucherNumber { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the BillExpireMaster
    /// ProcessedFlagFull الخاص بـ BillExpireMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// ApprovedFlag of the BillExpireMaster
    /// ApprovedFlag الخاص بـ BillExpireMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalDate of the BillExpireMaster
    /// ApprovalDate الخاص بـ BillExpireMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalUserId of the BillExpireMaster
    /// ApprovalUserId الخاص بـ BillExpireMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDescription of the BillExpireMaster
    /// ApprovalDescription الخاص بـ BillExpireMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BillExpireMaster
    /// CompanyNumberShort الخاص بـ BillExpireMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BillExpireMaster
    /// BranchNumber الخاص بـ BillExpireMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BillExpireMaster
    /// BranchYear الخاص بـ BillExpireMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BillExpireMaster
    /// BranchUser الخاص بـ BillExpireMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

