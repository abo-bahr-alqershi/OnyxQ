using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Entities
{
/// <summary>
/// MessageSms Entity
/// </summary>
public class MessageSms : Entity<MessageSmsId>
{
    private MessageSms() { }

    /// <summary>
    /// The unique identifier for the MessageSms
    /// المعرف الفريد لـ MessageSms
    /// </summary>
    public MessageSmsId Id { get; private set; }

    /// <summary>
    /// MessageNumber of the MessageSms
    /// MessageNumber الخاص بـ MessageSms
    /// </summary>
    public decimal? MessageNumber { get; private set; }

    /// <summary>
    /// MessageText of the MessageSms
    /// MessageText الخاص بـ MessageSms
    /// </summary>
    public string MessageText { get; private set; }

    /// <summary>
    /// MobileNumber of the MessageSms
    /// MobileNumber الخاص بـ MessageSms
    /// </summary>
    public string MobileNumber { get; private set; }

    /// <summary>
    /// MessageSendFlag of the MessageSms
    /// MessageSendFlag الخاص بـ MessageSms
    /// </summary>
    public decimal? MessageSendFlag { get; private set; }

    /// <summary>
    /// SendCount of the MessageSms
    /// SendCount الخاص بـ MessageSms
    /// </summary>
    public decimal? SendCount { get; private set; }

    /// <summary>
    /// SourceDataType of the MessageSms
    /// SourceDataType الخاص بـ MessageSms
    /// </summary>
    public decimal? SourceDataType { get; private set; }

    /// <summary>
    /// SubjectMail of the MessageSms
    /// SubjectMail الخاص بـ MessageSms
    /// </summary>
    public string SubjectMail { get; private set; }

    /// <summary>
    /// Email of the MessageSms
    /// Email الخاص بـ MessageSms
    /// </summary>
    public string Email { get; private set; }

    /// <summary>
    /// SendType of the MessageSms
    /// SendType الخاص بـ MessageSms
    /// </summary>
    public decimal? SendType { get; private set; }

    /// <summary>
    /// ParameterChoose of the MessageSms
    /// ParameterChoose الخاص بـ MessageSms
    /// </summary>
    public string ParameterChoose { get; private set; }

    /// <summary>
    /// CustTyp of the MessageSms
    /// CustTyp الخاص بـ MessageSms
    /// </summary>
    public decimal? CustTyp { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: MessageSms to MessageSmsDetail
    /// </summary>
    public IReadOnlyCollection<MessageSmsDetail> MessageSmsDetails { get; private set; }
    #endregion
}
}
