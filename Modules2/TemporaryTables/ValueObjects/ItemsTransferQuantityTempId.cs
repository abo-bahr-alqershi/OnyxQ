using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// ItemsTransferQuantityTemp Identifier Value Object
/// </summary>
public sealed class ItemsTransferQuantityTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemsTransferQuantityTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemsTransferQuantityTempId instance
    /// </summary>
    public ItemsTransferQuantityTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemsTransferQuantityTempId with a new GUID
    /// </summary>
    public static ItemsTransferQuantityTempId CreateUnique()
    {
        return new ItemsTransferQuantityTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemsTransferQuantityTempId id) => id.Value.ToString();
    public static implicit operator Guid(ItemsTransferQuantityTempId id) => id.Value;
}
}
