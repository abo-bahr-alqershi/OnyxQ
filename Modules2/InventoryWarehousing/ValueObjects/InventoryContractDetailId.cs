using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// InventoryContractDetail Identifier Value Object
/// </summary>
public sealed class InventoryContractDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InventoryContractDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InventoryContractDetailId instance
    /// </summary>
    public InventoryContractDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InventoryContractDetailId with a new GUID
    /// </summary>
    public static InventoryContractDetailId CreateUnique()
    {
        return new InventoryContractDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InventoryContractDetailId id) => id.Value.ToString();
    public static implicit operator Guid(InventoryContractDetailId id) => id.Value;
}
}
