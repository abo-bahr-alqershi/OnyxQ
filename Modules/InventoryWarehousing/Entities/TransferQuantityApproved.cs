using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// TransferQuantityApproved Entity
/// </summary>
public class TransferQuantityApproved : Entity<TransferQuantityApprovedId>
{
    private TransferQuantityApproved() { }

    /// <summary>
    /// The unique identifier for the TransferQuantityApproved
    /// المعرف الفريد لـ TransferQuantityApproved
    /// </summary>
    public TransferQuantityApprovedId Id { get; private set; }

    /// <summary>
    /// DocNo of the TransferQuantityApproved
    /// DocNo الخاص بـ TransferQuantityApproved
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocDate of the TransferQuantityApproved
    /// DocDate الخاص بـ TransferQuantityApproved
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// RecordNumber of the TransferQuantityApproved
    /// RecordNumber الخاص بـ TransferQuantityApproved
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ItemCode of the TransferQuantityApproved
    /// ItemCode الخاص بـ TransferQuantityApproved
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the TransferQuantityApproved
    /// ItemUnit الخاص بـ TransferQuantityApproved
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the TransferQuantityApproved
    /// PSize الخاص بـ TransferQuantityApproved
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// FWarehouseCode of the TransferQuantityApproved
    /// FWarehouseCode الخاص بـ TransferQuantityApproved
    /// </summary>
    public decimal? FWarehouseCode { get; private set; }

    /// <summary>
    /// TWarehouseCode of the TransferQuantityApproved
    /// TWarehouseCode الخاص بـ TransferQuantityApproved
    /// </summary>
    public decimal? TWarehouseCode { get; private set; }

    /// <summary>
    /// BatchNumber of the TransferQuantityApproved
    /// BatchNumber الخاص بـ TransferQuantityApproved
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// Quantity of the TransferQuantityApproved
    /// Quantity الخاص بـ TransferQuantityApproved
    /// </summary>
    public decimal? Quantity { get; private set; }

    /// <summary>
    /// PQuantity of the TransferQuantityApproved
    /// PQuantity الخاص بـ TransferQuantityApproved
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// DocTypeRef of the TransferQuantityApproved
    /// DocTypeRef الخاص بـ TransferQuantityApproved
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the TransferQuantityApproved
    /// DocNoRef الخاص بـ TransferQuantityApproved
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the TransferQuantityApproved
    /// DocSerRef الخاص بـ TransferQuantityApproved
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// ApprovedFlag of the TransferQuantityApproved
    /// ApprovedFlag الخاص بـ TransferQuantityApproved
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the TransferQuantityApproved
    /// ApprovalUserId الخاص بـ TransferQuantityApproved
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the TransferQuantityApproved
    /// ApprovalDate الخاص بـ TransferQuantityApproved
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the TransferQuantityApproved
    /// ApprovalDescription الخاص بـ TransferQuantityApproved
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the TransferQuantityApproved
    /// ProcessedFlagFull الخاص بـ TransferQuantityApproved
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the TransferQuantityApproved
    /// CompanyNumberShort الخاص بـ TransferQuantityApproved
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the TransferQuantityApproved
    /// BranchNumber الخاص بـ TransferQuantityApproved
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the TransferQuantityApproved
    /// BranchYear الخاص بـ TransferQuantityApproved
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the TransferQuantityApproved
    /// BranchUser الخاص بـ TransferQuantityApproved
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
