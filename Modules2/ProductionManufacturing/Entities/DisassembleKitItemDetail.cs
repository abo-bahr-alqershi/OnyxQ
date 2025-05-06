using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

using ERP_Pro.Domain.ERP.ProductionManufacturing.ValueObjects;
namespace ERP_Pro.Domain.ERP.ProductionManufacturing.Entities
{
/// <summary>
/// DisassembleKitItemDetail Entity
/// </summary>
public class DisassembleKitItemDetail : Entity<DisassembleKitItemDetailId>
{

    private DisassembleKitItemDetail() { }

    public DisassembleKitItemDetail(DisassembleKitItemDetailId id, string kitItemNumber, string itemUnit, decimal? recordNumber)
    {
        Id = id;
        KitItemNumber = kitItemNumber;
        ItemUnit = itemUnit;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// The unique identifier for the DisassembleKitItemDetail
    /// المعرف الفريد لـ DisassembleKitItemDetail
    /// </summary>
    public DisassembleKitItemDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the DisassembleKitItemDetail
    /// DocNo الخاص بـ DisassembleKitItemDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// AssetDocumentNumber of the DisassembleKitItemDetail
    /// AssetDocumentNumber الخاص بـ DisassembleKitItemDetail
    /// </summary>
    public decimal? AssetDocumentNumber { get; private set; }

    /// <summary>
    /// AssetDocumentSerial of the DisassembleKitItemDetail
    /// AssetDocumentSerial الخاص بـ DisassembleKitItemDetail
    /// </summary>
    public decimal? AssetDocumentSerial { get; private set; }

    /// <summary>
    /// KitItemNumber of the DisassembleKitItemDetail
    /// KitItemNumber الخاص بـ DisassembleKitItemDetail
    /// </summary>
    public string KitItemNumber { get; private set; }

    /// <summary>
    /// ItemUnit of the DisassembleKitItemDetail
    /// ItemUnit الخاص بـ DisassembleKitItemDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the DisassembleKitItemDetail
    /// PSize الخاص بـ DisassembleKitItemDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemQuantity of the DisassembleKitItemDetail
    /// ItemQuantity الخاص بـ DisassembleKitItemDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// FWarehouseCode of the DisassembleKitItemDetail
    /// FWarehouseCode الخاص بـ DisassembleKitItemDetail
    /// </summary>
    public decimal? FWarehouseCode { get; private set; }

    /// <summary>
    /// TWarehouseCode of the DisassembleKitItemDetail
    /// TWarehouseCode الخاص بـ DisassembleKitItemDetail
    /// </summary>
    public decimal? TWarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the DisassembleKitItemDetail
    /// CostCenterCode الخاص بـ DisassembleKitItemDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// KitCost of the DisassembleKitItemDetail
    /// KitCost الخاص بـ DisassembleKitItemDetail
    /// </summary>
    public decimal? KitCost { get; private set; }

    /// <summary>
    /// RecordNumber of the DisassembleKitItemDetail
    /// RecordNumber الخاص بـ DisassembleKitItemDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the DisassembleKitItemDetail
    /// DocSequence الخاص بـ DisassembleKitItemDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// PostCode of the DisassembleKitItemDetail
    /// PostCode الخاص بـ DisassembleKitItemDetail
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// ExpireDate of the DisassembleKitItemDetail
    /// ExpireDate الخاص بـ DisassembleKitItemDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the DisassembleKitItemDetail
    /// BatchNumber الخاص بـ DisassembleKitItemDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the DisassembleKitItemDetail
    /// CompanyNumberShort الخاص بـ DisassembleKitItemDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the DisassembleKitItemDetail
    /// BranchNumber الخاص بـ DisassembleKitItemDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the DisassembleKitItemDetail
    /// BranchYear الخاص بـ DisassembleKitItemDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the DisassembleKitItemDetail
    /// BranchUser الخاص بـ DisassembleKitItemDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// DocSequenceRef of the DisassembleKitItemDetail
    /// DocSequenceRef الخاص بـ DisassembleKitItemDetail
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// DocSequenceM of the DisassembleKitItemDetail
    /// DocSequenceM الخاص بـ DisassembleKitItemDetail
    /// </summary>
    public decimal? DocSequenceM { get; private set; }

    /// <summary>
    /// RecordSequence of the DisassembleKitItemDetail
    /// RecordSequence الخاص بـ DisassembleKitItemDetail
    /// </summary>
    public decimal? RecordSequence { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public DisassembleKitItem DisassembleKitItem { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Project Project { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

