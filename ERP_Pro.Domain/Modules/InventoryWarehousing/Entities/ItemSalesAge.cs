using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemSalesAge Entity
/// </summary>
public class ItemSalesAge : Entity<ItemSalesAgeId>
{

    private ItemSalesAge() { }

    public ItemSalesAge(ItemSalesAgeId id, string itemCode, string itemUnit, decimal? warehouseCode, decimal? docSeqOut, decimal? branchYear)
    {
        Id = id;
        ItemCode = itemCode;
        ItemUnit = itemUnit;
        WarehouseCode = warehouseCode;
        DocSeqOut = docSeqOut;
        BranchYear = branchYear;
    }

    /// <summary>
    /// The unique identifier for the ItemSalesAge
    /// المعرف الفريد لـ ItemSalesAge
    /// </summary>
    public ItemSalesAgeId Id { get; private set; }

    /// <summary>
    /// ItemCode of the ItemSalesAge
    /// ItemCode الخاص بـ ItemSalesAge
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the ItemSalesAge
    /// ItemUnit الخاص بـ ItemSalesAge
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// WarehouseCode of the ItemSalesAge
    /// WarehouseCode الخاص بـ ItemSalesAge
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// LastSaleDate of the ItemSalesAge
    /// LastSaleDate الخاص بـ ItemSalesAge
    /// </summary>
    public DateTime? LastSaleDate { get; private set; }

    /// <summary>
    /// LastOutDate of the ItemSalesAge
    /// LastOutDate الخاص بـ ItemSalesAge
    /// </summary>
    public DateTime? LastOutDate { get; private set; }

    /// <summary>
    /// FirstIncomeDate of the ItemSalesAge
    /// FirstIncomeDate الخاص بـ ItemSalesAge
    /// </summary>
    public DateTime? FirstIncomeDate { get; private set; }

    /// <summary>
    /// DocSerInc of the ItemSalesAge
    /// DocSerInc الخاص بـ ItemSalesAge
    /// </summary>
    public decimal? DocSerInc { get; private set; }

    /// <summary>
    /// DocSeqInc of the ItemSalesAge
    /// DocSeqInc الخاص بـ ItemSalesAge
    /// </summary>
    public decimal? DocSeqInc { get; private set; }

    /// <summary>
    /// DocSerOut of the ItemSalesAge
    /// DocSerOut الخاص بـ ItemSalesAge
    /// </summary>
    public decimal? DocSerOut { get; private set; }

    /// <summary>
    /// DocSeqOut of the ItemSalesAge
    /// DocSeqOut الخاص بـ ItemSalesAge
    /// </summary>
    public decimal? DocSeqOut { get; private set; }

    /// <summary>
    /// DocSerSale of the ItemSalesAge
    /// DocSerSale الخاص بـ ItemSalesAge
    /// </summary>
    public decimal? DocSerSale { get; private set; }

    /// <summary>
    /// DocSeqSale of the ItemSalesAge
    /// DocSeqSale الخاص بـ ItemSalesAge
    /// </summary>
    public decimal? DocSeqSale { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ItemSalesAge
    /// CompanyNumberShort الخاص بـ ItemSalesAge
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ItemSalesAge
    /// BranchNumber الخاص بـ ItemSalesAge
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ItemSalesAge
    /// BranchYear الخاص بـ ItemSalesAge
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ItemSalesAge
    /// BranchUser الخاص بـ ItemSalesAge
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
