using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// ProfitLossClosingTemp Identifier Value Object
/// </summary>
public sealed class ProfitLossClosingTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ProfitLossClosingTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ProfitLossClosingTempId instance
    /// </summary>
    public ProfitLossClosingTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ProfitLossClosingTempId with a new GUID
    /// </summary>
    public static ProfitLossClosingTempId CreateUnique()
    {
        return new ProfitLossClosingTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ProfitLossClosingTempId id) => id.Value.ToString();
    public static implicit operator Guid(ProfitLossClosingTempId id) => id.Value;
}
}
