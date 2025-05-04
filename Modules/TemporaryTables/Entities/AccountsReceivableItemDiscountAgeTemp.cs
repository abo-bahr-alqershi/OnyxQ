using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// AccountsReceivableItemDiscountAgeTemp Entity
/// </summary>
public class AccountsReceivableItemDiscountAgeTemp : Entity<AccountsReceivableItemDiscountAgeTempId>
{
    private AccountsReceivableItemDiscountAgeTemp() { }

    /// <summary>
    /// The unique identifier for the AccountsReceivableItemDiscountAgeTemp
    /// المعرف الفريد لـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public AccountsReceivableItemDiscountAgeTempId Id { get; private set; }

    /// <summary>
    /// FieldCode of the AccountsReceivableItemDiscountAgeTemp
    /// FieldCode الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public string FieldCode { get; private set; }

    /// <summary>
    /// FieldName of the AccountsReceivableItemDiscountAgeTemp
    /// FieldName الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public string FieldName { get; private set; }

    /// <summary>
    /// FieldCode2 of the AccountsReceivableItemDiscountAgeTemp
    /// FieldCode2 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public string FieldCode2 { get; private set; }

    /// <summary>
    /// FieldName2 of the AccountsReceivableItemDiscountAgeTemp
    /// FieldName2 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public string FieldName2 { get; private set; }

    /// <summary>
    /// WarehouseCode of the AccountsReceivableItemDiscountAgeTemp
    /// WarehouseCode الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// AvailableQuantity of the AccountsReceivableItemDiscountAgeTemp
    /// AvailableQuantity الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? AvailableQuantity { get; private set; }

    /// <summary>
    /// IncomeQuantity of the AccountsReceivableItemDiscountAgeTemp
    /// IncomeQuantity الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? IncomeQuantity { get; private set; }

    /// <summary>
    /// IncomeNetAmount of the AccountsReceivableItemDiscountAgeTemp
    /// IncomeNetAmount الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? IncomeNetAmount { get; private set; }

    /// <summary>
    /// TransactionNotReceivedQuantity of the AccountsReceivableItemDiscountAgeTemp
    /// TransactionNotReceivedQuantity الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? TransactionNotReceivedQuantity { get; private set; }

    /// <summary>
    /// SalesQuantity of the AccountsReceivableItemDiscountAgeTemp
    /// SalesQuantity الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SalesQuantity { get; private set; }

    /// <summary>
    /// SalesAmount of the AccountsReceivableItemDiscountAgeTemp
    /// SalesAmount الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SalesAmount { get; private set; }

    /// <summary>
    /// ReturnSalesQuantity of the AccountsReceivableItemDiscountAgeTemp
    /// ReturnSalesQuantity الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? ReturnSalesQuantity { get; private set; }

    /// <summary>
    /// ReturnSalesAmount of the AccountsReceivableItemDiscountAgeTemp
    /// ReturnSalesAmount الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? ReturnSalesAmount { get; private set; }

    /// <summary>
    /// SalesNetQuantity of the AccountsReceivableItemDiscountAgeTemp
    /// SalesNetQuantity الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SalesNetQuantity { get; private set; }

    /// <summary>
    /// SalesNetAmount of the AccountsReceivableItemDiscountAgeTemp
    /// SalesNetAmount الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SalesNetAmount { get; private set; }

    /// <summary>
    /// ProfitPercent of the AccountsReceivableItemDiscountAgeTemp
    /// ProfitPercent الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? ProfitPercent { get; private set; }

    /// <summary>
    /// ProfitAmount of the AccountsReceivableItemDiscountAgeTemp
    /// ProfitAmount الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? ProfitAmount { get; private set; }

    /// <summary>
    /// ItemSalesAge of the AccountsReceivableItemDiscountAgeTemp
    /// ItemSalesAge الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? ItemSalesAge { get; private set; }

    /// <summary>
    /// SalesDayAverage of the AccountsReceivableItemDiscountAgeTemp
    /// SalesDayAverage الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SalesDayAverage { get; private set; }

    /// <summary>
    /// SalesGeneralAverage of the AccountsReceivableItemDiscountAgeTemp
    /// SalesGeneralAverage الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SalesGeneralAverage { get; private set; }

