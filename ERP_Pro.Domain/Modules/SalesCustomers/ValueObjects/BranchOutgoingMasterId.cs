using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// BranchOutgoingMaster Identifier Value Object
/// </summary>
public sealed class BranchOutgoingMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchOutgoingMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchOutgoingMasterId instance
    /// </summary>
    public BranchOutgoingMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchOutgoingMasterId with a new GUID
    /// </summary>
    public static BranchOutgoingMasterId CreateUnique()
    {
        return new BranchOutgoingMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchOutgoingMasterId id) => id.Value.ToString();
    public static implicit operator Guid(BranchOutgoingMasterId id) => id.Value;
}
}
