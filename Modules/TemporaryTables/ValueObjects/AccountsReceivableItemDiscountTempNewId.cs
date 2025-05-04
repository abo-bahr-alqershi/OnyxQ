using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// AccountsReceivableItemDiscountTempNew Identifier Value Object
/// </summary>
public sealed class AccountsReceivableItemDiscountTempNewId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsReceivableItemDiscountTempNew
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsReceivableItemDiscountTempNewId instance
    /// </summary>
    public AccountsReceivableItemDiscountTempNewId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsReceivableItemDiscountTempNewId with a new GUID
    /// </summary>
    public static AccountsReceivableItemDiscountTempNewId CreateUnique()
    {
        return new AccountsReceivableItemDiscountTempNewId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsReceivableItemDiscountTempNewId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsReceivableItemDiscountTempNewId id) => id.Value;
}
}
