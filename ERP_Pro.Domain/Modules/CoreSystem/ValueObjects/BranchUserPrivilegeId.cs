using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// BranchUserPrivilege Identifier Value Object
/// </summary>
public sealed class BranchUserPrivilegeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchUserPrivilege
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchUserPrivilegeId instance
    /// </summary>
    public BranchUserPrivilegeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchUserPrivilegeId with a new GUID
    /// </summary>
    public static BranchUserPrivilegeId CreateUnique()
    {
        return new BranchUserPrivilegeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchUserPrivilegeId id) => id.Value.ToString();
    public static implicit operator Guid(BranchUserPrivilegeId id) => id.Value;
}
}
