using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// AccountsPayableChargeItem Identifier Value Object
/// </summary>
public sealed class AccountsPayableChargeItemId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsPayableChargeItem
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsPayableChargeItemId instance
    /// </summary>
    public AccountsPayableChargeItemId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsPayableChargeItemId with a new GUID
    /// </summary>
    public static AccountsPayableChargeItemId CreateUnique()
    {
        return new AccountsPayableChargeItemId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsPayableChargeItemId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsPayableChargeItemId id) => id.Value;
}
}
