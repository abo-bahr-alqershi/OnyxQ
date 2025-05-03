using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Represents the event raised when a sequence control is created.
/// حدث يتم رفعه عند إنشاء التحكم في التسلسل
/// </summary>
public sealed record SequenceControlCreatedEvent(SequenceControl SequenceControl) : IDomainEvent;

/// <summary>
/// Represents the event raised when a sequence control is updated.
/// حدث يتم رفعه عند تحديث التحكم في التسلسل
/// </summary>
public sealed record SequenceControlUpdatedEvent(SequenceControl SequenceControl) : IDomainEvent; 