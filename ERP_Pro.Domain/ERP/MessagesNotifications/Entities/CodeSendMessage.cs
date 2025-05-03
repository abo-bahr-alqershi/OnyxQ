using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.MessagesNotifications.Events;
using ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Entities;

/// <summary>
/// Represents a code send message
/// يمثل رسالة إرسال الرمز
/// </summary>
public class CodeSendMessage : AuditableEntity
{
    /// <summary>
    /// The unique identifier for the message
    /// المعرف الفريد للرسالة
    /// </summary>
    public CodeSendMessageId Id { get; private set; }

    /// <summary>
    /// The message text
    /// نص الرسالة
    /// </summary>
    public string MessageText { get; private set; }

    /// <summary>
    /// The message type
    /// نوع الرسالة
    /// </summary>
    public string MessageType { get; private set; }

    /// <summary>
    /// The order number
    /// رقم الطلب
    /// </summary>
    public int OrderNumber { get; private set; }

    /// <summary>
    /// The print report number
    /// رقم تقرير الطباعة
    /// </summary>
    public string PrintReportNumber { get; private set; }

    private CodeSendMessage() { } // For EF Core

    public CodeSendMessage(
        string messageText,
        string messageType,
        int orderNumber,
        string printReportNumber)
    {
        Id = new CodeSendMessageId(Guid.NewGuid());
        MessageText = messageText;
        MessageType = messageType;
        OrderNumber = orderNumber;
        PrintReportNumber = printReportNumber;

        AddDomainEvent(new CodeSendMessageCreatedEvent(this));
    }

    public void Update(
        string messageText,
        string messageType,
        int orderNumber,
        string printReportNumber)
    {
        MessageText = messageText;
        MessageType = messageType;
        OrderNumber = orderNumber;
        PrintReportNumber = printReportNumber;

        AddDomainEvent(new CodeSendMessageUpdatedEvent(this));
    }
} 