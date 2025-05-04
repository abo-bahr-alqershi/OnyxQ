using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// OutgoingAccount Identifier Value Object
/// </summary>
public sealed class OutgoingAccountId : ValueObject
{
    /// <summary>
    /// The unique identifier for the OutgoingAccount
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new OutgoingAccountId instance
    /// </summary>
    public OutgoingAccountId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new OutgoingAccountId with a new GUID
    /// </summary>
    public static OutgoingAccountId CreateUnique()
    {
        return new OutgoingAccountId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(OutgoingAccountId id) => id.Value.ToString();
    public static implicit operator Guid(OutgoingAccountId id) => id.Value;
}
}
