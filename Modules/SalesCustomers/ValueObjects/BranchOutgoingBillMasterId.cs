using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// BranchOutgoingBillMaster Identifier Value Object
/// </summary>
public sealed class BranchOutgoingBillMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchOutgoingBillMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchOutgoingBillMasterId instance
    /// </summary>
    public BranchOutgoingBillMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchOutgoingBillMasterId with a new GUID
    /// </summary>
    public static BranchOutgoingBillMasterId CreateUnique()
    {
        return new BranchOutgoingBillMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchOutgoingBillMasterId id) => id.Value.ToString();
    public static implicit operator Guid(BranchOutgoingBillMasterId id) => id.Value;
}
}
