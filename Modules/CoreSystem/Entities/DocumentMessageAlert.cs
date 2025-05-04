using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// DocumentMessageAlert Entity
/// </summary>
public class DocumentMessageAlert : Entity<DocumentMessageAlertId>
{
    private DocumentMessageAlert() { }

    /// <summary>
    /// The unique identifier for the DocumentMessageAlert
    /// المعرف الفريد لـ DocumentMessageAlert
    /// </summary>
    public DocumentMessageAlertId Id { get; private set; }

    /// <summary>
    /// DocTyp of the DocumentMessageAlert
    /// DocTyp الخاص بـ DocumentMessageAlert
    /// </summary>
    public decimal? DocTyp { get; private set; }

    /// <summary>
    /// MessageText of the DocumentMessageAlert
    /// MessageText الخاص بـ DocumentMessageAlert
    /// </summary>
    public string MessageText { get; private set; }

    /// <summary>
    /// AlertFlag of the DocumentMessageAlert
    /// AlertFlag الخاص بـ DocumentMessageAlert
    /// </summary>
    public decimal? AlertFlag { get; private set; }

    /// <summary>
    /// OrderNumberShort of the DocumentMessageAlert
    /// OrderNumberShort الخاص بـ DocumentMessageAlert
    /// </summary>
    public decimal? OrderNumberShort { get; private set; }

    /// <summary>
    /// SendType of the DocumentMessageAlert
    /// SendType الخاص بـ DocumentMessageAlert
    /// </summary>
    public decimal? SendType { get; private set; }

    /// <summary>
    /// InactiveFlagAlt of the DocumentMessageAlert
    /// InactiveFlagAlt الخاص بـ DocumentMessageAlert
    /// </summary>
    public decimal? InactiveFlagAlt { get; private set; }

    /// <summary>
    /// InactiveDateAlt of the DocumentMessageAlert
    /// InactiveDateAlt الخاص بـ DocumentMessageAlert
    /// </summary>
    public DateTime? InactiveDateAlt { get; private set; }

    /// <summary>
    /// InactiveUserNumber of the DocumentMessageAlert
    /// InactiveUserNumber الخاص بـ DocumentMessageAlert
    /// </summary>
    public decimal? InactiveUserNumber { get; private set; }

    /// <summary>
    /// InactiveReasonAlt of the DocumentMessageAlert
    /// InactiveReasonAlt الخاص بـ DocumentMessageAlert
    /// </summary>
    public string InactiveReasonAlt { get; private set; }
}
}
