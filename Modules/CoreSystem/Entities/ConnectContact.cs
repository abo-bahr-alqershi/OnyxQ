using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// ConnectContact Entity
/// </summary>
public class ConnectContact : Entity<ConnectContactId>
{
    private ConnectContact() { }

    /// <summary>
    /// The unique identifier for the ConnectContact
    /// المعرف الفريد لـ ConnectContact
    /// </summary>
    public ConnectContactId Id { get; private set; }

    /// <summary>
    /// ConnectionContactNumber of the ConnectContact
    /// ConnectionContactNumber الخاص بـ ConnectContact
    /// </summary>
    public decimal? ConnectionContactNumber { get; private set; }

    /// <summary>
    /// ContactCode of the ConnectContact
    /// ContactCode الخاص بـ ConnectContact
    /// </summary>
    public decimal? ContactCode { get; private set; }

    /// <summary>
    /// ContactType of the ConnectContact
    /// ContactType الخاص بـ ConnectContact
    /// </summary>
    public decimal? ContactType { get; private set; }

    /// <summary>
    /// ContactNumber of the ConnectContact
    /// ContactNumber الخاص بـ ConnectContact
    /// </summary>
    public decimal? ContactNumber { get; private set; }

    /// <summary>
    /// ContactDescription of the ConnectContact
    /// ContactDescription الخاص بـ ConnectContact
    /// </summary>
    public string ContactDescription { get; private set; }

    /// <summary>
    /// OrderNumberShort of the ConnectContact
    /// OrderNumberShort الخاص بـ ConnectContact
    /// </summary>
    public decimal? OrderNumberShort { get; private set; }

    /// <summary>
    /// Notes of the ConnectContact
    /// Notes الخاص بـ ConnectContact
    /// </summary>
    public string Notes { get; private set; }

    /// <summary>
    /// ContactFavorite of the ConnectContact
    /// ContactFavorite الخاص بـ ConnectContact
    /// </summary>
    public decimal? ContactFavorite { get; private set; }

    /// <summary>
    /// InactiveFlagAlt of the ConnectContact
    /// InactiveFlagAlt الخاص بـ ConnectContact
    /// </summary>
    public decimal? InactiveFlagAlt { get; private set; }

    /// <summary>
    /// InactiveReasonAlt of the ConnectContact
    /// InactiveReasonAlt الخاص بـ ConnectContact
    /// </summary>
    public string InactiveReasonAlt { get; private set; }

    /// <summary>
    /// InactiveUser of the ConnectContact
    /// InactiveUser الخاص بـ ConnectContact
    /// </summary>
    public decimal? InactiveUser { get; private set; }

    /// <summary>
    /// InactiveDateAlt of the ConnectContact
    /// InactiveDateAlt الخاص بـ ConnectContact
    /// </summary>
    public DateTime? InactiveDateAlt { get; private set; }
}
}
