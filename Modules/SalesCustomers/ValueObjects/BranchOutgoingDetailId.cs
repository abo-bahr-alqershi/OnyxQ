using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// BranchOutgoingDetail Identifier Value Object
/// </summary>
public sealed class BranchOutgoingDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchOutgoingDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchOutgoingDetailId instance
    /// </summary>
    public BranchOutgoingDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchOutgoingDetailId with a new GUID
    /// </summary>
    public static BranchOutgoingDetailId CreateUnique()
    {
        return new BranchOutgoingDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchOutgoingDetailId id) => id.Value.ToString();
    public static implicit operator Guid(BranchOutgoingDetailId id) => id.Value;
}
}
