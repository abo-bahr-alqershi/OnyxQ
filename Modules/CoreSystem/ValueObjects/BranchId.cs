using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// Branch Identifier Value Object
/// </summary>
public sealed class BranchId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Branch
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchId instance
    /// </summary>
    public BranchId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchId with a new GUID
    /// </summary>
    public static BranchId CreateUnique()
    {
        return new BranchId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchId id) => id.Value.ToString();
    public static implicit operator Guid(BranchId id) => id.Value;
}
}
