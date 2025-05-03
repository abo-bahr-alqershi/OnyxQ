using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Event raised when a new branch group is created
/// حدث يتم رفعه عند إنشاء مجموعة فروع جديدة
/// </summary>
public class BranchGroupCreatedEvent : DomainEvent
{
    public BranchGroup BranchGroup { get; }

    public BranchGroupCreatedEvent(BranchGroup branchGroup)
    {
        BranchGroup = branchGroup;
    }
}

/// <summary>
/// Event raised when branch group information is updated
/// حدث يتم رفعه عند تحديث معلومات مجموعة الفروع
/// </summary>
public class BranchGroupUpdatedEvent : DomainEvent
{
    public BranchGroup BranchGroup { get; }

    public BranchGroupUpdatedEvent(BranchGroup branchGroup)
    {
        BranchGroup = branchGroup;
    }
}

/// <summary>
/// حدث تغيير المجموعة الأب
/// Parent group change event
/// </summary>
public class BranchGroupParentChangedEvent : DomainEvent
{
    public BranchGroup Group { get; }
    public int? OldParentGroupNo { get; }
    public int? NewParentGroupNo { get; }
    public BranchGroupParentChangedEvent(BranchGroup group, int? oldParentGroupNo, int? newParentGroupNo)
    {
        Group = group;
        OldParentGroupNo = oldParentGroupNo;
        NewParentGroupNo = newParentGroupNo;
    }
}

/// <summary>
/// Event raised when a branch is added to a group
/// حدث يتم رفعه عند إضافة فرع إلى مجموعة
/// </summary>
public class BranchAddedToGroupEvent : DomainEvent
{
    public BranchGroup BranchGroup { get; }
    public Branch Branch { get; }

    public BranchAddedToGroupEvent(BranchGroup branchGroup, Branch branch)
    {
        BranchGroup = branchGroup;
        Branch = branch;
    }
}

/// <summary>
/// Event raised when a branch is removed from a group
/// حدث يتم رفعه عند إزالة فرع من مجموعة
/// </summary>
public class BranchRemovedFromGroupEvent : DomainEvent
{
    public BranchGroup BranchGroup { get; }
    public Branch Branch { get; }

    public BranchRemovedFromGroupEvent(BranchGroup branchGroup, Branch branch)
    {
        BranchGroup = branchGroup;
        Branch = branch;
    }
} 