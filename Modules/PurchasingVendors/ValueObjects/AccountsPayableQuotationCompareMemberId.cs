using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// AccountsPayableQuotationCompareMember Identifier Value Object
/// </summary>
public sealed class AccountsPayableQuotationCompareMemberId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsPayableQuotationCompareMember
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsPayableQuotationCompareMemberId instance
    /// </summary>
    public AccountsPayableQuotationCompareMemberId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsPayableQuotationCompareMemberId with a new GUID
    /// </summary>
    public static AccountsPayableQuotationCompareMemberId CreateUnique()
    {
        return new AccountsPayableQuotationCompareMemberId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsPayableQuotationCompareMemberId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsPayableQuotationCompareMemberId id) => id.Value;
}
}
