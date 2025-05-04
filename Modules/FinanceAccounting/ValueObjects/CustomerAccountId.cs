using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// CustomerAccount Identifier Value Object
/// </summary>
public sealed class CustomerAccountId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerAccount
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerAccountId instance
    /// </summary>
    public CustomerAccountId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerAccountId with a new GUID
    /// </summary>
    public static CustomerAccountId CreateUnique()
    {
        return new CustomerAccountId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerAccountId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerAccountId id) => id.Value;
}
}
