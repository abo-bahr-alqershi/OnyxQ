using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects;
namespace ERP_Pro.Domain.ERP.MessagesNotifications.Entities
{
/// <summary>
/// MessageUserDetail Entity
/// </summary>
public class MessageUserDetail : Entity<MessageUserDetailId>
{

    private MessageUserDetail() { }

    public MessageUserDetail(MessageUserDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the MessageUserDetail
    /// المعرف الفريد لـ MessageUserDetail
    /// </summary>
    public MessageUserDetailId Id { get; private set; }

    /// <summary>
    /// MessageNumber of the MessageUserDetail
    /// MessageNumber الخاص بـ MessageUserDetail
    /// </summary>
    public decimal? MessageNumber { get; private set; }

    /// <summary>
    /// FromUser of the MessageUserDetail
    /// FromUser الخاص بـ MessageUserDetail
    /// </summary>
    public decimal? FromUser { get; private set; }

    /// <summary>
    /// ToUser of the MessageUserDetail
    /// ToUser الخاص بـ MessageUserDetail
    /// </summary>
    public decimal? ToUser { get; private set; }

    /// <summary>
    /// MessageReadFlag of the MessageUserDetail
    /// MessageReadFlag الخاص بـ MessageUserDetail
    /// </summary>
    public decimal? MessageReadFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the MessageUserDetail
    /// CompanyNumberShort الخاص بـ MessageUserDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the MessageUserDetail
    /// BranchNumber الخاص بـ MessageUserDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the MessageUserDetail
    /// BranchYear الخاص بـ MessageUserDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the MessageUserDetail
    /// BranchUser الخاص بـ MessageUserDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public MessageUser MessageUser { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

