using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Entities
{
/// <summary>
/// MessageUser Entity
/// </summary>
public class MessageUser : Entity<MessageUserId>
{

    private MessageUser() { }

    public MessageUser(MessageUserId id, decimal? messageSerial)
    {
        Id = id;
        MessageSerial = messageSerial;
    }

    /// <summary>
    /// The unique identifier for the MessageUser
    /// المعرف الفريد لـ MessageUser
    /// </summary>
    public MessageUserId Id { get; private set; }

    /// <summary>
    /// MessageNumber of the MessageUser
    /// MessageNumber الخاص بـ MessageUser
    /// </summary>
    public decimal? MessageNumber { get; private set; }

    /// <summary>
    /// MessageSerial of the MessageUser
    /// MessageSerial الخاص بـ MessageUser
    /// </summary>
    public decimal? MessageSerial { get; private set; }

    /// <summary>
    /// MessageSubjectShort of the MessageUser
    /// MessageSubjectShort الخاص بـ MessageUser
    /// </summary>
    public string MessageSubjectShort { get; private set; }

    /// <summary>
    /// MessageText of the MessageUser
    /// MessageText الخاص بـ MessageUser
    /// </summary>
    public string MessageText { get; private set; }

    /// <summary>
    /// FromUser of the MessageUser
    /// FromUser الخاص بـ MessageUser
    /// </summary>
    public decimal? FromUser { get; private set; }

    /// <summary>
    /// ToUser of the MessageUser
    /// ToUser الخاص بـ MessageUser
    /// </summary>
    public decimal? ToUser { get; private set; }

    /// <summary>
    /// TGroupUser of the MessageUser
    /// TGroupUser الخاص بـ MessageUser
    /// </summary>
    public decimal? TGroupUser { get; private set; }

    /// <summary>
    /// MessageReadFlag of the MessageUser
    /// MessageReadFlag الخاص بـ MessageUser
    /// </summary>
    public decimal? MessageReadFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the MessageUser
    /// CompanyNumberShort الخاص بـ MessageUser
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the MessageUser
    /// BranchNumber الخاص بـ MessageUser
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the MessageUser
    /// BranchYear الخاص بـ MessageUser
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the MessageUser
    /// BranchUser الخاص بـ MessageUser
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
