using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// AccountsPayableDiscountHistory Identifier Value Object
/// </summary>
public sealed class AccountsPayableDiscountHistoryId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsPayableDiscountHistory
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsPayableDiscountHistoryId instance
    /// </summary>
    public AccountsPayableDiscountHistoryId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsPayableDiscountHistoryId with a new GUID
    /// </summary>
    public static AccountsPayableDiscountHistoryId CreateUnique()
    {
        return new AccountsPayableDiscountHistoryId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsPayableDiscountHistoryId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsPayableDiscountHistoryId id) => id.Value;
}
}
