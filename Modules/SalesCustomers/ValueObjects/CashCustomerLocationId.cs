using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CashCustomerLocation Identifier Value Object
/// </summary>
public sealed class CashCustomerLocationId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CashCustomerLocation
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CashCustomerLocationId instance
    /// </summary>
    public CashCustomerLocationId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CashCustomerLocationId with a new GUID
    /// </summary>
    public static CashCustomerLocationId CreateUnique()
    {
        return new CashCustomerLocationId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CashCustomerLocationId id) => id.Value.ToString();
    public static implicit operator Guid(CashCustomerLocationId id) => id.Value;
}
}
