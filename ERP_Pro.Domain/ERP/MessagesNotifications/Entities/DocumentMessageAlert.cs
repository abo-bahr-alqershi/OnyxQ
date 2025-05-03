using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.MessagesNotifications.Events;
using ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Entities;

/// <summary>
/// Represents a document message alert
/// يمثل تنبيه رسالة المستند
/// </summary>
public class DocumentMessageAlert : AuditableEntity
{
    /// <summary>
    /// The unique identifier for the alert
    /// المعرف الفريد للتنبيه
    /// </summary>
    public DocumentMessageAlertId Id { get; private set; }

    /// <summary>
    /// The document type ID
    /// معرف نوع المستند
    /// </summary>
    public string DocumentTypeId { get; private set; }

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
    /// Navigation property for the document type relationship
    /// خاصية التنقل لعلاقة نوع المستند
    /// </summary>
    public DocumentType DocumentType { get; private set; }

    private DocumentMessageAlert() { } // For EF Core

    public DocumentMessageAlert(
        string documentTypeId,
        string messageText,
        string messageType,
        int orderNumber)
    {
        Id = new DocumentMessageAlertId(Guid.NewGuid());
        DocumentTypeId = documentTypeId;
        MessageText = messageText;
        MessageType = messageType;
        OrderNumber = orderNumber;

        AddDomainEvent(new DocumentMessageAlertCreatedEvent(this));
    }

    public void Update(
        string documentTypeId,
        string messageText,
        string messageType,
        int orderNumber)
    {
        DocumentTypeId = documentTypeId;
        MessageText = messageText;
        MessageType = messageType;
        OrderNumber = orderNumber;

        AddDomainEvent(new DocumentMessageAlertUpdatedEvent(this));
    }
} 