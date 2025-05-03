using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Represents the event raised when a code send message is created.
/// حدث يتم رفعه عند إنشاء رسالة إرسال الرمز
/// </summary>
public sealed record CodeSendMessageCreatedEvent(CodeSendMessage CodeSendMessage) : IDomainEvent;

/// <summary>
/// Represents the event raised when a code send message is updated.
/// حدث يتم رفعه عند تحديث رسالة إرسال الرمز
/// </summary>
public sealed record CodeSendMessageUpdatedEvent(CodeSendMessage CodeSendMessage) : IDomainEvent; 