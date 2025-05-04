using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// ItemAgingTemp Identifier Value Object
/// </summary>
public sealed class ItemAgingTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemAgingTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemAgingTempId instance
    /// </summary>
    public ItemAgingTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemAgingTempId with a new GUID
    /// </summary>
    public static ItemAgingTempId CreateUnique()
    {
        return new ItemAgingTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemAgingTempId id) => id.Value.ToString();
    public static implicit operator Guid(ItemAgingTempId id) => id.Value;
}
}