    /// <summary>
    /// PeriodSaleQuantity of the AccountsReceivableItemDiscountAgeTemp
    /// PeriodSaleQuantity الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? PeriodSaleQuantity { get; private set; }

    /// <summary>
    /// SalesStockCost of the AccountsReceivableItemDiscountAgeTemp
    /// SalesStockCost الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SalesStockCost { get; private set; }

    /// <summary>
    /// ReturnSalesStockCost of the AccountsReceivableItemDiscountAgeTemp
    /// ReturnSalesStockCost الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? ReturnSalesStockCost { get; private set; }

    /// <summary>
    /// SliceSalesQuantity1 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceSalesQuantity1 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceSalesQuantity1 { get; private set; }

    /// <summary>
    /// SliceSalesAmount1 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceSalesAmount1 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceSalesAmount1 { get; private set; }

    /// <summary>
    /// SliceReturnSalesQuantity1 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceReturnSalesQuantity1 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceReturnSalesQuantity1 { get; private set; }

    /// <summary>
    /// SliceReturnSalesAmount1 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceReturnSalesAmount1 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceReturnSalesAmount1 { get; private set; }

    /// <summary>
    /// SliceNetSalesQuantity1 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceNetSalesQuantity1 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceNetSalesQuantity1 { get; private set; }

    /// <summary>
    /// SliceNetSalesAmount1 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceNetSalesAmount1 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceNetSalesAmount1 { get; private set; }

    /// <summary>
    /// SliceReturnQuantityPercent1 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceReturnQuantityPercent1 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceReturnQuantityPercent1 { get; private set; }

    /// <summary>
    /// SliceProfitAmount1 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceProfitAmount1 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceProfitAmount1 { get; private set; }

    /// <summary>
    /// SliceProfitPercent1 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceProfitPercent1 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceProfitPercent1 { get; private set; }

    /// <summary>
    /// SliceDiscountAge1 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceDiscountAge1 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceDiscountAge1 { get; private set; }

    /// <summary>
    /// SalesDayAverage1 of the AccountsReceivableItemDiscountAgeTemp
    /// SalesDayAverage1 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SalesDayAverage1 { get; private set; }

    /// <summary>
    /// SalesGeneralAverage1 of the AccountsReceivableItemDiscountAgeTemp
    /// SalesGeneralAverage1 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SalesGeneralAverage1 { get; private set; }

    /// <summary>
    /// SliceSalesStockCost1 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceSalesStockCost1 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceSalesStockCost1 { get; private set; }

    /// <summary>
    /// SliceReturnSalesStockCost1 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceReturnSalesStockCost1 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceReturnSalesStockCost1 { get; private set; }

    /// <summary>
    /// SliceSalesQuantity2 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceSalesQuantity2 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceSalesQuantity2 { get; private set; }

    /// <summary>
    /// SliceReturnSalesQuantity2 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceReturnSalesQuantity2 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceReturnSalesQuantity2 { get; private set; }

    /// <summary>
    /// SliceNetSalesQuantity2 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceNetSalesQuantity2 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceNetSalesQuantity2 { get; private set; }

    /// <summary>
    /// SliceSalesAmount2 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceSalesAmount2 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceSalesAmount2 { get; private set; }

    /// <summary>
    /// SliceReturnSalesAmount2 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceReturnSalesAmount2 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceReturnSalesAmount2 { get; private set; }

    /// <summary>
    /// SliceNetSalesAmount2 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceNetSalesAmount2 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceNetSalesAmount2 { get; private set; }

    /// <summary>
    /// SliceReturnQuantityPercent2 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceReturnQuantityPercent2 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceReturnQuantityPercent2 { get; private set; }

    /// <summary>
    /// SliceProfitAmount2 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceProfitAmount2 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceProfitAmount2 { get; private set; }

    /// <summary>
    /// SliceProfitPercent2 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceProfitPercent2 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceProfitPercent2 { get; private set; }

    /// <summary>
    /// SliceDiscountAge2 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceDiscountAge2 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceDiscountAge2 { get; private set; }

    /// <summary>
    /// SalesDayAverage2 of the AccountsReceivableItemDiscountAgeTemp
    /// SalesDayAverage2 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SalesDayAverage2 { get; private set; }

