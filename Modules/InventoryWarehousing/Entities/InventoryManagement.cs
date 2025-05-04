using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// InventoryManagement Entity
/// </summary>
public class InventoryManagement : Entity<InventoryManagementId>
{
    private InventoryManagement() { }

    /// <summary>
    /// The unique identifier for the InventoryManagement
    /// المعرف الفريد لـ InventoryManagement
    /// </summary>
    public InventoryManagementId Id { get; private set; }

    /// <summary>
    /// DocNo of the InventoryManagement
    /// DocNo الخاص بـ InventoryManagement
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocDate of the InventoryManagement
    /// DocDate الخاص بـ InventoryManagement
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// ItemCode of the InventoryManagement
    /// ItemCode الخاص بـ InventoryManagement
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemNameFull of the InventoryManagement
    /// ItemNameFull الخاص بـ InventoryManagement
    /// </summary>
    public string ItemNameFull { get; private set; }

    /// <summary>
    /// ItemUnit of the InventoryManagement
    /// ItemUnit الخاص بـ InventoryManagement
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the InventoryManagement
    /// PSize الخاص بـ InventoryManagement
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// WarehouseCode of the InventoryManagement
    /// WarehouseCode الخاص بـ InventoryManagement
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// BatchNumber of the InventoryManagement
    /// BatchNumber الخاص بـ InventoryManagement
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// OperationQuantity of the InventoryManagement
    /// OperationQuantity الخاص بـ InventoryManagement
    /// </summary>
    public decimal? OperationQuantity { get; private set; }

    /// <summary>
    /// IncomeQuantity of the InventoryManagement
    /// IncomeQuantity الخاص بـ InventoryManagement
    /// </summary>
    public decimal? IncomeQuantity { get; private set; }

    /// <summary>
    /// SaleQuantity of the InventoryManagement
    /// SaleQuantity الخاص بـ InventoryManagement
    /// </summary>
    public decimal? SaleQuantity { get; private set; }

    /// <summary>
    /// PosQuantity of the InventoryManagement
    /// PosQuantity الخاص بـ InventoryManagement
    /// </summary>
    public decimal? PosQuantity { get; private set; }

    /// <summary>
    /// NetSale of the InventoryManagement
    /// NetSale الخاص بـ InventoryManagement
    /// </summary>
    public decimal? NetSale { get; private set; }

    /// <summary>
    /// AvailableQuantity of the InventoryManagement
    /// AvailableQuantity الخاص بـ InventoryManagement
    /// </summary>
    public decimal? AvailableQuantity { get; private set; }

    /// <summary>
    /// AverageSaleDay of the InventoryManagement
    /// AverageSaleDay الخاص بـ InventoryManagement
    /// </summary>
    public decimal? AverageSaleDay { get; private set; }

    /// <summary>
    /// AverageSaleGeneral of the InventoryManagement
    /// AverageSaleGeneral الخاص بـ InventoryManagement
    /// </summary>
    public decimal? AverageSaleGeneral { get; private set; }

    /// <summary>
    /// PeriodSaleQuantity of the InventoryManagement
    /// PeriodSaleQuantity الخاص بـ InventoryManagement
    /// </summary>
    public decimal? PeriodSaleQuantity { get; private set; }

    /// <summary>
    /// ItemSaleAge of the InventoryManagement
    /// ItemSaleAge الخاص بـ InventoryManagement
    /// </summary>
    public decimal? ItemSaleAge { get; private set; }

    /// <summary>
    /// ItemSaleAgePeriod of the InventoryManagement
    /// ItemSaleAgePeriod الخاص بـ InventoryManagement
    /// </summary>
    public decimal? ItemSaleAgePeriod { get; private set; }

    /// <summary>
    /// ItemAge of the InventoryManagement
    /// ItemAge الخاص بـ InventoryManagement
    /// </summary>
    public decimal? ItemAge { get; private set; }

    /// <summary>
    /// ItemRatio of the InventoryManagement
    /// ItemRatio الخاص بـ InventoryManagement
    /// </summary>
    public decimal? ItemRatio { get; private set; }

