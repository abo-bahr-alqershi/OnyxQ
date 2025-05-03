using System;
using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a code send message entity in the system.
/// يمثل كيان رسالة إرسال الرمز في النظام
/// </summary>
public sealed class CodeSendMessage : AggregateRoot<CodeSendMessageId>
{
    /// <summary>
    /// Gets the message text.
    /// نص الرسالة
    /// </summary>
    public string MessageText { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the message type.
    /// نوع الرسالة
    /// </summary>
    public int MessageType { get; private set; }

    /// <summary>
    /// Gets the order number.
    /// رقم الترتيب
    /// </summary>
    public int OrderNumber { get; private set; }

    /// <summary>
    /// Gets the added user ID.
    /// معرف المستخدم الذي أضاف السجل
    /// </summary>
    public int AddedUserId { get; private set; }

    /// <summary>
    /// Gets the addition date.
    /// تاريخ الإضافة
    /// </summary>
    public DateTime AddedDate { get; private set; }

    /// <summary>
    /// Gets the terminal name where the record was added.
    /// اسم الطرفية التي تمت إضافة السجل منها
    /// </summary>
    public string AddedTerminalName { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the updated user ID.
    /// معرف المستخدم الذي قام بالتحديث
    /// </summary>
    public int? UpdatedUserId { get; private set; }

    /// <summary>
    /// Gets the update date.
    /// تاريخ التحديث
    /// </summary>
    public DateTime? UpdatedDate { get; private set; }

    /// <summary>
    /// Gets the update count.
    /// عدد مرات التحديث
    /// </summary>
    public int UpdateCount { get; private set; }

    /// <summary>
    /// Gets the terminal name where the record was last updated.
    /// اسم الطرفية التي تم تحديث السجل منها
    /// </summary>
    public string UpdatedTerminalName { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the print report number.
    /// رقم تقرير الطباعة
    /// </summary>
    public int PrintReportNumber { get; private set; }

    private CodeSendMessage() { }

    private CodeSendMessage(
        CodeSendMessageId id,
        string messageText,
        int messageType,
        int orderNumber,
        int addedUserId,
        DateTime addedDate,
        string addedTerminalName,
        int printReportNumber)
        : base(id)
    {
        MessageText = messageText;
        MessageType = messageType;
        OrderNumber = orderNumber;
        AddedUserId = addedUserId;
        AddedDate = addedDate;
        AddedTerminalName = addedTerminalName;
        PrintReportNumber = printReportNumber;
    }

    public static CodeSendMessage Create(
        int recordNumber,
        string messageText,
        int messageType,
        int orderNumber,
        int addedUserId,
        string addedTerminalName,
        int printReportNumber)
    {
        var message = new CodeSendMessage(
            CodeSendMessageId.Create(recordNumber),
            messageText,
            messageType,
            orderNumber,
            addedUserId,
            DateTime.UtcNow,
            addedTerminalName,
            printReportNumber);

        message.RaiseDomainEvent(new CodeSendMessageCreatedEvent(message));

        return message;
    }

    public void Update(
        string messageText,
        int messageType,
        int orderNumber,
        int updatedUserId,
        string updatedTerminalName,
        int printReportNumber)
    {
        MessageText = messageText;
        MessageType = messageType;
        OrderNumber = orderNumber;
        UpdatedUserId = updatedUserId;
        UpdatedDate = DateTime.UtcNow;
        UpdateCount++;
        UpdatedTerminalName = updatedTerminalName;
        PrintReportNumber = printReportNumber;

        RaiseDomainEvent(new CodeSendMessageUpdatedEvent(this));
    }
} 