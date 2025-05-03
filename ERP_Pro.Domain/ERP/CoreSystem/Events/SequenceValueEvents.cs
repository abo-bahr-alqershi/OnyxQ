using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Represents the event raised when a sequence value is created.
/// حدث يتم رفعه عند إنشاء قيمة التسلسل
/// </summary>
public sealed record SequenceValueCreatedEvent(SequenceValue SequenceValue) : IDomainEvent;

/// <summary>
/// Represents the event raised when a sequence value is updated.
/// حدث يتم رفعه عند تحديث قيمة التسلسل
/// </summary>
public sealed record SequenceValueUpdatedEvent(SequenceValue SequenceValue) : IDomainEvent; 