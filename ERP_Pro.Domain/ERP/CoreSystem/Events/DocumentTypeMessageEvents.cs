using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Represents the event raised when a document type message is created.
/// حدث يتم رفعه عند إنشاء رسالة نوع المستند
/// </summary>
public sealed record DocumentTypeMessageCreatedEvent(DocumentTypeMessage DocumentTypeMessage) : IDomainEvent;

/// <summary>
/// Represents the event raised when a document type message is updated.
/// حدث يتم رفعه عند تحديث رسالة نوع المستند
/// </summary>
public sealed record DocumentTypeMessageUpdatedEvent(DocumentTypeMessage DocumentTypeMessage) : IDomainEvent; 