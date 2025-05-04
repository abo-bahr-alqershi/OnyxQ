using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Entities
{
/// <summary>
/// MessageCss Entity
/// </summary>
public class MessageCss : Entity<MessageCssId>
{
    private MessageCss() { }

    /// <summary>
    /// The unique identifier for the MessageCss
    /// المعرف الفريد لـ MessageCss
    /// </summary>
    public MessageCssId Id { get; private set; }

    /// <summary>
    /// MessageSource of the MessageCss
    /// MessageSource الخاص بـ MessageCss
    /// </summary>
    public decimal? MessageSource { get; private set; }

    /// <summary>
    /// MessageNumber of the MessageCss
    /// MessageNumber الخاص بـ MessageCss
    /// </summary>
    public decimal? MessageNumber { get; private set; }

    /// <summary>
    /// MessageSubject of the MessageCss
    /// MessageSubject الخاص بـ MessageCss
    /// </summary>
    public string MessageSubject { get; private set; }

    /// <summary>
    /// MessageText of the MessageCss
    /// MessageText الخاص بـ MessageCss
    /// </summary>
    public string MessageText { get; private set; }

    /// <summary>
    /// CCode of the MessageCss
    /// CCode الخاص بـ MessageCss
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// MessageReadFlagShort of the MessageCss
    /// MessageReadFlagShort الخاص بـ MessageCss
    /// </summary>
    public decimal? MessageReadFlagShort { get; private set; }

    /// <summary>
    /// MessageDate of the MessageCss
    /// MessageDate الخاص بـ MessageCss
    /// </summary>
    public DateTime? MessageDate { get; private set; }
}
}