    /// <summary>
    /// SalesGeneralAverage2 of the AccountsReceivableItemDiscountAgeTemp
    /// SalesGeneralAverage2 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SalesGeneralAverage2 { get; private set; }

    /// <summary>
    /// SliceSalesStockCost2 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceSalesStockCost2 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceSalesStockCost2 { get; private set; }

    /// <summary>
    /// SliceReturnSalesStockCost2 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceReturnSalesStockCost2 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceReturnSalesStockCost2 { get; private set; }

    /// <summary>
    /// SliceSalesQuantity3 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceSalesQuantity3 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceSalesQuantity3 { get; private set; }

    /// <summary>
    /// SliceReturnSalesQuantity3 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceReturnSalesQuantity3 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceReturnSalesQuantity3 { get; private set; }

    /// <summary>
    /// SliceNetSalesQuantity3 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceNetSalesQuantity3 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceNetSalesQuantity3 { get; private set; }

    /// <summary>
    /// SliceSalesAmount3 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceSalesAmount3 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceSalesAmount3 { get; private set; }

    /// <summary>
    /// SliceReturnSalesAmount3 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceReturnSalesAmount3 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceReturnSalesAmount3 { get; private set; }

    /// <summary>
    /// SliceNetSalesAmount3 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceNetSalesAmount3 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceNetSalesAmount3 { get; private set; }

    /// <summary>
    /// SliceReturnQuantityPercent3 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceReturnQuantityPercent3 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceReturnQuantityPercent3 { get; private set; }

    /// <summary>
    /// SliceProfitAmount3 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceProfitAmount3 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceProfitAmount3 { get; private set; }

    /// <summary>
    /// SliceProfitPercent3 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceProfitPercent3 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceProfitPercent3 { get; private set; }

    /// <summary>
    /// SliceDiscountAge3 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceDiscountAge3 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceDiscountAge3 { get; private set; }

    /// <summary>
    /// SalesDayAverage3 of the AccountsReceivableItemDiscountAgeTemp
    /// SalesDayAverage3 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SalesDayAverage3 { get; private set; }

    /// <summary>
    /// SalesGeneralAverage3 of the AccountsReceivableItemDiscountAgeTemp
    /// SalesGeneralAverage3 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SalesGeneralAverage3 { get; private set; }

    /// <summary>
    /// SliceSalesStockCost3 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceSalesStockCost3 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceSalesStockCost3 { get; private set; }

    /// <summary>
    /// SliceReturnSalesStockCost3 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceReturnSalesStockCost3 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceReturnSalesStockCost3 { get; private set; }

    /// <summary>
    /// SliceSalesQuantity4 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceSalesQuantity4 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceSalesQuantity4 { get; private set; }

    /// <summary>
    /// SliceReturnSalesQuantity4 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceReturnSalesQuantity4 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceReturnSalesQuantity4 { get; private set; }

    /// <summary>
    /// SliceNetSalesQuantity4 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceNetSalesQuantity4 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceNetSalesQuantity4 { get; private set; }

    /// <summary>
    /// SliceSalesAmount4 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceSalesAmount4 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceSalesAmount4 { get; private set; }

    /// <summary>
    /// SliceReturnSalesAmount4 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceReturnSalesAmount4 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceReturnSalesAmount4 { get; private set; }

    /// <summary>
    /// SliceNetSalesAmount4 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceNetSalesAmount4 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceNetSalesAmount4 { get; private set; }

    /// <summary>
    /// SliceReturnQuantityPercent4 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceReturnQuantityPercent4 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceReturnQuantityPercent4 { get; private set; }

    /// <summary>
    /// SliceProfitAmount4 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceProfitAmount4 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceProfitAmount4 { get; private set; }

    /// <summary>
    /// SliceProfitPercent4 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceProfitPercent4 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceProfitPercent4 { get; private set; }

    /// <summary>
    /// SliceDiscountAge4 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceDiscountAge4 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceDiscountAge4 { get; private set; }

    /// <summary>
    /// SalesDayAverage4 of the AccountsReceivableItemDiscountAgeTemp
    /// SalesDayAverage4 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SalesDayAverage4 { get; private set; }

