using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// InventoryMachineDetail Identifier Value Object
/// </summary>
public sealed class InventoryMachineDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InventoryMachineDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InventoryMachineDetailId instance
    /// </summary>
    public InventoryMachineDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InventoryMachineDetailId with a new GUID
    /// </summary>
    public static InventoryMachineDetailId CreateUnique()
    {
        return new InventoryMachineDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InventoryMachineDetailId id) => id.Value.ToString();
    public static implicit operator Guid(InventoryMachineDetailId id) => id.Value;
}
}
