using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// BankGroup Identifier Value Object
/// </summary>
public sealed class BankGroupId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BankGroup
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BankGroupId instance
    /// </summary>
    public BankGroupId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BankGroupId with a new GUID
    /// </summary>
    public static BankGroupId CreateUnique()
    {
        return new BankGroupId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BankGroupId id) => id.Value.ToString();
    public static implicit operator Guid(BankGroupId id) => id.Value;
}
}