    /// <summary>
    /// SalesGeneralAverage4 of the AccountsReceivableItemDiscountAgeTemp
    /// SalesGeneralAverage4 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SalesGeneralAverage4 { get; private set; }

    /// <summary>
    /// SliceSalesStockCost4 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceSalesStockCost4 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceSalesStockCost4 { get; private set; }

    /// <summary>
    /// SliceReturnSalesStockCost4 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceReturnSalesStockCost4 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceReturnSalesStockCost4 { get; private set; }

    /// <summary>
    /// SliceSalesQuantity5 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceSalesQuantity5 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceSalesQuantity5 { get; private set; }

    /// <summary>
    /// SliceReturnSalesQuantity5 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceReturnSalesQuantity5 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceReturnSalesQuantity5 { get; private set; }

    /// <summary>
    /// SliceNetSalesQuantity5 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceNetSalesQuantity5 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceNetSalesQuantity5 { get; private set; }

    /// <summary>
    /// SliceSalesAmount5 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceSalesAmount5 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceSalesAmount5 { get; private set; }

    /// <summary>
    /// SliceReturnSalesAmount5 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceReturnSalesAmount5 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceReturnSalesAmount5 { get; private set; }

    /// <summary>
    /// SliceNetSalesAmount5 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceNetSalesAmount5 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceNetSalesAmount5 { get; private set; }

    /// <summary>
    /// SliceReturnQuantityPercent5 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceReturnQuantityPercent5 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceReturnQuantityPercent5 { get; private set; }

    /// <summary>
    /// SliceProfitPercent5 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceProfitPercent5 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceProfitPercent5 { get; private set; }

    /// <summary>
    /// SliceProfitAmount5 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceProfitAmount5 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceProfitAmount5 { get; private set; }

    /// <summary>
    /// SliceDiscountAge5 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceDiscountAge5 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceDiscountAge5 { get; private set; }

    /// <summary>
    /// SalesDayAverage5 of the AccountsReceivableItemDiscountAgeTemp
    /// SalesDayAverage5 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SalesDayAverage5 { get; private set; }

    /// <summary>
    /// SalesGeneralAverage5 of the AccountsReceivableItemDiscountAgeTemp
    /// SalesGeneralAverage5 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SalesGeneralAverage5 { get; private set; }

    /// <summary>
    /// SliceSalesStockCost5 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceSalesStockCost5 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceSalesStockCost5 { get; private set; }

    /// <summary>
    /// SliceReturnSalesStockCost5 of the AccountsReceivableItemDiscountAgeTemp
    /// SliceReturnSalesStockCost5 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SliceReturnSalesStockCost5 { get; private set; }

    /// <summary>
    /// SalesIncreasePercent1 of the AccountsReceivableItemDiscountAgeTemp
    /// SalesIncreasePercent1 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SalesIncreasePercent1 { get; private set; }

    /// <summary>
    /// SalesIncreasePercent2 of the AccountsReceivableItemDiscountAgeTemp
    /// SalesIncreasePercent2 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SalesIncreasePercent2 { get; private set; }

    /// <summary>
    /// SalesIncreasePercent3 of the AccountsReceivableItemDiscountAgeTemp
    /// SalesIncreasePercent3 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SalesIncreasePercent3 { get; private set; }

    /// <summary>
    /// SalesIncreasePercent4 of the AccountsReceivableItemDiscountAgeTemp
    /// SalesIncreasePercent4 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SalesIncreasePercent4 { get; private set; }

    /// <summary>
    /// SalesIncreasePercent5 of the AccountsReceivableItemDiscountAgeTemp
    /// SalesIncreasePercent5 الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SalesIncreasePercent5 { get; private set; }

    /// <summary>
    /// AvailableQuantityAmount of the AccountsReceivableItemDiscountAgeTemp
    /// AvailableQuantityAmount الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? AvailableQuantityAmount { get; private set; }

    /// <summary>
    /// OpenBalanceQuantity of the AccountsReceivableItemDiscountAgeTemp
    /// OpenBalanceQuantity الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? OpenBalanceQuantity { get; private set; }

    /// <summary>
    /// OpenBalanceAmount of the AccountsReceivableItemDiscountAgeTemp
    /// OpenBalanceAmount الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? OpenBalanceAmount { get; private set; }

