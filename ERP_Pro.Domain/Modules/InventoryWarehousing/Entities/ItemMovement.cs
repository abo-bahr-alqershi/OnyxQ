using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemMovement Entity
/// </summary>
public class ItemMovement : Entity<ItemMovementId>
{

    private ItemMovement() { }

    public ItemMovement(ItemMovementId id, decimal? serial)
    {
        Id = id;
        Serial = serial;
    }

    /// <summary>
    /// The unique identifier for the ItemMovement
    /// المعرف الفريد لـ ItemMovement
    /// </summary>
    public ItemMovementId Id { get; private set; }

    /// <summary>
    /// DocType of the ItemMovement
    /// DocType الخاص بـ ItemMovement
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the ItemMovement
    /// BillDocumentTypeFull الخاص بـ ItemMovement
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// DocNo of the ItemMovement
    /// DocNo الخاص بـ ItemMovement
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// ItemQuantity of the ItemMovement
    /// ItemQuantity الخاص بـ ItemMovement
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// FreeQuantity of the ItemMovement
    /// FreeQuantity الخاص بـ ItemMovement
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// PSize of the ItemMovement
    /// PSize الخاص بـ ItemMovement
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the ItemMovement
    /// PQuantity الخاص بـ ItemMovement
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// PfQuantity of the ItemMovement
    /// PfQuantity الخاص بـ ItemMovement
    /// </summary>
    public decimal? PfQuantity { get; private set; }

    /// <summary>
    /// ItemDate of the ItemMovement
    /// ItemDate الخاص بـ ItemMovement
    /// </summary>
    public DateTime? ItemDate { get; private set; }

    /// <summary>
    /// ItemCostShort of the ItemMovement
    /// ItemCostShort الخاص بـ ItemMovement
    /// </summary>
    public decimal? ItemCostShort { get; private set; }

    /// <summary>
    /// WarehouseGroupCode of the ItemMovement
    /// WarehouseGroupCode الخاص بـ ItemMovement
    /// </summary>
    public decimal? WarehouseGroupCode { get; private set; }

    /// <summary>
    /// StockCost of the ItemMovement
    /// StockCost الخاص بـ ItemMovement
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// VatAmount of the ItemMovement
    /// VatAmount الخاص بـ ItemMovement
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// DisAmt of the ItemMovement
    /// DisAmt الخاص بـ ItemMovement
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// AccountCurrency of the ItemMovement
    /// AccountCurrency الخاص بـ ItemMovement
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the ItemMovement
    /// AccountRate الخاص بـ ItemMovement
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// StockRate of the ItemMovement
    /// StockRate الخاص بـ ItemMovement
    /// </summary>
    public decimal? StockRate { get; private set; }

    /// <summary>
    /// CostCenterCode of the ItemMovement
    /// CostCenterCode الخاص بـ ItemMovement
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the ItemMovement
    /// ProjectNumber الخاص بـ ItemMovement
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// AccountDetailCode of the ItemMovement
    /// AccountDetailCode الخاص بـ ItemMovement
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the ItemMovement
    /// AccountDetailType الخاص بـ ItemMovement
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// CCode of the ItemMovement
    /// CCode الخاص بـ ItemMovement
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// VendorCode of the ItemMovement
    /// VendorCode الخاص بـ ItemMovement
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// AccountDescription of the ItemMovement
    /// AccountDescription الخاص بـ ItemMovement
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// GroupNumberFull of the ItemMovement
    /// GroupNumberFull الخاص بـ ItemMovement
    /// </summary>
    public decimal? GroupNumberFull { get; private set; }

    /// <summary>
    /// ExpireDate of the ItemMovement
    /// ExpireDate الخاص بـ ItemMovement
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the ItemMovement
    /// BatchNumber الخاص بـ ItemMovement
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the ItemMovement
    /// RecordNumber الخاص بـ ItemMovement
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// Serial of the ItemMovement
    /// Serial الخاص بـ ItemMovement
    /// </summary>
    public decimal? Serial { get; private set; }

    /// <summary>
    /// ReferenceNumber of the ItemMovement
    /// ReferenceNumber الخاص بـ ItemMovement
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DocSer of the ItemMovement
    /// DocSer الخاص بـ ItemMovement
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// OutgoingNumber of the ItemMovement
    /// OutgoingNumber الخاص بـ ItemMovement
    /// </summary>
    public decimal? OutgoingNumber { get; private set; }

    /// <summary>
    /// OutgoingGroupSerial of the ItemMovement
    /// OutgoingGroupSerial الخاص بـ ItemMovement
    /// </summary>
    public decimal? OutgoingGroupSerial { get; private set; }

