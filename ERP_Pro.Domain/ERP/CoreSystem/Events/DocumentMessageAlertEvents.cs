using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Represents the event raised when a document message alert is created.
/// حدث يتم رفعه عند إنشاء تنبيه رسالة المستند
/// </summary>
public sealed record DocumentMessageAlertCreatedEvent(DocumentMessageAlert DocumentMessageAlert) : IDomainEvent;

/// <summary>
/// Represents the event raised when a document message alert is updated.
/// حدث يتم رفعه عند تحديث تنبيه رسالة المستند
/// </summary>
public sealed record DocumentMessageAlertUpdatedEvent(DocumentMessageAlert DocumentMessageAlert) : IDomainEvent; 