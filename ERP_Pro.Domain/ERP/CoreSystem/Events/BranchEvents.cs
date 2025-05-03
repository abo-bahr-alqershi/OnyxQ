using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;
using ERP_Pro.Domain.ERP.CoreSystem.Enums;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Event raised when a new branch is created
/// حدث يتم رفعه عند إنشاء فرع جديد
/// </summary>
public class BranchCreatedEvent : DomainEvent
{
    public Branch Branch { get; }

    public BranchCreatedEvent(Branch branch)
    {
        Branch = branch;
    }
}

/// <summary>
/// Event raised when branch information is updated
/// حدث يتم رفعه عند تحديث معلومات الفرع
/// </summary>
public class BranchUpdatedEvent : DomainEvent
{
    public Branch Branch { get; }

    public BranchUpdatedEvent(Branch branch)
    {
        Branch = branch;
    }
}

/// <summary>
/// Event raised when branch activity status is changed
/// حدث يتم رفعه عند تغيير حالة نشاط الفرع
/// </summary>
public class BranchActivityStatusChangedEvent : DomainEvent
{
    public Branch Branch { get; }
    public bool OldStatus { get; }
    public bool NewStatus { get; }
    public string Reason { get; }

    public BranchActivityStatusChangedEvent(Branch branch, bool oldStatus, bool newStatus, string reason)
    {
        Branch = branch;
        OldStatus = oldStatus;
        NewStatus = newStatus;
        Reason = reason;
    }
}

/// <summary>
/// Event raised when branch group is changed
/// حدث يتم رفعه عند تغيير مجموعة الفرع
/// </summary>
public class BranchGroupChangedEvent : DomainEvent
{
    public Branch Branch { get; }
    public int? OldGroupNumber { get; }
    public int? NewGroupNumber { get; }

    public BranchGroupChangedEvent(Branch branch, int? oldGroupNumber, int? newGroupNumber)
    {
        Branch = branch;
        OldGroupNumber = oldGroupNumber;
        NewGroupNumber = newGroupNumber;
    }
}

/// <summary>
/// Event raised when a document is added to a branch
/// حدث يتم رفعه عند إضافة وثيقة للفرع
/// </summary>
public class BranchDocumentAddedEvent : DomainEvent
{
    public Branch Branch { get; }
    public BranchDocument Document { get; }

    public BranchDocumentAddedEvent(Branch branch, BranchDocument document)
    {
        Branch = branch;
        Document = document;
    }
}

/// <summary>
/// Event raised when a user privilege is added to a branch
/// حدث يتم رفعه عند إضافة صلاحية مستخدم للفرع
/// </summary>
public class BranchUserPrivilegeAddedEvent : DomainEvent
{
    public Branch Branch { get; }
    public BranchUserPrivilege Privilege { get; }

    public BranchUserPrivilegeAddedEvent(Branch branch, BranchUserPrivilege privilege)
    {
        Branch = branch;
        Privilege = privilege;
    }
}

/// <summary>
/// حدث تغيير حالة الفرع
/// Branch status change event
/// </summary>
public class BranchStatusChangedEvent : DomainEvent
{
    public Branch Branch { get; }
    public BranchStatus OldStatus { get; }
    public BranchStatus NewStatus { get; }
    public BranchStatusChangedEvent(Branch branch, BranchStatus oldStatus, BranchStatus newStatus)
    {
        Branch = branch;
        OldStatus = oldStatus;
        NewStatus = newStatus;
    }
}

/// <summary>
/// حدث تغيير الفرع الأب
/// Parent branch change event
/// </summary>
public class BranchParentChangedEvent : DomainEvent
{
    public Branch Branch { get; }
    public int? OldParentBranchNo { get; }
    public int? NewParentBranchNo { get; }
    public BranchParentChangedEvent(Branch branch, int? oldParentBranchNo, int? newParentBranchNo)
    {
        Branch = branch;
        OldParentBranchNo = oldParentBranchNo;
        NewParentBranchNo = newParentBranchNo;
    }
}

/// <summary>
/// حدث تحديث موقع الفرع
/// Branch location update event
/// </summary>
public class BranchLocationUpdatedEvent : DomainEvent
{
    public Branch Branch { get; }
    public BranchLocationUpdatedEvent(Branch branch) => Branch = branch;
} 