using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// ReturnSalesType Identifier Value Object
/// </summary>
public sealed class ReturnSalesTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ReturnSalesType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ReturnSalesTypeId instance
    /// </summary>
    public ReturnSalesTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ReturnSalesTypeId with a new GUID
    /// </summary>
    public static ReturnSalesTypeId CreateUnique()
    {
        return new ReturnSalesTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ReturnSalesTypeId id) => id.Value.ToString();
    public static implicit operator Guid(ReturnSalesTypeId id) => id.Value;
}
}
