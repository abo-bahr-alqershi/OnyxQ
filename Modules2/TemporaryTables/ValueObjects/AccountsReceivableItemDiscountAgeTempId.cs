using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// AccountsReceivableItemDiscountAgeTemp Identifier Value Object
/// </summary>
public sealed class AccountsReceivableItemDiscountAgeTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsReceivableItemDiscountAgeTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsReceivableItemDiscountAgeTempId instance
    /// </summary>
    public AccountsReceivableItemDiscountAgeTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsReceivableItemDiscountAgeTempId with a new GUID
    /// </summary>
    public static AccountsReceivableItemDiscountAgeTempId CreateUnique()
    {
        return new AccountsReceivableItemDiscountAgeTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsReceivableItemDiscountAgeTempId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsReceivableItemDiscountAgeTempId id) => id.Value;
}
}