    /// <summary>
    /// ItemSaleRatio of the InventoryManagement
    /// ItemSaleRatio الخاص بـ InventoryManagement
    /// </summary>
    public decimal? ItemSaleRatio { get; private set; }

    /// <summary>
    /// TransactionNotReceivedQuantity of the InventoryManagement
    /// TransactionNotReceivedQuantity الخاص بـ InventoryManagement
    /// </summary>
    public decimal? TransactionNotReceivedQuantity { get; private set; }

    /// <summary>
    /// SumIncomeQuantity of the InventoryManagement
    /// SumIncomeQuantity الخاص بـ InventoryManagement
    /// </summary>
    public decimal? SumIncomeQuantity { get; private set; }

    /// <summary>
    /// QuantityFromWarehouse of the InventoryManagement
    /// QuantityFromWarehouse الخاص بـ InventoryManagement
    /// </summary>
    public decimal? QuantityFromWarehouse { get; private set; }

    /// <summary>
    /// QuantityToWarehouse of the InventoryManagement
    /// QuantityToWarehouse الخاص بـ InventoryManagement
    /// </summary>
    public decimal? QuantityToWarehouse { get; private set; }

    /// <summary>
    /// AverageQuantityPeriod of the InventoryManagement
    /// AverageQuantityPeriod الخاص بـ InventoryManagement
    /// </summary>
    public decimal? AverageQuantityPeriod { get; private set; }

    /// <summary>
    /// GuarantorCode of the InventoryManagement
    /// GuarantorCode الخاص بـ InventoryManagement
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// GroupClassCode of the InventoryManagement
    /// GroupClassCode الخاص بـ InventoryManagement
    /// </summary>
    public string GroupClassCode { get; private set; }

    /// <summary>
    /// ManagerCode of the InventoryManagement
    /// ManagerCode الخاص بـ InventoryManagement
    /// </summary>
    public string ManagerCode { get; private set; }

    /// <summary>
    /// SubGroupCode of the InventoryManagement
    /// SubGroupCode الخاص بـ InventoryManagement
    /// </summary>
    public string SubGroupCode { get; private set; }

    /// <summary>
    /// AssistantNumber of the InventoryManagement
    /// AssistantNumber الخاص بـ InventoryManagement
    /// </summary>
    public string AssistantNumber { get; private set; }

    /// <summary>
    /// DetailNo of the InventoryManagement
    /// DetailNo الخاص بـ InventoryManagement
    /// </summary>
    public string DetailNo { get; private set; }

    /// <summary>
    /// ActivityNumber of the InventoryManagement
    /// ActivityNumber الخاص بـ InventoryManagement
    /// </summary>
    public decimal? ActivityNumber { get; private set; }

    /// <summary>
    /// IncomeDate of the InventoryManagement
    /// IncomeDate الخاص بـ InventoryManagement
    /// </summary>
    public DateTime? IncomeDate { get; private set; }

    /// <summary>
    /// ItemType of the InventoryManagement
    /// ItemType الخاص بـ InventoryManagement
    /// </summary>
    public decimal? ItemType { get; private set; }

    /// <summary>
    /// CityNumber of the InventoryManagement
    /// CityNumber الخاص بـ InventoryManagement
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// RegionCode of the InventoryManagement
    /// RegionCode الخاص بـ InventoryManagement
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// ItemOrder of the InventoryManagement
    /// ItemOrder الخاص بـ InventoryManagement
    /// </summary>
    public decimal? ItemOrder { get; private set; }

    /// <summary>
    /// PeriodDay of the InventoryManagement
    /// PeriodDay الخاص بـ InventoryManagement
    /// </summary>
    public decimal? PeriodDay { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the InventoryManagement
    /// ProcessedFlagFull الخاص بـ InventoryManagement
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the InventoryManagement
    /// CompanyNumberShort الخاص بـ InventoryManagement
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the InventoryManagement
    /// BranchNumber الخاص بـ InventoryManagement
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the InventoryManagement
    /// BranchYear الخاص بـ InventoryManagement
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the InventoryManagement
    /// BranchUser الخاص بـ InventoryManagement
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
