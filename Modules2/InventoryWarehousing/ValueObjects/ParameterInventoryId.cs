using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ParameterInventory Identifier Value Object
/// </summary>
public sealed class ParameterInventoryId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ParameterInventory
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ParameterInventoryId instance
    /// </summary>
    public ParameterInventoryId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ParameterInventoryId with a new GUID
    /// </summary>
    public static ParameterInventoryId CreateUnique()
    {
        return new ParameterInventoryId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ParameterInventoryId id) => id.Value.ToString();
    public static implicit operator Guid(ParameterInventoryId id) => id.Value;
}
}
