using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// AccountMessage Identifier Value Object
/// </summary>
public sealed class AccountMessageId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountMessage
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountMessageId instance
    /// </summary>
    public AccountMessageId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountMessageId with a new GUID
    /// </summary>
    public static AccountMessageId CreateUnique()
    {
        return new AccountMessageId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountMessageId id) => id.Value.ToString();
    public static implicit operator Guid(AccountMessageId id) => id.Value;
}
}
