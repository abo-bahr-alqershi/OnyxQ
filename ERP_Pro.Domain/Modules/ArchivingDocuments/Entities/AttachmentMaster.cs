using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Entities
{
/// <summary>
/// AttachmentMaster Entity
/// </summary>
public class AttachmentMaster : Entity<AttachmentMasterId>
{

    private AttachmentMaster() { }

    public AttachmentMaster(AttachmentMasterId id, decimal? attachmentNumber)
    {
        Id = id;
        AttachmentNumber = attachmentNumber;
    }

    /// <summary>
    /// The unique identifier for the AttachmentMaster
    /// المعرف الفريد لـ AttachmentMaster
    /// </summary>
    public AttachmentMasterId Id { get; private set; }

    /// <summary>
    /// AttachmentNumber of the AttachmentMaster
    /// AttachmentNumber الخاص بـ AttachmentMaster
    /// </summary>
    public decimal? AttachmentNumber { get; private set; }

    /// <summary>
    /// AttachmentNameArabic of the AttachmentMaster
    /// AttachmentNameArabic الخاص بـ AttachmentMaster
    /// </summary>
    public string AttachmentNameArabic { get; private set; }

    /// <summary>
    /// AttachmentNameEnglish of the AttachmentMaster
    /// AttachmentNameEnglish الخاص بـ AttachmentMaster
    /// </summary>
    public string AttachmentNameEnglish { get; private set; }

    /// <summary>
    /// OptionalFlag of the AttachmentMaster
    /// OptionalFlag الخاص بـ AttachmentMaster
    /// </summary>
    public decimal? OptionalFlag { get; private set; }

    /// <summary>
    /// ConnectionCCode of the AttachmentMaster
    /// ConnectionCCode الخاص بـ AttachmentMaster
    /// </summary>
    public decimal? ConnectionCCode { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
