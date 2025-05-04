using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// InventoryManagementTemp Entity
/// </summary>
public class InventoryManagementTemp : Entity<InventoryManagementTempId>
{

    private InventoryManagementTemp() { }

    public InventoryManagementTemp(InventoryManagementTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the InventoryManagementTemp
    /// المعرف الفريد لـ InventoryManagementTemp
    /// </summary>
    public InventoryManagementTempId Id { get; private set; }

    /// <summary>
    /// ItemCode of the InventoryManagementTemp
    /// ItemCode الخاص بـ InventoryManagementTemp
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemNameFull of the InventoryManagementTemp
    /// ItemNameFull الخاص بـ InventoryManagementTemp
    /// </summary>
    public string ItemNameFull { get; private set; }

    /// <summary>
    /// ItemUnit of the InventoryManagementTemp
    /// ItemUnit الخاص بـ InventoryManagementTemp
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// WarehouseCode of the InventoryManagementTemp
    /// WarehouseCode الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// BatchNumber of the InventoryManagementTemp
    /// BatchNumber الخاص بـ InventoryManagementTemp
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// OperationQuantity of the InventoryManagementTemp
    /// OperationQuantity الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? OperationQuantity { get; private set; }

    /// <summary>
    /// IncomeQuantity of the InventoryManagementTemp
    /// IncomeQuantity الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? IncomeQuantity { get; private set; }

    /// <summary>
    /// SaleQuantity of the InventoryManagementTemp
    /// SaleQuantity الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? SaleQuantity { get; private set; }

    /// <summary>
    /// PosQuantity of the InventoryManagementTemp
    /// PosQuantity الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? PosQuantity { get; private set; }

    /// <summary>
    /// NetSale of the InventoryManagementTemp
    /// NetSale الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? NetSale { get; private set; }

    /// <summary>
    /// AvailableQuantity of the InventoryManagementTemp
    /// AvailableQuantity الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? AvailableQuantity { get; private set; }

    /// <summary>
    /// AverageSaleDay of the InventoryManagementTemp
    /// AverageSaleDay الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? AverageSaleDay { get; private set; }

    /// <summary>
    /// AverageSaleGeneral of the InventoryManagementTemp
    /// AverageSaleGeneral الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? AverageSaleGeneral { get; private set; }

    /// <summary>
    /// PeriodSaleQuantity of the InventoryManagementTemp
    /// PeriodSaleQuantity الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? PeriodSaleQuantity { get; private set; }

    /// <summary>
    /// ItemSaleAge of the InventoryManagementTemp
    /// ItemSaleAge الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? ItemSaleAge { get; private set; }

    /// <summary>
    /// ItemSaleAgePeriod of the InventoryManagementTemp
    /// ItemSaleAgePeriod الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? ItemSaleAgePeriod { get; private set; }

    /// <summary>
    /// ItemAge of the InventoryManagementTemp
    /// ItemAge الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? ItemAge { get; private set; }

    /// <summary>
    /// ItemRatio of the InventoryManagementTemp
    /// ItemRatio الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? ItemRatio { get; private set; }

    /// <summary>
    /// ItemSaleRatio of the InventoryManagementTemp
    /// ItemSaleRatio الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? ItemSaleRatio { get; private set; }

    /// <summary>
    /// TransactionNotReceivedQuantity of the InventoryManagementTemp
    /// TransactionNotReceivedQuantity الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? TransactionNotReceivedQuantity { get; private set; }

    /// <summary>
    /// SumIncomeQuantity of the InventoryManagementTemp
    /// SumIncomeQuantity الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? SumIncomeQuantity { get; private set; }

    /// <summary>
    /// QuantityFromWarehouse of the InventoryManagementTemp
    /// QuantityFromWarehouse الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? QuantityFromWarehouse { get; private set; }

    /// <summary>
    /// QuantityToWarehouse of the InventoryManagementTemp
    /// QuantityToWarehouse الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? QuantityToWarehouse { get; private set; }

    /// <summary>
    /// AverageQuantityPeriod of the InventoryManagementTemp
    /// AverageQuantityPeriod الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? AverageQuantityPeriod { get; private set; }

    /// <summary>
    /// GuarantorCode of the InventoryManagementTemp
    /// GuarantorCode الخاص بـ InventoryManagementTemp
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// GroupClassCode of the InventoryManagementTemp
    /// GroupClassCode الخاص بـ InventoryManagementTemp
    /// </summary>
    public string GroupClassCode { get; private set; }

    /// <summary>
    /// ManagerCode of the InventoryManagementTemp
    /// ManagerCode الخاص بـ InventoryManagementTemp
    /// </summary>
    public string ManagerCode { get; private set; }

    /// <summary>
    /// SubGroupCode of the InventoryManagementTemp
    /// SubGroupCode الخاص بـ InventoryManagementTemp
    /// </summary>
    public string SubGroupCode { get; private set; }

    /// <summary>
    /// AssistantNumber of the InventoryManagementTemp
    /// AssistantNumber الخاص بـ InventoryManagementTemp
    /// </summary>
    public string AssistantNumber { get; private set; }

    /// <summary>
    /// DetailNo of the InventoryManagementTemp
    /// DetailNo الخاص بـ InventoryManagementTemp
    /// </summary>
    public string DetailNo { get; private set; }

    /// <summary>
    /// ActivityNumber of the InventoryManagementTemp
    /// ActivityNumber الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? ActivityNumber { get; private set; }

    /// <summary>
    /// IncomeDate of the InventoryManagementTemp
    /// IncomeDate الخاص بـ InventoryManagementTemp
    /// </summary>
    public DateTime? IncomeDate { get; private set; }

    /// <summary>
    /// ItemType of the InventoryManagementTemp
    /// ItemType الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? ItemType { get; private set; }

    /// <summary>
    /// CityNumber of the InventoryManagementTemp
    /// CityNumber الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// RegionCode of the InventoryManagementTemp
    /// RegionCode الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// ItemOrder of the InventoryManagementTemp
    /// ItemOrder الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? ItemOrder { get; private set; }

    /// <summary>
    /// PeriodDay of the InventoryManagementTemp
    /// PeriodDay الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? PeriodDay { get; private set; }

    /// <summary>
    /// DocNo of the InventoryManagementTemp
    /// DocNo الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the InventoryManagementTemp
    /// CompanyNumberShort الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the InventoryManagementTemp
    /// BranchNumber الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the InventoryManagementTemp
    /// BranchYear الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the InventoryManagementTemp
    /// BranchUser الخاص بـ InventoryManagementTemp
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
