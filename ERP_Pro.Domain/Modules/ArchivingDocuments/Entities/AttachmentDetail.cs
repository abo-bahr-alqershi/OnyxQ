using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Entities
{
/// <summary>
/// AttachmentDetail Entity
/// </summary>
public class AttachmentDetail : Entity<AttachmentDetailId>
{

    private AttachmentDetail() { }

    public AttachmentDetail(AttachmentDetailId id, decimal? attachmentDescriptionNumber)
    {
        Id = id;
        AttachmentDescriptionNumber = attachmentDescriptionNumber;
    }

    /// <summary>
    /// The unique identifier for the AttachmentDetail
    /// المعرف الفريد لـ AttachmentDetail
    /// </summary>
    public AttachmentDetailId Id { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber of the AttachmentDetail
    /// AttachmentDescriptionNumber الخاص بـ AttachmentDetail
    /// </summary>
    public decimal? AttachmentDescriptionNumber { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNameArabic of the AttachmentDetail
    /// AttachmentDescriptionNameArabic الخاص بـ AttachmentDetail
    /// </summary>
    public string AttachmentDescriptionNameArabic { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNameEnglish of the AttachmentDetail
    /// AttachmentDescriptionNameEnglish الخاص بـ AttachmentDetail
    /// </summary>
    public string AttachmentDescriptionNameEnglish { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AttachmentMaster AttachmentMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
