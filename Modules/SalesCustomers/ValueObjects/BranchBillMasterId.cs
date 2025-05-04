using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// BranchBillMaster Identifier Value Object
/// </summary>
public sealed class BranchBillMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchBillMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchBillMasterId instance
    /// </summary>
    public BranchBillMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchBillMasterId with a new GUID
    /// </summary>
    public static BranchBillMasterId CreateUnique()
    {
        return new BranchBillMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchBillMasterId id) => id.Value.ToString();
    public static implicit operator Guid(BranchBillMasterId id) => id.Value;
}
}