    /// <summary>
    /// IncomeAmount of the AccountsReceivableItemDiscountAgeTemp
    /// IncomeAmount الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? IncomeAmount { get; private set; }

    /// <summary>
    /// OutgoingQuantity of the AccountsReceivableItemDiscountAgeTemp
    /// OutgoingQuantity الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? OutgoingQuantity { get; private set; }

    /// <summary>
    /// OutgoingAmount of the AccountsReceivableItemDiscountAgeTemp
    /// OutgoingAmount الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? OutgoingAmount { get; private set; }

    /// <summary>
    /// TransactionQuantity of the AccountsReceivableItemDiscountAgeTemp
    /// TransactionQuantity الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? TransactionQuantity { get; private set; }

    /// <summary>
    /// TransactionAmount of the AccountsReceivableItemDiscountAgeTemp
    /// TransactionAmount الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? TransactionAmount { get; private set; }

    /// <summary>
    /// AdjustmentQuantity of the AccountsReceivableItemDiscountAgeTemp
    /// AdjustmentQuantity الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? AdjustmentQuantity { get; private set; }

    /// <summary>
    /// AdjustmentAmount of the AccountsReceivableItemDiscountAgeTemp
    /// AdjustmentAmount الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? AdjustmentAmount { get; private set; }

    /// <summary>
    /// NetIncomeQuantity of the AccountsReceivableItemDiscountAgeTemp
    /// NetIncomeQuantity الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? NetIncomeQuantity { get; private set; }

    /// <summary>
    /// NetIncomeAmount of the AccountsReceivableItemDiscountAgeTemp
    /// NetIncomeAmount الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? NetIncomeAmount { get; private set; }

    /// <summary>
    /// BatchNumber of the AccountsReceivableItemDiscountAgeTemp
    /// BatchNumber الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// TerminalName of the AccountsReceivableItemDiscountAgeTemp
    /// TerminalName الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public string TerminalName { get; private set; }

    /// <summary>
    /// RecordNumber of the AccountsReceivableItemDiscountAgeTemp
    /// RecordNumber الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// RepNumber of the AccountsReceivableItemDiscountAgeTemp
    /// RepNumber الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? RepNumber { get; private set; }

    /// <summary>
    /// RepDate of the AccountsReceivableItemDiscountAgeTemp
    /// RepDate الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public DateTime? RepDate { get; private set; }

    /// <summary>
    /// SalesNetStockCost of the AccountsReceivableItemDiscountAgeTemp
    /// SalesNetStockCost الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SalesNetStockCost { get; private set; }

    /// <summary>
    /// TransactionNotReceivedAmount of the AccountsReceivableItemDiscountAgeTemp
    /// TransactionNotReceivedAmount الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? TransactionNotReceivedAmount { get; private set; }

    /// <summary>
    /// ItemSalesAgePeriod of the AccountsReceivableItemDiscountAgeTemp
    /// ItemSalesAgePeriod الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? ItemSalesAgePeriod { get; private set; }

    /// <summary>
    /// ReturnSalesQuantityPercent of the AccountsReceivableItemDiscountAgeTemp
    /// ReturnSalesQuantityPercent الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? ReturnSalesQuantityPercent { get; private set; }

    /// <summary>
    /// TotalAvailableQuantity of the AccountsReceivableItemDiscountAgeTemp
    /// TotalAvailableQuantity الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? TotalAvailableQuantity { get; private set; }

    /// <summary>
    /// TotalAvailableQuantityAmount of the AccountsReceivableItemDiscountAgeTemp
    /// TotalAvailableQuantityAmount الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? TotalAvailableQuantityAmount { get; private set; }

    /// <summary>
    /// TotalOpenBalanceQuantity of the AccountsReceivableItemDiscountAgeTemp
    /// TotalOpenBalanceQuantity الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? TotalOpenBalanceQuantity { get; private set; }

    /// <summary>
    /// TotalOpenBalanceAmount of the AccountsReceivableItemDiscountAgeTemp
    /// TotalOpenBalanceAmount الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? TotalOpenBalanceAmount { get; private set; }

    /// <summary>
    /// TotalNetIncomeQuantity of the AccountsReceivableItemDiscountAgeTemp
    /// TotalNetIncomeQuantity الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? TotalNetIncomeQuantity { get; private set; }

