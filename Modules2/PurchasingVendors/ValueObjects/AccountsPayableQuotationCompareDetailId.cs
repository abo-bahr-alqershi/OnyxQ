using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// AccountsPayableQuotationCompareDetail Identifier Value Object
/// </summary>
public sealed class AccountsPayableQuotationCompareDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsPayableQuotationCompareDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsPayableQuotationCompareDetailId instance
    /// </summary>
    public AccountsPayableQuotationCompareDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsPayableQuotationCompareDetailId with a new GUID
    /// </summary>
    public static AccountsPayableQuotationCompareDetailId CreateUnique()
    {
        return new AccountsPayableQuotationCompareDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsPayableQuotationCompareDetailId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsPayableQuotationCompareDetailId id) => id.Value;
}
}
