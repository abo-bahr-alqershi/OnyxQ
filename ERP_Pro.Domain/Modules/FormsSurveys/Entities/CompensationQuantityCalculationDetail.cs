using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Entities
{
/// <summary>
/// CompensationQuantityCalculationDetail Entity
/// </summary>
public class CompensationQuantityCalculationDetail : Entity<CompensationQuantityCalculationDetailId>
{
    private readonly List<ItemMaster> _itemMaster = new List<ItemMaster>();
    private readonly List<CompensationQuantityCalculationMaster> _compensationQuantityCalculationMaster = new List<CompensationQuantityCalculationMaster>();

    private CompensationQuantityCalculationDetail() { }

    public CompensationQuantityCalculationDetail(CompensationQuantityCalculationDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the CompensationQuantityCalculationDetail
    /// المعرف الفريد لـ CompensationQuantityCalculationDetail
    /// </summary>
    public CompensationQuantityCalculationDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the CompensationQuantityCalculationDetail
    /// DocNo الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// ItemUnit of the CompensationQuantityCalculationDetail
    /// ItemUnit الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the CompensationQuantityCalculationDetail
    /// PSize الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemType of the CompensationQuantityCalculationDetail
    /// ItemType الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public decimal? ItemType { get; private set; }

    /// <summary>
    /// ActivityNumber of the CompensationQuantityCalculationDetail
    /// ActivityNumber الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public decimal? ActivityNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the CompensationQuantityCalculationDetail
    /// CostCenterCode الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ActivityNumber of the CompensationQuantityCalculationDetail
    /// ActivityNumber الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ProjectNumber of the CompensationQuantityCalculationDetail
    /// ProjectNumber الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// BranchNumber of the CompensationQuantityCalculationDetail
    /// BranchNumber الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// WarehouseCode of the CompensationQuantityCalculationDetail
    /// WarehouseCode الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CompensationQuantity of the CompensationQuantityCalculationDetail
    /// CompensationQuantity الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public decimal? CompensationQuantity { get; private set; }

    /// <summary>
    /// CompensationDescription of the CompensationQuantityCalculationDetail
    /// CompensationDescription الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public string CompensationDescription { get; private set; }

    /// <summary>
    /// CompensationPercent of the CompensationQuantityCalculationDetail
    /// CompensationPercent الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public decimal? CompensationPercent { get; private set; }

    /// <summary>
    /// NetSalesAmount of the CompensationQuantityCalculationDetail
    /// NetSalesAmount الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public decimal? NetSalesAmount { get; private set; }

    /// <summary>
    /// NetSalesQuantity of the CompensationQuantityCalculationDetail
    /// NetSalesQuantity الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public decimal? NetSalesQuantity { get; private set; }

    /// <summary>
    /// RecordNumber of the CompensationQuantityCalculationDetail
    /// RecordNumber الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSeq of the CompensationQuantityCalculationDetail
    /// DocSeq الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public decimal? DocSeq { get; private set; }

    /// <summary>
    /// GuarantorCode of the CompensationQuantityCalculationDetail
    /// GuarantorCode الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// BillNumber of the CompensationQuantityCalculationDetail
    /// BillNumber الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the CompensationQuantityCalculationDetail
    /// BillSerial الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// ColumnAmount of the CompensationQuantityCalculationDetail
    /// ColumnAmount الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public decimal? ColumnAmount { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the CompensationQuantityCalculationDetail
    /// BillDocumentTypeFull الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// PrivilegeQuantity of the CompensationQuantityCalculationDetail
    /// PrivilegeQuantity الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public decimal? PrivilegeQuantity { get; private set; }

    /// <summary>
    /// ExpireDate of the CompensationQuantityCalculationDetail
    /// ExpireDate الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the CompensationQuantityCalculationDetail
    /// BatchNumber الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// ItemPriceShort of the CompensationQuantityCalculationDetail
    /// ItemPriceShort الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// StockCost of the CompensationQuantityCalculationDetail
    /// StockCost الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// DocSequence of the CompensationQuantityCalculationDetail
    /// DocSequence الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CompensationQuantityCalculationDetail
    /// CompanyNumberShort الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchYear of the CompensationQuantityCalculationDetail
    /// BranchYear الخاص بـ CompensationQuantityCalculationDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CompensationQuantityCalculationDetail
    /// BranchUser الخاص بـ CompensationQuantityCalculationDetail
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
    public ICollection<CompensationQuantityCalculationMaster> CompensationQuantityCalculationMaster => _compensationQuantityCalculationMaster;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
