using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// DetailGroup Identifier Value Object
/// </summary>
public sealed class DetailGroupId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DetailGroup
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DetailGroupId instance
    /// </summary>
    public DetailGroupId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DetailGroupId with a new GUID
    /// </summary>
    public static DetailGroupId CreateUnique()
    {
        return new DetailGroupId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DetailGroupId id) => id.Value.ToString();
    public static implicit operator Guid(DetailGroupId id) => id.Value;
}
}
