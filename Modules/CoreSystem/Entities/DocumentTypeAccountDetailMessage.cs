using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// DocumentTypeAccountDetailMessage Entity
/// </summary>
public class DocumentTypeAccountDetailMessage : Entity<DocumentTypeAccountDetailMessageId>
{
    private DocumentTypeAccountDetailMessage() { }

    /// <summary>
    /// The unique identifier for the DocumentTypeAccountDetailMessage
    /// المعرف الفريد لـ DocumentTypeAccountDetailMessage
    /// </summary>
    public DocumentTypeAccountDetailMessageId Id { get; private set; }

    /// <summary>
    /// DocTyp of the DocumentTypeAccountDetailMessage
    /// DocTyp الخاص بـ DocumentTypeAccountDetailMessage
    /// </summary>
    public decimal? DocTyp { get; private set; }

    /// <summary>
    /// AccountDetailType of the DocumentTypeAccountDetailMessage
    /// AccountDetailType الخاص بـ DocumentTypeAccountDetailMessage
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// MessageText of the DocumentTypeAccountDetailMessage
    /// MessageText الخاص بـ DocumentTypeAccountDetailMessage
    /// </summary>
    public string MessageText { get; private set; }

    /// <summary>
    /// OrderNumberShort of the DocumentTypeAccountDetailMessage
    /// OrderNumberShort الخاص بـ DocumentTypeAccountDetailMessage
    /// </summary>
    public decimal? OrderNumberShort { get; private set; }

    /// <summary>
    /// InactiveFlagAlt of the DocumentTypeAccountDetailMessage
    /// InactiveFlagAlt الخاص بـ DocumentTypeAccountDetailMessage
    /// </summary>
    public decimal? InactiveFlagAlt { get; private set; }

    /// <summary>
    /// InactiveDateAlt of the DocumentTypeAccountDetailMessage
    /// InactiveDateAlt الخاص بـ DocumentTypeAccountDetailMessage
    /// </summary>
    public DateTime? InactiveDateAlt { get; private set; }

    /// <summary>
    /// InactiveUserNumber of the DocumentTypeAccountDetailMessage
    /// InactiveUserNumber الخاص بـ DocumentTypeAccountDetailMessage
    /// </summary>
    public decimal? InactiveUserNumber { get; private set; }

    /// <summary>
    /// InactiveReasonAlt of the DocumentTypeAccountDetailMessage
    /// InactiveReasonAlt الخاص بـ DocumentTypeAccountDetailMessage
    /// </summary>
    public string InactiveReasonAlt { get; private set; }

    /// <summary>
    /// MessageTextSpecialFlag of the DocumentTypeAccountDetailMessage
    /// MessageTextSpecialFlag الخاص بـ DocumentTypeAccountDetailMessage
    /// </summary>
    public decimal? MessageTextSpecialFlag { get; private set; }
}
}
