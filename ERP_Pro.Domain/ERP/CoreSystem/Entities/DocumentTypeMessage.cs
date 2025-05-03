using System;
using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a document type message entity in the system.
/// يمثل كيان رسالة نوع المستند في النظام
/// </summary>
public sealed class DocumentTypeMessage : AggregateRoot<DocumentTypeMessageId>
{
    /// <summary>
    /// Gets the document type ID.
    /// معرف نوع المستند
    /// </summary>
    public int DocumentTypeId { get; private set; }

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
    /// Gets the terminal name where the record was last updated.
    /// اسم الطرفية التي تم تحديث السجل منها
    /// </summary>
    public string UpdatedTerminalName { get; private set; } = string.Empty;

    /// <summary>
    /// Navigation property for the document type.
    /// خاصية التنقل لنوع المستند
    /// </summary>
    public DocumentType DocumentType { get; private set; }

    private DocumentTypeMessage() { }

    private DocumentTypeMessage(
        DocumentTypeMessageId id,
        int documentTypeId,
        string messageText,
        int messageType,
        int orderNumber,
        int addedUserId,
        DateTime addedDate,
        string addedTerminalName)
        : base(id)
    {
        DocumentTypeId = documentTypeId;
        MessageText = messageText;
        MessageType = messageType;
        OrderNumber = orderNumber;
        AddedUserId = addedUserId;
        AddedDate = addedDate;
        AddedTerminalName = addedTerminalName;
    }

    public static DocumentTypeMessage Create(
        int recordNumber,
        int documentTypeId,
        string messageText,
        int messageType,
        int orderNumber,
        int addedUserId,
        string addedTerminalName)
    {
        var message = new DocumentTypeMessage(
            DocumentTypeMessageId.Create(recordNumber),
            documentTypeId,
            messageText,
            messageType,
            orderNumber,
            addedUserId,
            DateTime.UtcNow,
            addedTerminalName);

        message.RaiseDomainEvent(new DocumentTypeMessageCreatedEvent(message));

        return message;
    }

    public void Update(
        int documentTypeId,
        string messageText,
        int messageType,
        int orderNumber,
        int updatedUserId,
        string updatedTerminalName)
    {
        DocumentTypeId = documentTypeId;
        MessageText = messageText;
        MessageType = messageType;
        OrderNumber = orderNumber;
        UpdatedUserId = updatedUserId;
        UpdatedDate = DateTime.UtcNow;
        UpdatedTerminalName = updatedTerminalName;

        RaiseDomainEvent(new DocumentTypeMessageUpdatedEvent(this));
    }
} 