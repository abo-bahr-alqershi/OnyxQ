using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CashCustomer Identifier Value Object
/// </summary>
public sealed class CashCustomerId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CashCustomer
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CashCustomerId instance
    /// </summary>
    public CashCustomerId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CashCustomerId with a new GUID
    /// </summary>
    public static CashCustomerId CreateUnique()
    {
        return new CashCustomerId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CashCustomerId id) => id.Value.ToString();
    public static implicit operator Guid(CashCustomerId id) => id.Value;
}
}
