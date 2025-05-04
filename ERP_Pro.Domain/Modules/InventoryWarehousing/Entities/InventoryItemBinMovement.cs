using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// InventoryItemBinMovement Entity
/// </summary>
public class InventoryItemBinMovement : Entity<InventoryItemBinMovementId>
{
    private readonly List<ItemMaster> _itemMaster = new List<ItemMaster>();
    private readonly List<BinDetail> _binDetail = new List<BinDetail>();

    private InventoryItemBinMovement() { }

    public InventoryItemBinMovement(InventoryItemBinMovementId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the InventoryItemBinMovement
    /// المعرف الفريد لـ InventoryItemBinMovement
    /// </summary>
    public InventoryItemBinMovementId Id { get; private set; }

    /// <summary>
    /// DocNo of the InventoryItemBinMovement
    /// DocNo الخاص بـ InventoryItemBinMovement
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the InventoryItemBinMovement
    /// DocSer الخاص بـ InventoryItemBinMovement
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the InventoryItemBinMovement
    /// DocDate الخاص بـ InventoryItemBinMovement
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// ItemUnit of the InventoryItemBinMovement
    /// ItemUnit الخاص بـ InventoryItemBinMovement
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the InventoryItemBinMovement
    /// PSize الخاص بـ InventoryItemBinMovement
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the InventoryItemBinMovement
    /// PQuantity الخاص بـ InventoryItemBinMovement
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ExpireDate of the InventoryItemBinMovement
    /// ExpireDate الخاص بـ InventoryItemBinMovement
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the InventoryItemBinMovement
    /// BatchNumber الخاص بـ InventoryItemBinMovement
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// ItemQuantity of the InventoryItemBinMovement
    /// ItemQuantity الخاص بـ InventoryItemBinMovement
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// Barcode of the InventoryItemBinMovement
    /// Barcode الخاص بـ InventoryItemBinMovement
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// InOutFlag of the InventoryItemBinMovement
    /// InOutFlag الخاص بـ InventoryItemBinMovement
    /// </summary>
    public decimal? InOutFlag { get; private set; }

    /// <summary>
    /// DocNoRef of the InventoryItemBinMovement
    /// DocNoRef الخاص بـ InventoryItemBinMovement
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the InventoryItemBinMovement
    /// DocSerRef الخاص بـ InventoryItemBinMovement
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocTypeRef of the InventoryItemBinMovement
    /// DocTypeRef الخاص بـ InventoryItemBinMovement
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the InventoryItemBinMovement
    /// ExternalPostFlag الخاص بـ InventoryItemBinMovement
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// PriceTypeShort of the InventoryItemBinMovement
    /// PriceTypeShort الخاص بـ InventoryItemBinMovement
    /// </summary>
    public decimal? PriceTypeShort { get; private set; }

    /// <summary>
    /// DocSequence of the InventoryItemBinMovement
    /// DocSequence الخاص بـ InventoryItemBinMovement
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// BranchNumber of the InventoryItemBinMovement
    /// BranchNumber الخاص بـ InventoryItemBinMovement
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// RecordNumberDocument of the InventoryItemBinMovement
    /// RecordNumberDocument الخاص بـ InventoryItemBinMovement
    /// </summary>
    public decimal? RecordNumberDocument { get; private set; }

    /// <summary>
    /// RecordNumber of the InventoryItemBinMovement
    /// RecordNumber الخاص بـ InventoryItemBinMovement
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// TypeNumberShort of the InventoryItemBinMovement
    /// TypeNumberShort الخاص بـ InventoryItemBinMovement
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// MoveTypeFull of the InventoryItemBinMovement
    /// MoveTypeFull الخاص بـ InventoryItemBinMovement
    /// </summary>
    public decimal? MoveTypeFull { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemMaster> ItemMaster => _itemMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<BinDetail> BinDetail => _binDetail;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
