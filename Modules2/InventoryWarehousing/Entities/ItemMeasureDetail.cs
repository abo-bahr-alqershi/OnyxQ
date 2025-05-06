using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemMeasureDetail Entity
/// </summary>
public class ItemMeasureDetail : Entity<ItemMeasureDetailId>
{

    private ItemMeasureDetail() { }

    public ItemMeasureDetail(ItemMeasureDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the ItemMeasureDetail
    /// المعرف الفريد لـ ItemMeasureDetail
    /// </summary>
    public ItemMeasureDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the ItemMeasureDetail
    /// DocNo الخاص بـ ItemMeasureDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// ItemCode of the ItemMeasureDetail
    /// ItemCode الخاص بـ ItemMeasureDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the ItemMeasureDetail
    /// ItemUnit الخاص بـ ItemMeasureDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the ItemMeasureDetail
    /// PSize الخاص بـ ItemMeasureDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemLevelNumber of the ItemMeasureDetail
    /// ItemLevelNumber الخاص بـ ItemMeasureDetail
    /// </summary>
    public decimal? ItemLevelNumber { get; private set; }

    /// <summary>
    /// ItemRatio of the ItemMeasureDetail
    /// ItemRatio الخاص بـ ItemMeasureDetail
    /// </summary>
    public decimal? ItemRatio { get; private set; }

    /// <summary>
    /// ItemRatioDegree of the ItemMeasureDetail
    /// ItemRatioDegree الخاص بـ ItemMeasureDetail
    /// </summary>
    public decimal? ItemRatioDegree { get; private set; }

    /// <summary>
    /// ProfitMarginRate of the ItemMeasureDetail
    /// ProfitMarginRate الخاص بـ ItemMeasureDetail
    /// </summary>
    public decimal? ProfitMarginRate { get; private set; }

    /// <summary>
    /// ProfitMarginRateDegree of the ItemMeasureDetail
    /// ProfitMarginRateDegree الخاص بـ ItemMeasureDetail
    /// </summary>
    public decimal? ProfitMarginRateDegree { get; private set; }

    /// <summary>
    /// DailySalesRate of the ItemMeasureDetail
    /// DailySalesRate الخاص بـ ItemMeasureDetail
    /// </summary>
    public decimal? DailySalesRate { get; private set; }

    /// <summary>
    /// DailySalesRateDeg of the ItemMeasureDetail
    /// DailySalesRateDeg الخاص بـ ItemMeasureDetail
    /// </summary>
    public decimal? DailySalesRateDeg { get; private set; }

    /// <summary>
    /// GeneralSalesRate of the ItemMeasureDetail
    /// GeneralSalesRate الخاص بـ ItemMeasureDetail
    /// </summary>
    public decimal? GeneralSalesRate { get; private set; }

    /// <summary>
    /// GeneralSalesRateDegree of the ItemMeasureDetail
    /// GeneralSalesRateDegree الخاص بـ ItemMeasureDetail
    /// </summary>
    public decimal? GeneralSalesRateDegree { get; private set; }

    /// <summary>
    /// NetSalesQuantity of the ItemMeasureDetail
    /// NetSalesQuantity الخاص بـ ItemMeasureDetail
    /// </summary>
    public decimal? NetSalesQuantity { get; private set; }

    /// <summary>
    /// NetSalesQuantityDegree of the ItemMeasureDetail
    /// NetSalesQuantityDegree الخاص بـ ItemMeasureDetail
    /// </summary>
    public decimal? NetSalesQuantityDegree { get; private set; }

    /// <summary>
    /// NetSalesAmount of the ItemMeasureDetail
    /// NetSalesAmount الخاص بـ ItemMeasureDetail
    /// </summary>
    public decimal? NetSalesAmount { get; private set; }

    /// <summary>
    /// NetSalesAmountDegree of the ItemMeasureDetail
    /// NetSalesAmountDegree الخاص بـ ItemMeasureDetail
    /// </summary>
    public decimal? NetSalesAmountDegree { get; private set; }

    /// <summary>
    /// SaleRateForeignIncome of the ItemMeasureDetail
    /// SaleRateForeignIncome الخاص بـ ItemMeasureDetail
    /// </summary>
    public decimal? SaleRateForeignIncome { get; private set; }

    /// <summary>
    /// SaleRateForeignIncomeDegree of the ItemMeasureDetail
    /// SaleRateForeignIncomeDegree الخاص بـ ItemMeasureDetail
    /// </summary>
    public decimal? SaleRateForeignIncomeDegree { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemMeasureMaster ItemMeasureMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

