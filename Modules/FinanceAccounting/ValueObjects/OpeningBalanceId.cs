using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// OpeningBalance Identifier Value Object
/// </summary>
public sealed class OpeningBalanceId : ValueObject
{
    /// <summary>
    /// The unique identifier for the OpeningBalance
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new OpeningBalanceId instance
    /// </summary>
    public OpeningBalanceId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new OpeningBalanceId with a new GUID
    /// </summary>
    public static OpeningBalanceId CreateUnique()
    {
        return new OpeningBalanceId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(OpeningBalanceId id) => id.Value.ToString();
    public static implicit operator Guid(OpeningBalanceId id) => id.Value;
}
}
