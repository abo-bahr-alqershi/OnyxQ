using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// PeriodCurrencyDifference Identifier Value Object
/// </summary>
public sealed class PeriodCurrencyDifferenceId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PeriodCurrencyDifference
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PeriodCurrencyDifferenceId instance
    /// </summary>
    public PeriodCurrencyDifferenceId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PeriodCurrencyDifferenceId with a new GUID
    /// </summary>
    public static PeriodCurrencyDifferenceId CreateUnique()
    {
        return new PeriodCurrencyDifferenceId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PeriodCurrencyDifferenceId id) => id.Value.ToString();
    public static implicit operator Guid(PeriodCurrencyDifferenceId id) => id.Value;
}
}
