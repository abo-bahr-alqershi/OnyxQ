using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// AccountsPayableChargeTdsSlice Identifier Value Object
/// </summary>
public sealed class AccountsPayableChargeTdsSliceId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsPayableChargeTdsSlice
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsPayableChargeTdsSliceId instance
    /// </summary>
    public AccountsPayableChargeTdsSliceId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsPayableChargeTdsSliceId with a new GUID
    /// </summary>
    public static AccountsPayableChargeTdsSliceId CreateUnique()
    {
        return new AccountsPayableChargeTdsSliceId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsPayableChargeTdsSliceId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsPayableChargeTdsSliceId id) => id.Value;
}
}