    /// <summary>
    /// DocSequence of the ItemMovement
    /// DocSequence الخاص بـ ItemMovement
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// Barcode of the ItemMovement
    /// Barcode الخاص بـ ItemMovement
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// ReturnTypeAlt of the ItemMovement
    /// ReturnTypeAlt الخاص بـ ItemMovement
    /// </summary>
    public decimal? ReturnTypeAlt { get; private set; }

    /// <summary>
    /// InOutFlag of the ItemMovement
    /// InOutFlag الخاص بـ ItemMovement
    /// </summary>
    public decimal? InOutFlag { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the ItemMovement
    /// ExternalPostFlag الخاص بـ ItemMovement
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// ItemLength of the ItemMovement
    /// ItemLength الخاص بـ ItemMovement
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the ItemMovement
    /// ItemWidth الخاص بـ ItemMovement
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the ItemMovement
    /// ItemHeightShort الخاص بـ ItemMovement
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the ItemMovement
    /// ItemNumberShort الخاص بـ ItemMovement
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// WeightedQuantity of the ItemMovement
    /// WeightedQuantity الخاص بـ ItemMovement
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the ItemMovement
    /// WeightedUnit الخاص بـ ItemMovement
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// ArgumentNumber of the ItemMovement
    /// ArgumentNumber الخاص بـ ItemMovement
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ItemMovement
    /// CompanyNumberShort الخاص بـ ItemMovement
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ItemMovement
    /// BranchNumber الخاص بـ ItemMovement
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ItemMovement
    /// BranchYear الخاص بـ ItemMovement
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ItemMovement
    /// BranchUser الخاص بـ ItemMovement
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// FreeType of the ItemMovement
    /// FreeType الخاص بـ ItemMovement
    /// </summary>
    public decimal? FreeType { get; private set; }

    /// <summary>
    /// LevelNumber of the ItemMovement
    /// LevelNumber الخاص بـ ItemMovement
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// ItemPriceVat of the ItemMovement
    /// ItemPriceVat الخاص بـ ItemMovement
    /// </summary>
    public decimal? ItemPriceVat { get; private set; }

    /// <summary>
    /// EmpNo of the ItemMovement
    /// EmpNo الخاص بـ ItemMovement
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// DisAmtMstVat of the ItemMovement
    /// DisAmtMstVat الخاص بـ ItemMovement
    /// </summary>
    public decimal? DisAmtMstVat { get; private set; }

    /// <summary>
    /// DisPer of the ItemMovement
    /// DisPer الخاص بـ ItemMovement
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// DisAmtDtl of the ItemMovement
    /// DisAmtDtl الخاص بـ ItemMovement
    /// </summary>
    public decimal? DisAmtDtl { get; private set; }

    /// <summary>
    /// DisAmtDtlVat of the ItemMovement
    /// DisAmtDtlVat الخاص بـ ItemMovement
    /// </summary>
    public decimal? DisAmtDtlVat { get; private set; }

    /// <summary>
    /// DisPer2 of the ItemMovement
    /// DisPer2 الخاص بـ ItemMovement
    /// </summary>
    public decimal? DisPer2 { get; private set; }

    /// <summary>
    /// DisAmtDtl2 of the ItemMovement
    /// DisAmtDtl2 الخاص بـ ItemMovement
    /// </summary>
    public decimal? DisAmtDtl2 { get; private set; }

    /// <summary>
    /// DisAmtDtl2Vat of the ItemMovement
    /// DisAmtDtl2Vat الخاص بـ ItemMovement
    /// </summary>
    public decimal? DisAmtDtl2Vat { get; private set; }

    /// <summary>
    /// DisPer3 of the ItemMovement
    /// DisPer3 الخاص بـ ItemMovement
    /// </summary>
    public decimal? DisPer3 { get; private set; }

    /// <summary>
    /// DisAmtDtl3 of the ItemMovement
    /// DisAmtDtl3 الخاص بـ ItemMovement
    /// </summary>
    public decimal? DisAmtDtl3 { get; private set; }

    /// <summary>
    /// DisAmtDtl3Vat of the ItemMovement
    /// DisAmtDtl3Vat الخاص بـ ItemMovement
    /// </summary>
    public decimal? DisAmtDtl3Vat { get; private set; }

    /// <summary>
    /// OtherAmount of the ItemMovement
    /// OtherAmount الخاص بـ ItemMovement
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// VatAmountOther of the ItemMovement
    /// VatAmountOther الخاص بـ ItemMovement
    /// </summary>
    public decimal? VatAmountOther { get; private set; }

    /// <summary>
    /// VatPercent of the ItemMovement
    /// VatPercent الخاص بـ ItemMovement
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// DisAmtMst of the ItemMovement
    /// DisAmtMst الخاص بـ ItemMovement
    /// </summary>
    public decimal? DisAmtMst { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
