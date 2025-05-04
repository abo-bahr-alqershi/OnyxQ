using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemAttachment Entity
/// </summary>
public class ItemAttachment : Entity<ItemAttachmentId>
{

    private ItemAttachment() { }

    public ItemAttachment(ItemAttachmentId id, string flexField, decimal? flexNumber)
    {
        Id = id;
        FlexField = flexField;
        FlexNumber = flexNumber;
    }

    /// <summary>
    /// The unique identifier for the ItemAttachment
    /// المعرف الفريد لـ ItemAttachment
    /// </summary>
    public ItemAttachmentId Id { get; private set; }

    /// <summary>
    /// ItemCode of the ItemAttachment
    /// ItemCode الخاص بـ ItemAttachment
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// AttachmentNumber1 of the ItemAttachment
    /// AttachmentNumber1 الخاص بـ ItemAttachment
    /// </summary>
    public decimal? AttachmentNumber1 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber1 of the ItemAttachment
    /// AttachmentDescriptionNumber1 الخاص بـ ItemAttachment
    /// </summary>
    public decimal? AttachmentDescriptionNumber1 { get; private set; }

    /// <summary>
    /// AttachmentNumber2 of the ItemAttachment
    /// AttachmentNumber2 الخاص بـ ItemAttachment
    /// </summary>
    public decimal? AttachmentNumber2 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber2 of the ItemAttachment
    /// AttachmentDescriptionNumber2 الخاص بـ ItemAttachment
    /// </summary>
    public decimal? AttachmentDescriptionNumber2 { get; private set; }

    /// <summary>
    /// AttachmentNumber3 of the ItemAttachment
    /// AttachmentNumber3 الخاص بـ ItemAttachment
    /// </summary>
    public decimal? AttachmentNumber3 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber3 of the ItemAttachment
    /// AttachmentDescriptionNumber3 الخاص بـ ItemAttachment
    /// </summary>
    public decimal? AttachmentDescriptionNumber3 { get; private set; }

    /// <summary>
    /// AttachmentNumber4 of the ItemAttachment
    /// AttachmentNumber4 الخاص بـ ItemAttachment
    /// </summary>
    public decimal? AttachmentNumber4 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber4 of the ItemAttachment
    /// AttachmentDescriptionNumber4 الخاص بـ ItemAttachment
    /// </summary>
    public decimal? AttachmentDescriptionNumber4 { get; private set; }

    /// <summary>
    /// AttachmentNumber5 of the ItemAttachment
    /// AttachmentNumber5 الخاص بـ ItemAttachment
    /// </summary>
    public decimal? AttachmentNumber5 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber5 of the ItemAttachment
    /// AttachmentDescriptionNumber5 الخاص بـ ItemAttachment
    /// </summary>
    public decimal? AttachmentDescriptionNumber5 { get; private set; }

    /// <summary>
    /// FlexField of the ItemAttachment
    /// FlexField الخاص بـ ItemAttachment
    /// </summary>
    public string FlexField { get; private set; }

    /// <summary>
    /// FlexNumber of the ItemAttachment
    /// FlexNumber الخاص بـ ItemAttachment
    /// </summary>
    public decimal? FlexNumber { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
