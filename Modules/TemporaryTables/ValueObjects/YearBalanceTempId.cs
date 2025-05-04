using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// YearBalanceTemp Identifier Value Object
/// </summary>
public sealed class YearBalanceTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the YearBalanceTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new YearBalanceTempId instance
    /// </summary>
    public YearBalanceTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new YearBalanceTempId with a new GUID
    /// </summary>
    public static YearBalanceTempId CreateUnique()
    {
        return new YearBalanceTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(YearBalanceTempId id) => id.Value.ToString();
    public static implicit operator Guid(YearBalanceTempId id) => id.Value;
}
}
