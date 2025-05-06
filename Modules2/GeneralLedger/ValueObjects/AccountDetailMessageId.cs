using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// AccountDetailMessage Identifier Value Object
/// </summary>
public sealed class AccountDetailMessageId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountDetailMessage
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountDetailMessageId instance
    /// </summary>
    public AccountDetailMessageId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountDetailMessageId with a new GUID
    /// </summary>
    public static AccountDetailMessageId CreateUnique()
    {
        return new AccountDetailMessageId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountDetailMessageId id) => id.Value.ToString();
    public static implicit operator Guid(AccountDetailMessageId id) => id.Value;
}
}
