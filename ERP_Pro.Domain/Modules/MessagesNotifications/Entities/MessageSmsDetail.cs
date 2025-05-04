using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Entities
{
/// <summary>
/// MessageSmsDetail Entity
/// </summary>
public class MessageSmsDetail : Entity<MessageSmsDetailId>
{

    private MessageSmsDetail() { }

    public MessageSmsDetail(MessageSmsDetailId id, decimal? recordNumber)
    {
        Id = id;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// The unique identifier for the MessageSmsDetail
    /// المعرف الفريد لـ MessageSmsDetail
    /// </summary>
    public MessageSmsDetailId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the MessageSmsDetail
    /// RecordNumber الخاص بـ MessageSmsDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// SourceDataType of the MessageSmsDetail
    /// SourceDataType الخاص بـ MessageSmsDetail
    /// </summary>
    public decimal? SourceDataType { get; private set; }

    /// <summary>
    /// ReceiverCode of the MessageSmsDetail
    /// ReceiverCode الخاص بـ MessageSmsDetail
    /// </summary>
    public string ReceiverCode { get; private set; }

    /// <summary>
    /// MobileNumber of the MessageSmsDetail
    /// MobileNumber الخاص بـ MessageSmsDetail
    /// </summary>
    public string MobileNumber { get; private set; }

    /// <summary>
    /// Email of the MessageSmsDetail
    /// Email الخاص بـ MessageSmsDetail
    /// </summary>
    public string Email { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public MessageSms MessageSms { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
