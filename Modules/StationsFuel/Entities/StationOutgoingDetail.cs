using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.HumanResources.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.StationsFuel.Entities
{
/// <summary>
/// StationOutgoingDetail Entity
/// </summary>
public class StationOutgoingDetail : Entity<StationOutgoingDetailId>
{
    private StationOutgoingDetail() { }

    /// <summary>
    /// The unique identifier for the StationOutgoingDetail
    /// المعرف الفريد لـ StationOutgoingDetail
    /// </summary>
    public StationOutgoingDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the StationOutgoingDetail
    /// DocNo الخاص بـ StationOutgoingDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the StationOutgoingDetail
    /// DocSer الخاص بـ StationOutgoingDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// OutgoingTypeFull of the StationOutgoingDetail
    /// OutgoingTypeFull الخاص بـ StationOutgoingDetail
    /// </summary>
    public decimal? OutgoingTypeFull { get; private set; }

    /// <summary>
    /// AccountCode of the StationOutgoingDetail
    /// AccountCode الخاص بـ StationOutgoingDetail
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the StationOutgoingDetail
    /// AccountDetailCode الخاص بـ StationOutgoingDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the StationOutgoingDetail
    /// AccountDetailType الخاص بـ StationOutgoingDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCurrency of the StationOutgoingDetail
    /// AccountCurrency الخاص بـ StationOutgoingDetail
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the StationOutgoingDetail
    /// AccountRate الخاص بـ StationOutgoingDetail
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// StockRateShort of the StationOutgoingDetail
    /// StockRateShort الخاص بـ StationOutgoingDetail
    /// </summary>
    public decimal? StockRateShort { get; private set; }

    /// <summary>
    /// ReferenceNumber of the StationOutgoingDetail
    /// ReferenceNumber الخاص بـ StationOutgoingDetail
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// FuelTypeNumber of the StationOutgoingDetail
    /// FuelTypeNumber الخاص بـ StationOutgoingDetail
    /// </summary>
    public decimal? FuelTypeNumber { get; private set; }

    /// <summary>
    /// ItemQuantity of the StationOutgoingDetail
    /// ItemQuantity الخاص بـ StationOutgoingDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the StationOutgoingDetail
    /// ItemPriceShort الخاص بـ StationOutgoingDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// StockCost of the StationOutgoingDetail
    /// StockCost الخاص بـ StationOutgoingDetail
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// DocDscDtl of the StationOutgoingDetail
    /// DocDscDtl الخاص بـ StationOutgoingDetail
    /// </summary>
    public string DocDscDtl { get; private set; }

    /// <summary>
    /// ItemCode of the StationOutgoingDetail
    /// ItemCode الخاص بـ StationOutgoingDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the StationOutgoingDetail
    /// ItemUnit الخاص بـ StationOutgoingDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the StationOutgoingDetail
    /// PSize الخاص بـ StationOutgoingDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// BatchNumber of the StationOutgoingDetail
    /// BatchNumber الخاص بـ StationOutgoingDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// EmpNo of the StationOutgoingDetail
    /// EmpNo الخاص بـ StationOutgoingDetail
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// CostCenterCode of the StationOutgoingDetail
    /// CostCenterCode الخاص بـ StationOutgoingDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ActivityNumber of the StationOutgoingDetail
    /// ActivityNumber الخاص بـ StationOutgoingDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ProjectNumber of the StationOutgoingDetail
    /// ProjectNumber الخاص بـ StationOutgoingDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// WarehouseCode of the StationOutgoingDetail
    /// WarehouseCode الخاص بـ StationOutgoingDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CuntrNo of the StationOutgoingDetail
    /// CuntrNo الخاص بـ StationOutgoingDetail
    /// </summary>
    public decimal? CuntrNo { get; private set; }

    /// <summary>
    /// RecordNumber of the StationOutgoingDetail
    /// RecordNumber الخاص بـ StationOutgoingDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the StationOutgoingDetail
    /// CompanyNumberShort الخاص بـ StationOutgoingDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the StationOutgoingDetail
    /// BranchNumber الخاص بـ StationOutgoingDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the StationOutgoingDetail
    /// BranchYear الخاص بـ StationOutgoingDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the StationOutgoingDetail
    /// BranchUser الخاص بـ StationOutgoingDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// PurchaseType of the StationOutgoingDetail
    /// PurchaseType الخاص بـ StationOutgoingDetail
    /// </summary>
    public decimal? PurchaseType { get; private set; }

    /// <summary>
    /// ExpenseAccountCode of the StationOutgoingDetail
    /// ExpenseAccountCode الخاص بـ StationOutgoingDetail
    /// </summary>
    public string ExpenseAccountCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Employee
    /// </summary>
    public Employee Employee { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Account
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// ManyToOne relationship to StationBillMaster
    /// </summary>
    public StationBillMaster StationBillMaster { get; private set; }
    #endregion
}
}
