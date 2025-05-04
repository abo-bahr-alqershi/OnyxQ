using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerMeasureDetail Entity
/// </summary>
public class CustomerMeasureDetail : Entity<CustomerMeasureDetailId>
{
    private CustomerMeasureDetail() { }

    /// <summary>
    /// The unique identifier for the CustomerMeasureDetail
    /// المعرف الفريد لـ CustomerMeasureDetail
    /// </summary>
    public CustomerMeasureDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the CustomerMeasureDetail
    /// DocNo الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the CustomerMeasureDetail
    /// DocSer الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// CCode of the CustomerMeasureDetail
    /// CCode الخاص بـ CustomerMeasureDetail
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CDegree of the CustomerMeasureDetail
    /// CDegree الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? CDegree { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CustomerMeasureDetail
    /// CompanyNumberShort الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CustomerMeasureDetail
    /// BranchNumber الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CustomerMeasureDetail
    /// BranchYear الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CustomerMeasureDetail
    /// BranchUser الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// SalesAmount of the CustomerMeasureDetail
    /// SalesAmount الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? SalesAmount { get; private set; }

    /// <summary>
    /// SalesQuantity of the CustomerMeasureDetail
    /// SalesQuantity الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? SalesQuantity { get; private set; }

    /// <summary>
    /// NetSalesAmount of the CustomerMeasureDetail
    /// NetSalesAmount الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? NetSalesAmount { get; private set; }

    /// <summary>
    /// NetSalesQuantity of the CustomerMeasureDetail
    /// NetSalesQuantity الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? NetSalesQuantity { get; private set; }

    /// <summary>
    /// ProfitMarginPercentFull of the CustomerMeasureDetail
    /// ProfitMarginPercentFull الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? ProfitMarginPercentFull { get; private set; }

    /// <summary>
    /// DailySalesRate of the CustomerMeasureDetail
    /// DailySalesRate الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? DailySalesRate { get; private set; }

    /// <summary>
    /// MonthlySalesRate of the CustomerMeasureDetail
    /// MonthlySalesRate الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? MonthlySalesRate { get; private set; }

    /// <summary>
    /// IndebtednessRate of the CustomerMeasureDetail
    /// IndebtednessRate الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? IndebtednessRate { get; private set; }

    /// <summary>
    /// IndebtednessReceivePercent of the CustomerMeasureDetail
    /// IndebtednessReceivePercent الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? IndebtednessReceivePercent { get; private set; }

    /// <summary>
    /// SalesReturnPercent of the CustomerMeasureDetail
    /// SalesReturnPercent الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? SalesReturnPercent { get; private set; }

    /// <summary>
    /// SalesAmountDegree of the CustomerMeasureDetail
    /// SalesAmountDegree الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? SalesAmountDegree { get; private set; }

    /// <summary>
    /// SalesQuantityDegree of the CustomerMeasureDetail
    /// SalesQuantityDegree الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? SalesQuantityDegree { get; private set; }

    /// <summary>
    /// NetSalesAmountDegree of the CustomerMeasureDetail
    /// NetSalesAmountDegree الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? NetSalesAmountDegree { get; private set; }

    /// <summary>
    /// NetSalesQuantityDegree of the CustomerMeasureDetail
    /// NetSalesQuantityDegree الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? NetSalesQuantityDegree { get; private set; }

    /// <summary>
    /// ProfitMarginPercentDegree of the CustomerMeasureDetail
    /// ProfitMarginPercentDegree الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? ProfitMarginPercentDegree { get; private set; }

    /// <summary>
    /// DailySalesRateDeg of the CustomerMeasureDetail
    /// DailySalesRateDeg الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? DailySalesRateDeg { get; private set; }

    /// <summary>
    /// MonthlySalesRateDegree of the CustomerMeasureDetail
    /// MonthlySalesRateDegree الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? MonthlySalesRateDegree { get; private set; }

    /// <summary>
    /// IndebtednessRateDegree of the CustomerMeasureDetail
    /// IndebtednessRateDegree الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? IndebtednessRateDegree { get; private set; }

    /// <summary>
    /// IndebtednessReceivePercentDegree of the CustomerMeasureDetail
    /// IndebtednessReceivePercentDegree الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? IndebtednessReceivePercentDegree { get; private set; }

    /// <summary>
    /// SalesReturnPercentDegree of the CustomerMeasureDetail
    /// SalesReturnPercentDegree الخاص بـ CustomerMeasureDetail
    /// </summary>
    public decimal? SalesReturnPercentDegree { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to CustomerMeasureMaster
    /// </summary>
    public CustomerMeasureMaster CustomerMeasureMaster { get; private set; }
    #endregion
}
}
