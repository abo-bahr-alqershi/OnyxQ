using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// WeightedItemsTemp Identifier Value Object
/// </summary>
public sealed class WeightedItemsTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the WeightedItemsTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new WeightedItemsTempId instance
    /// </summary>
    public WeightedItemsTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new WeightedItemsTempId with a new GUID
    /// </summary>
    public static WeightedItemsTempId CreateUnique()
    {
        return new WeightedItemsTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(WeightedItemsTempId id) => id.Value.ToString();
    public static implicit operator Guid(WeightedItemsTempId id) => id.Value;
}
}
