using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerBankAccount Identifier Value Object
/// </summary>
public sealed class CustomerBankAccountId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerBankAccount
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerBankAccountId instance
    /// </summary>
    public CustomerBankAccountId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerBankAccountId with a new GUID
    /// </summary>
    public static CustomerBankAccountId CreateUnique()
    {
        return new CustomerBankAccountId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerBankAccountId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerBankAccountId id) => id.Value;
}
}
