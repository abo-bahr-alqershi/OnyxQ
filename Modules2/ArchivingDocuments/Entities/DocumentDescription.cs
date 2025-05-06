using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects;
namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Entities
{
/// <summary>
/// DocumentDescription Entity
/// </summary>
public class DocumentDescription : Entity<DocumentDescriptionId>
{

    private DocumentDescription() { }

    public DocumentDescription(DocumentDescriptionId id, decimal? descNo)
    {
        Id = id;
        DescNo = descNo;
    }

    /// <summary>
    /// The unique identifier for the DocumentDescription
    /// المعرف الفريد لـ DocumentDescription
    /// </summary>
    public DocumentDescriptionId Id { get; private set; }

    /// <summary>
    /// DescNo of the DocumentDescription
    /// DescNo الخاص بـ DocumentDescription
    /// </summary>
    public decimal? DescNo { get; private set; }

    /// <summary>
    /// AccountCode of the DocumentDescription
    /// AccountCode الخاص بـ DocumentDescription
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// DescADoc of the DocumentDescription
    /// DescADoc الخاص بـ DocumentDescription
    /// </summary>
    public string DescADoc { get; private set; }

    /// <summary>
    /// DescEDoc of the DocumentDescription
    /// DescEDoc الخاص بـ DocumentDescription
    /// </summary>
    public string DescEDoc { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

