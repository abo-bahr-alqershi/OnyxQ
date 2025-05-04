using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// AccountsPayableType Identifier Value Object
/// </summary>
public sealed class AccountsPayableTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsPayableType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsPayableTypeId instance
    /// </summary>
    public AccountsPayableTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsPayableTypeId with a new GUID
    /// </summary>
    public static AccountsPayableTypeId CreateUnique()
    {
        return new AccountsPayableTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsPayableTypeId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsPayableTypeId id) => id.Value;
}
}
