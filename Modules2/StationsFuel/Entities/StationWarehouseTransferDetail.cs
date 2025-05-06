using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.StationsFuel.ValueObjects;
namespace ERP_Pro.Domain.ERP.StationsFuel.Entities
{
/// <summary>
/// StationWarehouseTransferDetail Entity
/// </summary>
public class StationWarehouseTransferDetail : Entity<StationWarehouseTransferDetailId>
{

    private StationWarehouseTransferDetail() { }

    public StationWarehouseTransferDetail(StationWarehouseTransferDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the StationWarehouseTransferDetail
    /// المعرف الفريد لـ StationWarehouseTransferDetail
    /// </summary>
    public StationWarehouseTransferDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the StationWarehouseTransferDetail
    /// DocNo الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// TransactionTypeFull of the StationWarehouseTransferDetail
    /// TransactionTypeFull الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public decimal? TransactionTypeFull { get; private set; }

    /// <summary>
    /// FWarehouseCode of the StationWarehouseTransferDetail
    /// FWarehouseCode الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public decimal? FWarehouseCode { get; private set; }

    /// <summary>
    /// TWarehouseCode of the StationWarehouseTransferDetail
    /// TWarehouseCode الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public decimal? TWarehouseCode { get; private set; }

    /// <summary>
    /// TransactionAccountCode of the StationWarehouseTransferDetail
    /// TransactionAccountCode الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public string TransactionAccountCode { get; private set; }

    /// <summary>
    /// ReferenceNumber of the StationWarehouseTransferDetail
    /// ReferenceNumber الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// FuelTypeNumber of the StationWarehouseTransferDetail
    /// FuelTypeNumber الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public decimal? FuelTypeNumber { get; private set; }

    /// <summary>
    /// ItemQuantity of the StationWarehouseTransferDetail
    /// ItemQuantity الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the StationWarehouseTransferDetail
    /// ItemPriceShort الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// StockCost of the StationWarehouseTransferDetail
    /// StockCost الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// DocDscDtl of the StationWarehouseTransferDetail
    /// DocDscDtl الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public string DocDscDtl { get; private set; }

    /// <summary>
    /// ItemCode of the StationWarehouseTransferDetail
    /// ItemCode الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the StationWarehouseTransferDetail
    /// ItemUnit الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the StationWarehouseTransferDetail
    /// PSize الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// BatchNumber of the StationWarehouseTransferDetail
    /// BatchNumber الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// EmpNo of the StationWarehouseTransferDetail
    /// EmpNo الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// CostCenterCode of the StationWarehouseTransferDetail
    /// CostCenterCode الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ActivityNumber of the StationWarehouseTransferDetail
    /// ActivityNumber الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ProjectNumber of the StationWarehouseTransferDetail
    /// ProjectNumber الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// WarehouseCode of the StationWarehouseTransferDetail
    /// WarehouseCode الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CuntrNo of the StationWarehouseTransferDetail
    /// CuntrNo الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public decimal? CuntrNo { get; private set; }

    /// <summary>
    /// RecordNumber of the StationWarehouseTransferDetail
    /// RecordNumber الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the StationWarehouseTransferDetail
    /// CompanyNumberShort الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the StationWarehouseTransferDetail
    /// BranchNumber الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the StationWarehouseTransferDetail
    /// BranchYear الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the StationWarehouseTransferDetail
    /// BranchUser الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ExpenseAccountCode of the StationWarehouseTransferDetail
    /// ExpenseAccountCode الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public string ExpenseAccountCode { get; private set; }

    /// <summary>
    /// TransactionCostType of the StationWarehouseTransferDetail
    /// TransactionCostType الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public decimal? TransactionCostType { get; private set; }

    /// <summary>
    /// DiffACode of the StationWarehouseTransferDetail
    /// DiffACode الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public string DiffACode { get; private set; }

    /// <summary>
    /// TTransactionType of the StationWarehouseTransferDetail
    /// TTransactionType الخاص بـ StationWarehouseTransferDetail
    /// </summary>
    public decimal? TTransactionType { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public StationBillMaster StationBillMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

