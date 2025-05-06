using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// ItemWeightedAverageTemp Identifier Value Object
/// </summary>
public sealed class ItemWeightedAverageTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemWeightedAverageTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemWeightedAverageTempId instance
    /// </summary>
    public ItemWeightedAverageTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemWeightedAverageTempId with a new GUID
    /// </summary>
    public static ItemWeightedAverageTempId CreateUnique()
    {
        return new ItemWeightedAverageTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemWeightedAverageTempId id) => id.Value.ToString();
    public static implicit operator Guid(ItemWeightedAverageTempId id) => id.Value;
}
}
