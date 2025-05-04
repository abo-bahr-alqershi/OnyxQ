using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// AccountsPayableQuotationCompareFilterMaster Identifier Value Object
/// </summary>
public sealed class AccountsPayableQuotationCompareFilterMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsPayableQuotationCompareFilterMasterId instance
    /// </summary>
    public AccountsPayableQuotationCompareFilterMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsPayableQuotationCompareFilterMasterId with a new GUID
    /// </summary>
    public static AccountsPayableQuotationCompareFilterMasterId CreateUnique()
    {
        return new AccountsPayableQuotationCompareFilterMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsPayableQuotationCompareFilterMasterId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsPayableQuotationCompareFilterMasterId id) => id.Value;
}
}
