using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Entities
{
/// <summary>
/// MobileNotification Entity
/// </summary>
public class MobileNotification : Entity<MobileNotificationId>
{
    private MobileNotification() { }

    /// <summary>
    /// The unique identifier for the MobileNotification
    /// المعرف الفريد لـ MobileNotification
    /// </summary>
    public MobileNotificationId Id { get; private set; }

    /// <summary>
    /// SystemNumber of the MobileNotification
    /// SystemNumber الخاص بـ MobileNotification
    /// </summary>
    public decimal? SystemNumber { get; private set; }

    /// <summary>
    /// UserId of the MobileNotification
    /// UserId الخاص بـ MobileNotification
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// DvcToken of the MobileNotification
    /// DvcToken الخاص بـ MobileNotification
    /// </summary>
    public string DvcToken { get; private set; }

    /// <summary>
    /// DvsTyp of the MobileNotification
    /// DvsTyp الخاص بـ MobileNotification
    /// </summary>
    public decimal? DvsTyp { get; private set; }

    /// <summary>
    /// HandheldDeviceSerial of the MobileNotification
    /// HandheldDeviceSerial الخاص بـ MobileNotification
    /// </summary>
    public string HandheldDeviceSerial { get; private set; }

    /// <summary>
    /// HandheldDeviceServiceSerial of the MobileNotification
    /// HandheldDeviceServiceSerial الخاص بـ MobileNotification
    /// </summary>
    public string HandheldDeviceServiceSerial { get; private set; }
}
}
