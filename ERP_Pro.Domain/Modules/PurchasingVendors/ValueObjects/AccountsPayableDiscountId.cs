using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// AccountsPayableDiscount Identifier Value Object
/// </summary>
public sealed class AccountsPayableDiscountId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsPayableDiscount
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsPayableDiscountId instance
    /// </summary>
    public AccountsPayableDiscountId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsPayableDiscountId with a new GUID
    /// </summary>
    public static AccountsPayableDiscountId CreateUnique()
    {
        return new AccountsPayableDiscountId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsPayableDiscountId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsPayableDiscountId id) => id.Value;
}
}
