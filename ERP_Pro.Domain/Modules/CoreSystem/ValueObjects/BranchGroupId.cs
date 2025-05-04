using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// BranchGroup Identifier Value Object
/// </summary>
public sealed class BranchGroupId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchGroup
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchGroupId instance
    /// </summary>
    public BranchGroupId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchGroupId with a new GUID
    /// </summary>
    public static BranchGroupId CreateUnique()
    {
        return new BranchGroupId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchGroupId id) => id.Value.ToString();
    public static implicit operator Guid(BranchGroupId id) => id.Value;
}
}
