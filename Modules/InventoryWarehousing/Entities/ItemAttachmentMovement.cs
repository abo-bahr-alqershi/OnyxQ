using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemAttachmentMovement Entity
/// </summary>
public class ItemAttachmentMovement : Entity<ItemAttachmentMovementId>
{
    private ItemAttachmentMovement() { }

    /// <summary>
    /// The unique identifier for the ItemAttachmentMovement
    /// المعرف الفريد لـ ItemAttachmentMovement
    /// </summary>
    public ItemAttachmentMovementId Id { get; private set; }

    /// <summary>
    /// ItemCode of the ItemAttachmentMovement
    /// ItemCode الخاص بـ ItemAttachmentMovement
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the ItemAttachmentMovement
    /// ItemUnit الخاص بـ ItemAttachmentMovement
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the ItemAttachmentMovement
    /// PSize الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// AttachmentNumber1 of the ItemAttachmentMovement
    /// AttachmentNumber1 الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? AttachmentNumber1 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber1 of the ItemAttachmentMovement
    /// AttachmentDescriptionNumber1 الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? AttachmentDescriptionNumber1 { get; private set; }

    /// <summary>
    /// AttachmentNumber2 of the ItemAttachmentMovement
    /// AttachmentNumber2 الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? AttachmentNumber2 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber2 of the ItemAttachmentMovement
    /// AttachmentDescriptionNumber2 الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? AttachmentDescriptionNumber2 { get; private set; }

    /// <summary>
    /// AttachmentNumber3 of the ItemAttachmentMovement
    /// AttachmentNumber3 الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? AttachmentNumber3 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber3 of the ItemAttachmentMovement
    /// AttachmentDescriptionNumber3 الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? AttachmentDescriptionNumber3 { get; private set; }

    /// <summary>
    /// AttachmentNumber4 of the ItemAttachmentMovement
    /// AttachmentNumber4 الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? AttachmentNumber4 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber4 of the ItemAttachmentMovement
    /// AttachmentDescriptionNumber4 الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? AttachmentDescriptionNumber4 { get; private set; }

    /// <summary>
    /// AttachmentNumber5 of the ItemAttachmentMovement
    /// AttachmentNumber5 الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? AttachmentNumber5 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber5 of the ItemAttachmentMovement
    /// AttachmentDescriptionNumber5 الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? AttachmentDescriptionNumber5 { get; private set; }

    /// <summary>
    /// FlexField of the ItemAttachmentMovement
    /// FlexField الخاص بـ ItemAttachmentMovement
    /// </summary>
    public string FlexField { get; private set; }

    /// <summary>
    /// FlexNumber of the ItemAttachmentMovement
    /// FlexNumber الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? FlexNumber { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the ItemAttachmentMovement
    /// ReceiveAttachment الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// AttachmentNote of the ItemAttachmentMovement
    /// AttachmentNote الخاص بـ ItemAttachmentMovement
    /// </summary>
    public string AttachmentNote { get; private set; }

    /// <summary>
    /// DocType of the ItemAttachmentMovement
    /// DocType الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the ItemAttachmentMovement
    /// BillDocumentTypeFull الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// DocNo of the ItemAttachmentMovement
    /// DocNo الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the ItemAttachmentMovement
    /// DocSer الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// WarehouseCode of the ItemAttachmentMovement
    /// WarehouseCode الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// BillCost of the ItemAttachmentMovement
    /// BillCost الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? BillCost { get; private set; }

    /// <summary>
    /// RecordNumberDocument of the ItemAttachmentMovement
    /// RecordNumberDocument الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? RecordNumberDocument { get; private set; }

    /// <summary>
    /// InOutFlag of the ItemAttachmentMovement
    /// InOutFlag الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? InOutFlag { get; private set; }

    /// <summary>
    /// CostCenterCode of the ItemAttachmentMovement
    /// CostCenterCode الخاص بـ ItemAttachmentMovement
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the ItemAttachmentMovement
    /// ProjectNumber الخاص بـ ItemAttachmentMovement
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the ItemAttachmentMovement
    /// ActivityNumber الخاص بـ ItemAttachmentMovement
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// RepCode of the ItemAttachmentMovement
    /// RepCode الخاص بـ ItemAttachmentMovement
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// RegionCode of the ItemAttachmentMovement
    /// RegionCode الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// CCode of the ItemAttachmentMovement
    /// CCode الخاص بـ ItemAttachmentMovement
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// ExpireDate of the ItemAttachmentMovement
    /// ExpireDate الخاص بـ ItemAttachmentMovement
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the ItemAttachmentMovement
    /// BatchNumber الخاص بـ ItemAttachmentMovement
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// ItemQuantity of the ItemAttachmentMovement
    /// ItemQuantity الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PQuantity of the ItemAttachmentMovement
    /// PQuantity الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// FreeQuantity of the ItemAttachmentMovement
    /// FreeQuantity الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// PfQuantity of the ItemAttachmentMovement
    /// PfQuantity الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? PfQuantity { get; private set; }

    /// <summary>
    /// RecordNumber of the ItemAttachmentMovement
    /// RecordNumber الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the ItemAttachmentMovement
    /// ExternalPostFlag الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// DocTypeRef of the ItemAttachmentMovement
    /// DocTypeRef الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the ItemAttachmentMovement
    /// DocNoRef الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the ItemAttachmentMovement
    /// DocSerRef الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// OutgoingNumber of the ItemAttachmentMovement
    /// OutgoingNumber الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? OutgoingNumber { get; private set; }

    /// <summary>
    /// OutgoingGroupSerial of the ItemAttachmentMovement
    /// OutgoingGroupSerial الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? OutgoingGroupSerial { get; private set; }

    /// <summary>
    /// DocDate of the ItemAttachmentMovement
    /// DocDate الخاص بـ ItemAttachmentMovement
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AccountCurrency of the ItemAttachmentMovement
    /// AccountCurrency الخاص بـ ItemAttachmentMovement
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the ItemAttachmentMovement
    /// AccountRate الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// StockRate of the ItemAttachmentMovement
    /// StockRate الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? StockRate { get; private set; }

    /// <summary>
    /// ItemPriceShort of the ItemAttachmentMovement
    /// ItemPriceShort الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// DisAmt of the ItemAttachmentMovement
    /// DisAmt الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// ItemCostShort of the ItemAttachmentMovement
    /// ItemCostShort الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? ItemCostShort { get; private set; }

    /// <summary>
    /// StockCost of the ItemAttachmentMovement
    /// StockCost الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// VatAmount of the ItemAttachmentMovement
    /// VatAmount الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// OtherAmount of the ItemAttachmentMovement
    /// OtherAmount الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// VendorCode of the ItemAttachmentMovement
    /// VendorCode الخاص بـ ItemAttachmentMovement
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// ReturnTypeAlt of the ItemAttachmentMovement
    /// ReturnTypeAlt الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? ReturnTypeAlt { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ItemAttachmentMovement
    /// CompanyNumberShort الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ItemAttachmentMovement
    /// BranchNumber الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ItemAttachmentMovement
    /// BranchYear الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ItemAttachmentMovement
    /// BranchUser الخاص بـ ItemAttachmentMovement
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ItemMaster
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Project
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Warehouse
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion
}
}