    /// <summary>
    /// TotalNetIncomeAmount of the AccountsReceivableItemDiscountAgeTemp
    /// TotalNetIncomeAmount الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? TotalNetIncomeAmount { get; private set; }

    /// <summary>
    /// SalesmanCommissionAmount of the AccountsReceivableItemDiscountAgeTemp
    /// SalesmanCommissionAmount الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? SalesmanCommissionAmount { get; private set; }

    /// <summary>
    /// NetSalesAfterSalesmanCommission of the AccountsReceivableItemDiscountAgeTemp
    /// NetSalesAfterSalesmanCommission الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? NetSalesAfterSalesmanCommission { get; private set; }

    /// <summary>
    /// TotalSalesQuantity of the AccountsReceivableItemDiscountAgeTemp
    /// TotalSalesQuantity الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? TotalSalesQuantity { get; private set; }

    /// <summary>
    /// TotalSalesAmount of the AccountsReceivableItemDiscountAgeTemp
    /// TotalSalesAmount الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? TotalSalesAmount { get; private set; }

    /// <summary>
    /// TotalReturnSalesQuantity of the AccountsReceivableItemDiscountAgeTemp
    /// TotalReturnSalesQuantity الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? TotalReturnSalesQuantity { get; private set; }

    /// <summary>
    /// TotalReturnSalesAmount of the AccountsReceivableItemDiscountAgeTemp
    /// TotalReturnSalesAmount الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? TotalReturnSalesAmount { get; private set; }

    /// <summary>
    /// TotalSalesNetQuantity of the AccountsReceivableItemDiscountAgeTemp
    /// TotalSalesNetQuantity الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? TotalSalesNetQuantity { get; private set; }

    /// <summary>
    /// TotalSalesNetAmount of the AccountsReceivableItemDiscountAgeTemp
    /// TotalSalesNetAmount الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? TotalSalesNetAmount { get; private set; }

    /// <summary>
    /// TotalProfitAmount of the AccountsReceivableItemDiscountAgeTemp
    /// TotalProfitAmount الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? TotalProfitAmount { get; private set; }

    /// <summary>
    /// TotalSalesStockCost of the AccountsReceivableItemDiscountAgeTemp
    /// TotalSalesStockCost الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? TotalSalesStockCost { get; private set; }

    /// <summary>
    /// TotalSalesNetStockCost of the AccountsReceivableItemDiscountAgeTemp
    /// TotalSalesNetStockCost الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? TotalSalesNetStockCost { get; private set; }

    /// <summary>
    /// TotalSalesmanCommissionAmount of the AccountsReceivableItemDiscountAgeTemp
    /// TotalSalesmanCommissionAmount الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? TotalSalesmanCommissionAmount { get; private set; }

    /// <summary>
    /// TotalNetSalesAfterSalesmanCommission of the AccountsReceivableItemDiscountAgeTemp
    /// TotalNetSalesAfterSalesmanCommission الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? TotalNetSalesAfterSalesmanCommission { get; private set; }

    /// <summary>
    /// TotalProfitLossAfterSalesmanCommission of the AccountsReceivableItemDiscountAgeTemp
    /// TotalProfitLossAfterSalesmanCommission الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? TotalProfitLossAfterSalesmanCommission { get; private set; }

    /// <summary>
    /// PlaceAfterSalesmanCommission of the AccountsReceivableItemDiscountAgeTemp
    /// PlaceAfterSalesmanCommission الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? PlaceAfterSalesmanCommission { get; private set; }

    /// <summary>
    /// TotalReturnSalesStockCost of the AccountsReceivableItemDiscountAgeTemp
    /// TotalReturnSalesStockCost الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? TotalReturnSalesStockCost { get; private set; }

    /// <summary>
    /// BranchNumber of the AccountsReceivableItemDiscountAgeTemp
    /// BranchNumber الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AccountsReceivableItemDiscountAgeTemp
    /// BranchYear الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AccountsReceivableItemDiscountAgeTemp
    /// CompanyNumberShort الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchUser of the AccountsReceivableItemDiscountAgeTemp
    /// BranchUser الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ItemUnit of the AccountsReceivableItemDiscountAgeTemp
    /// ItemUnit الخاص بـ AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public string ItemUnit { get; private set; }
}
}
