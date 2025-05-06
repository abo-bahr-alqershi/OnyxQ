using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// AccountsPayableKimbDetail Identifier Value Object
/// </summary>
public sealed class AccountsPayableKimbDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsPayableKimbDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsPayableKimbDetailId instance
    /// </summary>
    public AccountsPayableKimbDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsPayableKimbDetailId with a new GUID
    /// </summary>
    public static AccountsPayableKimbDetailId CreateUnique()
    {
        return new AccountsPayableKimbDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsPayableKimbDetailId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsPayableKimbDetailId id) => id.Value;
}
}
