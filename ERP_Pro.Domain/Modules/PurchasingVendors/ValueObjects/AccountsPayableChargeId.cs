using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// AccountsPayableCharge Identifier Value Object
/// </summary>
public sealed class AccountsPayableChargeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsPayableCharge
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsPayableChargeId instance
    /// </summary>
    public AccountsPayableChargeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsPayableChargeId with a new GUID
    /// </summary>
    public static AccountsPayableChargeId CreateUnique()
    {
        return new AccountsPayableChargeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsPayableChargeId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsPayableChargeId id) => id.Value;
}
}
