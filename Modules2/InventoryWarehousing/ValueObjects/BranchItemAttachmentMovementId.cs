using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// BranchItemAttachmentMovement Identifier Value Object
/// </summary>
public sealed class BranchItemAttachmentMovementId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchItemAttachmentMovement
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchItemAttachmentMovementId instance
    /// </summary>
    public BranchItemAttachmentMovementId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchItemAttachmentMovementId with a new GUID
    /// </summary>
    public static BranchItemAttachmentMovementId CreateUnique()
    {
        return new BranchItemAttachmentMovementId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchItemAttachmentMovementId id) => id.Value.ToString();
    public static implicit operator Guid(BranchItemAttachmentMovementId id) => id.Value;
}
}
