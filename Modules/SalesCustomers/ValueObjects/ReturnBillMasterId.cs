using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// ReturnBillMaster Identifier Value Object
/// </summary>
public sealed class ReturnBillMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ReturnBillMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ReturnBillMasterId instance
    /// </summary>
    public ReturnBillMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ReturnBillMasterId with a new GUID
    /// </summary>
    public static ReturnBillMasterId CreateUnique()
    {
        return new ReturnBillMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ReturnBillMasterId id) => id.Value.ToString();
    public static implicit operator Guid(ReturnBillMasterId id) => id.Value;
}
}
