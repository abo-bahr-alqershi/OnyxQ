using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// BranchItemAttachmentMovement Entity
/// </summary>
public class BranchItemAttachmentMovement : Entity<BranchItemAttachmentMovementId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<Project> _project = new List<Project>();

    private BranchItemAttachmentMovement() { }

    public BranchItemAttachmentMovement(BranchItemAttachmentMovementId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the BranchItemAttachmentMovement
    /// المعرف الفريد لـ BranchItemAttachmentMovement
    /// </summary>
    public BranchItemAttachmentMovementId Id { get; private set; }

    /// <summary>
    /// ItemCode of the BranchItemAttachmentMovement
    /// ItemCode الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the BranchItemAttachmentMovement
    /// ItemUnit الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the BranchItemAttachmentMovement
    /// PSize الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// AttachmentNumber1 of the BranchItemAttachmentMovement
    /// AttachmentNumber1 الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? AttachmentNumber1 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber1 of the BranchItemAttachmentMovement
    /// AttachmentDescriptionNumber1 الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? AttachmentDescriptionNumber1 { get; private set; }

    /// <summary>
    /// AttachmentNumber2 of the BranchItemAttachmentMovement
    /// AttachmentNumber2 الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? AttachmentNumber2 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber2 of the BranchItemAttachmentMovement
    /// AttachmentDescriptionNumber2 الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? AttachmentDescriptionNumber2 { get; private set; }

    /// <summary>
    /// AttachmentNumber3 of the BranchItemAttachmentMovement
    /// AttachmentNumber3 الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? AttachmentNumber3 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber3 of the BranchItemAttachmentMovement
    /// AttachmentDescriptionNumber3 الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? AttachmentDescriptionNumber3 { get; private set; }

    /// <summary>
    /// AttachmentNumber4 of the BranchItemAttachmentMovement
    /// AttachmentNumber4 الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? AttachmentNumber4 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber4 of the BranchItemAttachmentMovement
    /// AttachmentDescriptionNumber4 الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? AttachmentDescriptionNumber4 { get; private set; }

    /// <summary>
    /// AttachmentNumber5 of the BranchItemAttachmentMovement
    /// AttachmentNumber5 الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? AttachmentNumber5 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber5 of the BranchItemAttachmentMovement
    /// AttachmentDescriptionNumber5 الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? AttachmentDescriptionNumber5 { get; private set; }

    /// <summary>
    /// FlexField of the BranchItemAttachmentMovement
    /// FlexField الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public string FlexField { get; private set; }

    /// <summary>
    /// FlexNumber of the BranchItemAttachmentMovement
    /// FlexNumber الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? FlexNumber { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the BranchItemAttachmentMovement
    /// ReceiveAttachment الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// AttachmentNote of the BranchItemAttachmentMovement
    /// AttachmentNote الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public string AttachmentNote { get; private set; }

    /// <summary>
    /// DocType of the BranchItemAttachmentMovement
    /// DocType الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the BranchItemAttachmentMovement
    /// BillDocumentTypeFull الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// DocNo of the BranchItemAttachmentMovement
    /// DocNo الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the BranchItemAttachmentMovement
    /// DocSer الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// WarehouseCode of the BranchItemAttachmentMovement
    /// WarehouseCode الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// BillCost of the BranchItemAttachmentMovement
    /// BillCost الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? BillCost { get; private set; }

    /// <summary>
    /// RecordNumberDocument of the BranchItemAttachmentMovement
    /// RecordNumberDocument الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? RecordNumberDocument { get; private set; }

    /// <summary>
    /// InOutFlag of the BranchItemAttachmentMovement
    /// InOutFlag الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? InOutFlag { get; private set; }

    /// <summary>
    /// CostCenterCode of the BranchItemAttachmentMovement
    /// CostCenterCode الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// RepCode of the BranchItemAttachmentMovement
    /// RepCode الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// RegionCode of the BranchItemAttachmentMovement
    /// RegionCode الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// CCode of the BranchItemAttachmentMovement
    /// CCode الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// ExpireDate of the BranchItemAttachmentMovement
    /// ExpireDate الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the BranchItemAttachmentMovement
    /// BatchNumber الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// ItemQuantity of the BranchItemAttachmentMovement
    /// ItemQuantity الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PQuantity of the BranchItemAttachmentMovement
    /// PQuantity الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// FreeQuantity of the BranchItemAttachmentMovement
    /// FreeQuantity الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// PfQuantity of the BranchItemAttachmentMovement
    /// PfQuantity الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? PfQuantity { get; private set; }

    /// <summary>
    /// RecordNumber of the BranchItemAttachmentMovement
    /// RecordNumber الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchItemAttachmentMovement
    /// ExternalPostFlag الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// DocTypeRef of the BranchItemAttachmentMovement
    /// DocTypeRef الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the BranchItemAttachmentMovement
    /// DocNoRef الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the BranchItemAttachmentMovement
    /// DocSerRef الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// OutgoingNumber of the BranchItemAttachmentMovement
    /// OutgoingNumber الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? OutgoingNumber { get; private set; }

    /// <summary>
    /// OutgoingGroupSerial of the BranchItemAttachmentMovement
    /// OutgoingGroupSerial الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? OutgoingGroupSerial { get; private set; }

    /// <summary>
    /// DocDate of the BranchItemAttachmentMovement
    /// DocDate الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AccountCurrency of the BranchItemAttachmentMovement
    /// AccountCurrency الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the BranchItemAttachmentMovement
    /// AccountRate الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// StockRate of the BranchItemAttachmentMovement
    /// StockRate الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? StockRate { get; private set; }

    /// <summary>
    /// ItemPriceShort of the BranchItemAttachmentMovement
    /// ItemPriceShort الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// DisAmt of the BranchItemAttachmentMovement
    /// DisAmt الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// ItemCostShort of the BranchItemAttachmentMovement
    /// ItemCostShort الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? ItemCostShort { get; private set; }

    /// <summary>
    /// StockCost of the BranchItemAttachmentMovement
    /// StockCost الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// VatAmount of the BranchItemAttachmentMovement
    /// VatAmount الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// OtherAmount of the BranchItemAttachmentMovement
    /// OtherAmount الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// VendorCode of the BranchItemAttachmentMovement
    /// VendorCode الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// ReturnTypeAlt of the BranchItemAttachmentMovement
    /// ReturnTypeAlt الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? ReturnTypeAlt { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchItemAttachmentMovement
    /// CompanyNumberShort الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchItemAttachmentMovement
    /// BranchNumber الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchItemAttachmentMovement
    /// BranchYear الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchItemAttachmentMovement
    /// BranchUser الخاص بـ BranchItemAttachmentMovement
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Activity> Activity => _activity;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Project> Project => _project;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

