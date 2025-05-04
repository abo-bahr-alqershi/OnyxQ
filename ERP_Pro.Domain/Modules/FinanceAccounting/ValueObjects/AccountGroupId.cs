using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// AccountGroup Identifier Value Object
/// </summary>
public sealed class AccountGroupId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountGroup
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountGroupId instance
    /// </summary>
    public AccountGroupId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountGroupId with a new GUID
    /// </summary>
    public static AccountGroupId CreateUnique()
    {
        return new AccountGroupId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountGroupId id) => id.Value.ToString();
    public static implicit operator Guid(AccountGroupId id) => id.Value;
}
}
