using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// OtherItemAttachment Entity
/// </summary>
public class OtherItemAttachment : Entity<OtherItemAttachmentId>
{
    private OtherItemAttachment() { }

    /// <summary>
    /// The unique identifier for the OtherItemAttachment
    /// المعرف الفريد لـ OtherItemAttachment
    /// </summary>
    public OtherItemAttachmentId Id { get; private set; }

    /// <summary>
    /// ItemCode of the OtherItemAttachment
    /// ItemCode الخاص بـ OtherItemAttachment
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the OtherItemAttachment
    /// ItemUnit الخاص بـ OtherItemAttachment
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the OtherItemAttachment
    /// PSize الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// AttachmentNumber1 of the OtherItemAttachment
    /// AttachmentNumber1 الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? AttachmentNumber1 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber1 of the OtherItemAttachment
    /// AttachmentDescriptionNumber1 الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? AttachmentDescriptionNumber1 { get; private set; }

    /// <summary>
    /// AttachmentNumber2 of the OtherItemAttachment
    /// AttachmentNumber2 الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? AttachmentNumber2 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber2 of the OtherItemAttachment
    /// AttachmentDescriptionNumber2 الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? AttachmentDescriptionNumber2 { get; private set; }

    /// <summary>
    /// AttachmentNumber3 of the OtherItemAttachment
    /// AttachmentNumber3 الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? AttachmentNumber3 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber3 of the OtherItemAttachment
    /// AttachmentDescriptionNumber3 الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? AttachmentDescriptionNumber3 { get; private set; }

    /// <summary>
    /// AttachmentNumber4 of the OtherItemAttachment
    /// AttachmentNumber4 الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? AttachmentNumber4 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber4 of the OtherItemAttachment
    /// AttachmentDescriptionNumber4 الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? AttachmentDescriptionNumber4 { get; private set; }

    /// <summary>
    /// AttachmentNumber5 of the OtherItemAttachment
    /// AttachmentNumber5 الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? AttachmentNumber5 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber5 of the OtherItemAttachment
    /// AttachmentDescriptionNumber5 الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? AttachmentDescriptionNumber5 { get; private set; }

    /// <summary>
    /// FlexField of the OtherItemAttachment
    /// FlexField الخاص بـ OtherItemAttachment
    /// </summary>
    public string FlexField { get; private set; }

    /// <summary>
    /// FlexNumber of the OtherItemAttachment
    /// FlexNumber الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? FlexNumber { get; private set; }

    /// <summary>
    /// AttachmentNote of the OtherItemAttachment
    /// AttachmentNote الخاص بـ OtherItemAttachment
    /// </summary>
    public string AttachmentNote { get; private set; }

    /// <summary>
    /// DocType of the OtherItemAttachment
    /// DocType الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// DocNo of the OtherItemAttachment
    /// DocNo الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the OtherItemAttachment
    /// DocSer الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// WarehouseCode of the OtherItemAttachment
    /// WarehouseCode الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// RecordNumberDocument of the OtherItemAttachment
    /// RecordNumberDocument الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? RecordNumberDocument { get; private set; }

    /// <summary>
    /// InOutFlag of the OtherItemAttachment
    /// InOutFlag الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? InOutFlag { get; private set; }

    /// <summary>
    /// CostCenterCode of the OtherItemAttachment
    /// CostCenterCode الخاص بـ OtherItemAttachment
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ExpireDate of the OtherItemAttachment
    /// ExpireDate الخاص بـ OtherItemAttachment
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the OtherItemAttachment
    /// BatchNumber الخاص بـ OtherItemAttachment
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// ItemQuantity of the OtherItemAttachment
    /// ItemQuantity الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PQuantity of the OtherItemAttachment
    /// PQuantity الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// FreeQuantity of the OtherItemAttachment
    /// FreeQuantity الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// PfQuantity of the OtherItemAttachment
    /// PfQuantity الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? PfQuantity { get; private set; }

    /// <summary>
    /// ReservationQuantity of the OtherItemAttachment
    /// ReservationQuantity الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? ReservationQuantity { get; private set; }

    /// <summary>
    /// RecordNumber of the OtherItemAttachment
    /// RecordNumber الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the OtherItemAttachment
    /// ExternalPostFlag الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CCode of the OtherItemAttachment
    /// CCode الخاص بـ OtherItemAttachment
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// RepCode of the OtherItemAttachment
    /// RepCode الخاص بـ OtherItemAttachment
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the OtherItemAttachment
    /// ReceiveAttachment الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// PrepareDate of the OtherItemAttachment
    /// PrepareDate الخاص بـ OtherItemAttachment
    /// </summary>
    public DateTime? PrepareDate { get; private set; }

    /// <summary>
    /// DeliveryDate of the OtherItemAttachment
    /// DeliveryDate الخاص بـ OtherItemAttachment
    /// </summary>
    public DateTime? DeliveryDate { get; private set; }

    /// <summary>
    /// AnnualFlag of the OtherItemAttachment
    /// AnnualFlag الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? AnnualFlag { get; private set; }

    /// <summary>
    /// DocTypeRef of the OtherItemAttachment
    /// DocTypeRef الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the OtherItemAttachment
    /// DocNoRef الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the OtherItemAttachment
    /// DocSerRef الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// CompanyQuantity of the OtherItemAttachment
    /// CompanyQuantity الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? CompanyQuantity { get; private set; }

    /// <summary>
    /// ReservedFlag of the OtherItemAttachment
    /// ReservedFlag الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? ReservedFlag { get; private set; }

    /// <summary>
    /// TDate of the OtherItemAttachment
    /// TDate الخاص بـ OtherItemAttachment
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// UnblockUserId of the OtherItemAttachment
    /// UnblockUserId الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? UnblockUserId { get; private set; }

    /// <summary>
    /// UnblockDate of the OtherItemAttachment
    /// UnblockDate الخاص بـ OtherItemAttachment
    /// </summary>
    public DateTime? UnblockDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the OtherItemAttachment
    /// CompanyNumberShort الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the OtherItemAttachment
    /// BranchNumber الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the OtherItemAttachment
    /// BranchYear الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the OtherItemAttachment
    /// BranchUser الخاص بـ OtherItemAttachment
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ActivityNumber of the OtherItemAttachment
    /// ActivityNumber الخاص بـ OtherItemAttachment
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ProjectNumber of the OtherItemAttachment
    /// ProjectNumber الخاص بـ OtherItemAttachment
    /// </summary>
    public string ProjectNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemMaster
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
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
