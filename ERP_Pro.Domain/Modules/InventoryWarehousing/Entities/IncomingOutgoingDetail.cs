using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// IncomingOutgoingDetail Entity
/// </summary>
public class IncomingOutgoingDetail : Entity<IncomingOutgoingDetailId>
{
    private readonly List<IncomingOutgoingMaster> _incomingOutgoingMaster = new List<IncomingOutgoingMaster>();
    private readonly List<ItemDetail> _itemDetail = new List<ItemDetail>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();

    private IncomingOutgoingDetail() { }

    public IncomingOutgoingDetail(IncomingOutgoingDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the IncomingOutgoingDetail
    /// المعرف الفريد لـ IncomingOutgoingDetail
    /// </summary>
    public IncomingOutgoingDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the IncomingOutgoingDetail
    /// DocNo الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocType of the IncomingOutgoingDetail
    /// DocType الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// ItemQuantity of the IncomingOutgoingDetail
    /// ItemQuantity الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PSize of the IncomingOutgoingDetail
    /// PSize الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the IncomingOutgoingDetail
    /// PQuantity الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the IncomingOutgoingDetail
    /// ItemPriceShort الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// StockCost of the IncomingOutgoingDetail
    /// StockCost الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// ExpireDate of the IncomingOutgoingDetail
    /// ExpireDate الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the IncomingOutgoingDetail
    /// BatchNumber الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// ExpenseAmount of the IncomingOutgoingDetail
    /// ExpenseAmount الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? ExpenseAmount { get; private set; }

    /// <summary>
    /// UseSerialNumber of the IncomingOutgoingDetail
    /// UseSerialNumber الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the IncomingOutgoingDetail
    /// RecordNumber الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the IncomingOutgoingDetail
    /// DocSequence الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// ItemDescription of the IncomingOutgoingDetail
    /// ItemDescription الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// UseAttachment of the IncomingOutgoingDetail
    /// UseAttachment الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the IncomingOutgoingDetail
    /// ReceiveAttachment الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// IncomeNumber of the IncomingOutgoingDetail
    /// IncomeNumber الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? IncomeNumber { get; private set; }

    /// <summary>
    /// FreeQuantity of the IncomingOutgoingDetail
    /// FreeQuantity الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// AllowFreeQuantity of the IncomingOutgoingDetail
    /// AllowFreeQuantity الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? AllowFreeQuantity { get; private set; }

    /// <summary>
    /// UseQuantityForce of the IncomingOutgoingDetail
    /// UseQuantityForce الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? UseQuantityForce { get; private set; }

    /// <summary>
    /// OutgoingQuantity of the IncomingOutgoingDetail
    /// OutgoingQuantity الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? OutgoingQuantity { get; private set; }

    /// <summary>
    /// OutgoingFreeQuantity of the IncomingOutgoingDetail
    /// OutgoingFreeQuantity الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? OutgoingFreeQuantity { get; private set; }

    /// <summary>
    /// ReturnQuantityAlt of the IncomingOutgoingDetail
    /// ReturnQuantityAlt الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? ReturnQuantityAlt { get; private set; }

    /// <summary>
    /// ReturnFreeQuantityAlt of the IncomingOutgoingDetail
    /// ReturnFreeQuantityAlt الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? ReturnFreeQuantityAlt { get; private set; }

    /// <summary>
    /// DocTypeRef of the IncomingOutgoingDetail
    /// DocTypeRef الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocJvTypeRef of the IncomingOutgoingDetail
    /// DocJvTypeRef الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? DocJvTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the IncomingOutgoingDetail
    /// DocNoRef الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the IncomingOutgoingDetail
    /// DocSerRef الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// ItemLength of the IncomingOutgoingDetail
    /// ItemLength الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the IncomingOutgoingDetail
    /// ItemWidth الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the IncomingOutgoingDetail
    /// ItemHeightShort الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the IncomingOutgoingDetail
    /// ItemNumberShort الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// WeightedQuantity of the IncomingOutgoingDetail
    /// WeightedQuantity الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the IncomingOutgoingDetail
    /// WeightedUnit الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// ArgumentNumber of the IncomingOutgoingDetail
    /// ArgumentNumber الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// BranchNumber of the IncomingOutgoingDetail
    /// BranchNumber الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the IncomingOutgoingDetail
    /// BranchYear الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the IncomingOutgoingDetail
    /// CompanyNumberShort الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchUser of the IncomingOutgoingDetail
    /// BranchUser الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// RecordNumberReference of the IncomingOutgoingDetail
    /// RecordNumberReference الخاص بـ IncomingOutgoingDetail
    /// </summary>
    public decimal? RecordNumberReference { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<IncomingOutgoingMaster> IncomingOutgoingMaster => _incomingOutgoingMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemDetail> ItemDetail => _itemDetail;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CostCenter> CostCenter => _costCenter;
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
