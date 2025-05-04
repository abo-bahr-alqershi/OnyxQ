using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// AccountsPayableQuotationCompareMaster Identifier Value Object
/// </summary>
public sealed class AccountsPayableQuotationCompareMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsPayableQuotationCompareMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsPayableQuotationCompareMasterId instance
    /// </summary>
    public AccountsPayableQuotationCompareMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsPayableQuotationCompareMasterId with a new GUID
    /// </summary>
    public static AccountsPayableQuotationCompareMasterId CreateUnique()
    {
        return new AccountsPayableQuotationCompareMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsPayableQuotationCompareMasterId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsPayableQuotationCompareMasterId id) => id.Value;
}
}
