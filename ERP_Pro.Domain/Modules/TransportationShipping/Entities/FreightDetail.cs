using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.TransportationShipping.Entities
{
/// <summary>
/// FreightDetail Entity
/// </summary>
public class FreightDetail : Entity<FreightDetailId>
{
    private readonly List<ItemMaster> _itemMaster = new List<ItemMaster>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();
    private readonly List<FreightMaster> _freightMaster = new List<FreightMaster>();

    private FreightDetail() { }

    public FreightDetail(FreightDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the FreightDetail
    /// المعرف الفريد لـ FreightDetail
    /// </summary>
    public FreightDetailId Id { get; private set; }

    /// <summary>
    /// FreightNumber of the FreightDetail
    /// FreightNumber الخاص بـ FreightDetail
    /// </summary>
    public string FreightNumber { get; private set; }

    /// <summary>
    /// PurchaseOrderType of the FreightDetail
    /// PurchaseOrderType الخاص بـ FreightDetail
    /// </summary>
    public decimal? PurchaseOrderType { get; private set; }

    /// <summary>
    /// PurchaseOrderNumber of the FreightDetail
    /// PurchaseOrderNumber الخاص بـ FreightDetail
    /// </summary>
    public decimal? PurchaseOrderNumber { get; private set; }

    /// <summary>
    /// PurchaseOrderSerial of the FreightDetail
    /// PurchaseOrderSerial الخاص بـ FreightDetail
    /// </summary>
    public decimal? PurchaseOrderSerial { get; private set; }

    /// <summary>
    /// ItemQuantity of the FreightDetail
    /// ItemQuantity الخاص بـ FreightDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// ItemUnit of the FreightDetail
    /// ItemUnit الخاص بـ FreightDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the FreightDetail
    /// PSize الخاص بـ FreightDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the FreightDetail
    /// PQuantity الخاص بـ FreightDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the FreightDetail
    /// ItemPriceShort الخاص بـ FreightDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// RecordNumber of the FreightDetail
    /// RecordNumber الخاص بـ FreightDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ItemDescription of the FreightDetail
    /// ItemDescription الخاص بـ FreightDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// DocSequenceRef of the FreightDetail
    /// DocSequenceRef الخاص بـ FreightDetail
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// DocSequence of the FreightDetail
    /// DocSequence الخاص بـ FreightDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// FreeQuantity of the FreightDetail
    /// FreeQuantity الخاص بـ FreightDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// ContainerNumber of the FreightDetail
    /// ContainerNumber الخاص بـ FreightDetail
    /// </summary>
    public string ContainerNumber { get; private set; }

    /// <summary>
    /// ContainerAmountDetail of the FreightDetail
    /// ContainerAmountDetail الخاص بـ FreightDetail
    /// </summary>
    public decimal? ContainerAmountDetail { get; private set; }

    /// <summary>
    /// DocNo of the FreightDetail
    /// DocNo الخاص بـ FreightDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the FreightDetail
    /// DocSer الخاص بـ FreightDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// ContainerCapacity of the FreightDetail
    /// ContainerCapacity الخاص بـ FreightDetail
    /// </summary>
    public decimal? ContainerCapacity { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the FreightDetail
    /// CompanyNumberShort الخاص بـ FreightDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the FreightDetail
    /// BranchNumber الخاص بـ FreightDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the FreightDetail
    /// BranchYear الخاص بـ FreightDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the FreightDetail
    /// BranchUser الخاص بـ FreightDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemMaster> ItemMaster => _itemMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Warehouse> Warehouse => _warehouse;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<FreightMaster> FreightMaster => _freightMaster;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
