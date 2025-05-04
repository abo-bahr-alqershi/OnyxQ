using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.ServicesMaintenance.Entities
{
/// <summary>
/// RepairOrderDetail Entity
/// </summary>
public class RepairOrderDetail : Entity<RepairOrderDetailId>
{
    private readonly List<ItemDetail> _itemDetail = new List<ItemDetail>();
    private readonly List<RepairOrderMaster> _repairOrderMaster = new List<RepairOrderMaster>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();

    private RepairOrderDetail() { }

    public RepairOrderDetail(RepairOrderDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the RepairOrderDetail
    /// المعرف الفريد لـ RepairOrderDetail
    /// </summary>
    public RepairOrderDetailId Id { get; private set; }

    /// <summary>
    /// RegionNumberShort of the RepairOrderDetail
    /// RegionNumberShort الخاص بـ RepairOrderDetail
    /// </summary>
    public decimal? RegionNumberShort { get; private set; }

    /// <summary>
    /// ItemNameFull of the RepairOrderDetail
    /// ItemNameFull الخاص بـ RepairOrderDetail
    /// </summary>
    public string ItemNameFull { get; private set; }

    /// <summary>
    /// PSize of the RepairOrderDetail
    /// PSize الخاص بـ RepairOrderDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemQuantity of the RepairOrderDetail
    /// ItemQuantity الخاص بـ RepairOrderDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// Reason of the RepairOrderDetail
    /// Reason الخاص بـ RepairOrderDetail
    /// </summary>
    public string Reason { get; private set; }

    /// <summary>
    /// PartyName of the RepairOrderDetail
    /// PartyName الخاص بـ RepairOrderDetail
    /// </summary>
    public string PartyName { get; private set; }

    /// <summary>
    /// OutgoingDate of the RepairOrderDetail
    /// OutgoingDate الخاص بـ RepairOrderDetail
    /// </summary>
    public DateTime? OutgoingDate { get; private set; }

    /// <summary>
    /// IncomeDateAlt of the RepairOrderDetail
    /// IncomeDateAlt الخاص بـ RepairOrderDetail
    /// </summary>
    public DateTime? IncomeDateAlt { get; private set; }

    /// <summary>
    /// RecordNumber of the RepairOrderDetail
    /// RecordNumber الخاص بـ RepairOrderDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the RepairOrderDetail
    /// CompanyNumberShort الخاص بـ RepairOrderDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the RepairOrderDetail
    /// BranchNumber الخاص بـ RepairOrderDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the RepairOrderDetail
    /// BranchYear الخاص بـ RepairOrderDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the RepairOrderDetail
    /// BranchUser الخاص بـ RepairOrderDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemDetail> ItemDetail => _itemDetail;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<RepairOrderMaster> RepairOrderMaster => _repairOrderMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Warehouse> Warehouse => _warehouse;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
