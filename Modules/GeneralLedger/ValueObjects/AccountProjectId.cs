using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// AccountProject Identifier Value Object
/// </summary>
public sealed class AccountProjectId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountProject
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountProjectId instance
    /// </summary>
    public AccountProjectId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountProjectId with a new GUID
    /// </summary>
    public static AccountProjectId CreateUnique()
    {
        return new AccountProjectId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountProjectId id) => id.Value.ToString();
    public static implicit operator Guid(AccountProjectId id) => id.Value;
}
}
