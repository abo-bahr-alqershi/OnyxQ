using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// DocumentTypeMessage Entity
/// </summary>
public class DocumentTypeMessage : Entity<DocumentTypeMessageId>
{
    private DocumentTypeMessage() { }

    /// <summary>
    /// The unique identifier for the DocumentTypeMessage
    /// المعرف الفريد لـ DocumentTypeMessage
    /// </summary>
    public DocumentTypeMessageId Id { get; private set; }

    /// <summary>
    /// DocTyp of the DocumentTypeMessage
    /// DocTyp الخاص بـ DocumentTypeMessage
    /// </summary>
    public decimal? DocTyp { get; private set; }

    /// <summary>
    /// InactiveFlagAlt of the DocumentTypeMessage
    /// InactiveFlagAlt الخاص بـ DocumentTypeMessage
    /// </summary>
    public decimal? InactiveFlagAlt { get; private set; }

    /// <summary>
    /// OrderNumberShort of the DocumentTypeMessage
    /// OrderNumberShort الخاص بـ DocumentTypeMessage
    /// </summary>
    public decimal? OrderNumberShort { get; private set; }
}
}
