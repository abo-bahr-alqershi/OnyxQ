using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Represents the event raised when a document type account detail message is created.
/// حدث يتم رفعه عند إنشاء رسالة تفاصيل حساب نوع المستند
/// </summary>
public sealed record DocumentTypeAccountDetailMessageCreatedEvent(DocumentTypeAccountDetailMessage DocumentTypeAccountDetailMessage) : IDomainEvent;

/// <summary>
/// Represents the event raised when a document type account detail message is updated.
/// حدث يتم رفعه عند تحديث رسالة تفاصيل حساب نوع المستند
/// </summary>
public sealed record DocumentTypeAccountDetailMessageUpdatedEvent(DocumentTypeAccountDetailMessage DocumentTypeAccountDetailMessage) : IDomainEvent; 