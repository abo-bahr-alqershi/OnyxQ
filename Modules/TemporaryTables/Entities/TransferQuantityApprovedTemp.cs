using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// TransferQuantityApprovedTemp Entity
/// </summary>
public class TransferQuantityApprovedTemp : Entity<TransferQuantityApprovedTempId>
{
    private TransferQuantityApprovedTemp() { }

    /// <summary>
    /// The unique identifier for the TransferQuantityApprovedTemp
    /// المعرف الفريد لـ TransferQuantityApprovedTemp
    /// </summary>
    public TransferQuantityApprovedTempId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the TransferQuantityApprovedTemp
    /// RecordNumber الخاص بـ TransferQuantityApprovedTemp
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ItemCode of the TransferQuantityApprovedTemp
    /// ItemCode الخاص بـ TransferQuantityApprovedTemp
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// FWarehouseCode of the TransferQuantityApprovedTemp
    /// FWarehouseCode الخاص بـ TransferQuantityApprovedTemp
    /// </summary>
    public decimal? FWarehouseCode { get; private set; }

    /// <summary>
    /// TWarehouseCode of the TransferQuantityApprovedTemp
    /// TWarehouseCode الخاص بـ TransferQuantityApprovedTemp
    /// </summary>
    public decimal? TWarehouseCode { get; private set; }

    /// <summary>
    /// BatchNumber of the TransferQuantityApprovedTemp
    /// BatchNumber الخاص بـ TransferQuantityApprovedTemp
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// Quantity of the TransferQuantityApprovedTemp
    /// Quantity الخاص بـ TransferQuantityApprovedTemp
    /// </summary>
    public decimal? Quantity { get; private set; }

    /// <summary>
    /// DocTypeRef of the TransferQuantityApprovedTemp
    /// DocTypeRef الخاص بـ TransferQuantityApprovedTemp
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the TransferQuantityApprovedTemp
    /// DocNoRef الخاص بـ TransferQuantityApprovedTemp
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the TransferQuantityApprovedTemp
    /// DocSerRef الخاص بـ TransferQuantityApprovedTemp
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// ApprovedFlag of the TransferQuantityApprovedTemp
    /// ApprovedFlag الخاص بـ TransferQuantityApprovedTemp
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the TransferQuantityApprovedTemp
    /// ApprovalUserId الخاص بـ TransferQuantityApprovedTemp
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the TransferQuantityApprovedTemp
    /// ApprovalDate الخاص بـ TransferQuantityApprovedTemp
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the TransferQuantityApprovedTemp
    /// ApprovalDescription الخاص بـ TransferQuantityApprovedTemp
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// DocNo of the TransferQuantityApprovedTemp
    /// DocNo الخاص بـ TransferQuantityApprovedTemp
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the TransferQuantityApprovedTemp
    /// CompanyNumberShort الخاص بـ TransferQuantityApprovedTemp
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the TransferQuantityApprovedTemp
    /// BranchNumber الخاص بـ TransferQuantityApprovedTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the TransferQuantityApprovedTemp
    /// BranchYear الخاص بـ TransferQuantityApprovedTemp
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the TransferQuantityApprovedTemp
    /// BranchUser الخاص بـ TransferQuantityApprovedTemp
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
