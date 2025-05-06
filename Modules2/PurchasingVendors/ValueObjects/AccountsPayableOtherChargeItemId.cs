using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// AccountsPayableOtherChargeItem Identifier Value Object
/// </summary>
public sealed class AccountsPayableOtherChargeItemId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsPayableOtherChargeItem
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsPayableOtherChargeItemId instance
    /// </summary>
    public AccountsPayableOtherChargeItemId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsPayableOtherChargeItemId with a new GUID
    /// </summary>
    public static AccountsPayableOtherChargeItemId CreateUnique()
    {
        return new AccountsPayableOtherChargeItemId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsPayableOtherChargeItemId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsPayableOtherChargeItemId id) => id.Value;
}
}
