using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// BranchReturnBillMaster Identifier Value Object
/// </summary>
public sealed class BranchReturnBillMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchReturnBillMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchReturnBillMasterId instance
    /// </summary>
    public BranchReturnBillMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchReturnBillMasterId with a new GUID
    /// </summary>
    public static BranchReturnBillMasterId CreateUnique()
    {
        return new BranchReturnBillMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchReturnBillMasterId id) => id.Value.ToString();
    public static implicit operator Guid(BranchReturnBillMasterId id) => id.Value;
}
}
