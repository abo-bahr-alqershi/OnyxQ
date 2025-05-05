using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// PurchaseRequestAutoDetail Entity
/// </summary>
public class PurchaseRequestAutoDetail : Entity<PurchaseRequestAutoDetailId>
{

    private PurchaseRequestAutoDetail() { }

    public PurchaseRequestAutoDetail(PurchaseRequestAutoDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PurchaseRequestAutoDetail
    /// المعرف الفريد لـ PurchaseRequestAutoDetail
    /// </summary>
    public PurchaseRequestAutoDetailId Id { get; private set; }

    /// <summary>
    /// MethodType of the PurchaseRequestAutoDetail
    /// MethodType الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? MethodType { get; private set; }

    /// <summary>
    /// DocNo of the PurchaseRequestAutoDetail
    /// DocNo الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// ItemCode of the PurchaseRequestAutoDetail
    /// ItemCode الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemQuantity of the PurchaseRequestAutoDetail
    /// ItemQuantity الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// ItemUnit of the PurchaseRequestAutoDetail
    /// ItemUnit الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the PurchaseRequestAutoDetail
    /// PSize الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the PurchaseRequestAutoDetail
    /// PQuantity الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// WarehouseCode of the PurchaseRequestAutoDetail
    /// WarehouseCode الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// RecordNumber of the PurchaseRequestAutoDetail
    /// RecordNumber الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ItemDescription of the PurchaseRequestAutoDetail
    /// ItemDescription الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// AvailableQuantity of the PurchaseRequestAutoDetail
    /// AvailableQuantity الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? AvailableQuantity { get; private set; }

    /// <summary>
    /// LastIncomePrice of the PurchaseRequestAutoDetail
    /// LastIncomePrice الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? LastIncomePrice { get; private set; }

    /// <summary>
    /// Barcode of the PurchaseRequestAutoDetail
    /// Barcode الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// RequestNumber of the PurchaseRequestAutoDetail
    /// RequestNumber الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? RequestNumber { get; private set; }

    /// <summary>
    /// RequestType of the PurchaseRequestAutoDetail
    /// RequestType الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? RequestType { get; private set; }

    /// <summary>
    /// RequestSerialShort of the PurchaseRequestAutoDetail
    /// RequestSerialShort الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? RequestSerialShort { get; private set; }

    /// <summary>
    /// DocSequence of the PurchaseRequestAutoDetail
    /// DocSequence الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PurchaseRequestAutoDetail
    /// CompanyNumberShort الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PurchaseRequestAutoDetail
    /// BranchNumber الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PurchaseRequestAutoDetail
    /// BranchYear الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the PurchaseRequestAutoDetail
    /// BranchUser الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ItemLength of the PurchaseRequestAutoDetail
    /// ItemLength الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the PurchaseRequestAutoDetail
    /// ItemWidth الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the PurchaseRequestAutoDetail
    /// ItemHeightShort الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the PurchaseRequestAutoDetail
    /// ItemNumberShort الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// PurchaseCount of the PurchaseRequestAutoDetail
    /// PurchaseCount الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? PurchaseCount { get; private set; }

    /// <summary>
    /// LostDay of the PurchaseRequestAutoDetail
    /// LostDay الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? LostDay { get; private set; }

    /// <summary>
    /// FDate of the PurchaseRequestAutoDetail
    /// FDate الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the PurchaseRequestAutoDetail
    /// TDate الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// ReorderPoint of the PurchaseRequestAutoDetail
    /// ReorderPoint الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? ReorderPoint { get; private set; }

    /// <summary>
    /// LeadTime of the PurchaseRequestAutoDetail
    /// LeadTime الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? LeadTime { get; private set; }

    /// <summary>
    /// ItemRoll of the PurchaseRequestAutoDetail
    /// ItemRoll الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? ItemRoll { get; private set; }

    /// <summary>
    /// ItemMinQuantityShort of the PurchaseRequestAutoDetail
    /// ItemMinQuantityShort الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? ItemMinQuantityShort { get; private set; }

    /// <summary>
    /// SQuantity of the PurchaseRequestAutoDetail
    /// SQuantity الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? SQuantity { get; private set; }

    /// <summary>
    /// PurchaseOrderQuantity of the PurchaseRequestAutoDetail
    /// PurchaseOrderQuantity الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? PurchaseOrderQuantity { get; private set; }

    /// <summary>
    /// PurchaseOrderQuantityOpen of the PurchaseRequestAutoDetail
    /// PurchaseOrderQuantityOpen الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? PurchaseOrderQuantityOpen { get; private set; }

    /// <summary>
    /// LastIncomeQuantity of the PurchaseRequestAutoDetail
    /// LastIncomeQuantity الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? LastIncomeQuantity { get; private set; }

    /// <summary>
    /// LastIncomeDate of the PurchaseRequestAutoDetail
    /// LastIncomeDate الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public DateTime? LastIncomeDate { get; private set; }

    /// <summary>
    /// LastExpireDate of the PurchaseRequestAutoDetail
    /// LastExpireDate الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public DateTime? LastExpireDate { get; private set; }

    /// <summary>
    /// LastFreeQuantity of the PurchaseRequestAutoDetail
    /// LastFreeQuantity الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? LastFreeQuantity { get; private set; }

    /// <summary>
    /// PeriodLastFreeQuantity of the PurchaseRequestAutoDetail
    /// PeriodLastFreeQuantity الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? PeriodLastFreeQuantity { get; private set; }

    /// <summary>
    /// FRequestPeriod of the PurchaseRequestAutoDetail
    /// FRequestPeriod الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public DateTime? FRequestPeriod { get; private set; }

    /// <summary>
    /// TRequestPeriod of the PurchaseRequestAutoDetail
    /// TRequestPeriod الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public DateTime? TRequestPeriod { get; private set; }

    /// <summary>
    /// SaleDay of the PurchaseRequestAutoDetail
    /// SaleDay الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? SaleDay { get; private set; }

    /// <summary>
    /// WeightedUnit of the PurchaseRequestAutoDetail
    /// WeightedUnit الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// WeightedQuantity of the PurchaseRequestAutoDetail
    /// WeightedQuantity الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// ArgumentNumber of the PurchaseRequestAutoDetail
    /// ArgumentNumber الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// SalesOrderQuantity of the PurchaseRequestAutoDetail
    /// SalesOrderQuantity الخاص بـ PurchaseRequestAutoDetail
    /// </summary>
    public decimal? SalesOrderQuantity { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public PurchaseRequestAutoMaster PurchaseRequestAutoMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

