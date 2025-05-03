using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;
using ERP_Pro.Domain.ERP.CoreSystem.Enums;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// حدث إنشاء مستند فرع جديد
/// Branch document creation event
/// </summary>
public class BranchDocumentCreatedEvent : DomainEvent
{
    public BranchDocument Document { get; }
    public BranchDocumentCreatedEvent(BranchDocument document) => Document = document;
}

/// <summary>
/// حدث تحديث معلومات مستند الفرع
/// Branch document information update event
/// </summary>
public class BranchDocumentUpdatedEvent : DomainEvent
{
    public BranchDocument Document { get; }
    public BranchDocumentUpdatedEvent(BranchDocument document) => Document = document;
}

/// <summary>
/// حدث تغيير مسار ملف مستند الفرع
/// Branch document file path change event
/// </summary>
public class BranchDocumentFilePathChangedEvent : DomainEvent
{
    public BranchDocument Document { get; }
    public string OldFilePath { get; }
    public string NewFilePath { get; }
    public BranchDocumentFilePathChangedEvent(BranchDocument document, string oldFilePath, string newFilePath)
    {
        Document = document;
        OldFilePath = oldFilePath;
        NewFilePath = newFilePath;
    }
}

/// <summary>
/// حدث تغيير حالة مستند الفرع
/// Branch document status change event
/// </summary>
public class BranchDocumentStatusChangedEvent : DomainEvent
{
    public BranchDocument Document { get; }
    public DocumentStatus OldStatus { get; }
    public DocumentStatus NewStatus { get; }
    public BranchDocumentStatusChangedEvent(BranchDocument document, DocumentStatus oldStatus, DocumentStatus newStatus)
    {
        Document = document;
        OldStatus = oldStatus;
        NewStatus = newStatus;
    }
}

/// <summary>
/// Event raised when branch document renewal date is updated
/// حدث يتم رفعه عند تحديث تاريخ تجديد وثيقة الفرع
/// </summary>
public class BranchDocumentRenewalDateUpdatedEvent : DomainEvent
{
    public BranchDocument Document { get; }
    public DateTime? OldRenewalDate { get; }
    public DateTime NewRenewalDate { get; }

    public BranchDocumentRenewalDateUpdatedEvent(BranchDocument document, DateTime? oldRenewalDate, DateTime newRenewalDate)
    {
        Document = document;
        OldRenewalDate = oldRenewalDate;
        NewRenewalDate = newRenewalDate;
    }
}

/// <summary>
/// Event raised when branch document additional fields are updated
/// حدث يتم رفعه عند تحديث الحقول الإضافية لوثيقة الفرع
/// </summary>
public class BranchDocumentAdditionalFieldsUpdatedEvent : DomainEvent
{
    public BranchDocument Document { get; }

    public BranchDocumentAdditionalFieldsUpdatedEvent(BranchDocument document)
    {
        Document = document;
    }
}

/// <summary>
/// Event raised when branch document activity status is changed
/// حدث يتم رفعه عند تغيير حالة نشاط وثيقة الفرع
/// </summary>
public class BranchDocumentActivityStatusChangedEvent : DomainEvent
{
    public BranchDocument Document { get; }
    public bool OldStatus { get; }
    public bool NewStatus { get; }
    public string Reason { get; }

    public BranchDocumentActivityStatusChangedEvent(BranchDocument document, bool oldStatus, bool newStatus, string reason)
    {
        Document = document;
        OldStatus = oldStatus;
        NewStatus = newStatus;
        Reason = reason;
    }
} 