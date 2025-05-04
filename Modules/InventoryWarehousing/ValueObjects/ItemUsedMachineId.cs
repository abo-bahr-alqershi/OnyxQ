using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemUsedMachine Identifier Value Object
/// </summary>
public sealed class ItemUsedMachineId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemUsedMachine
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemUsedMachineId instance
    /// </summary>
    public ItemUsedMachineId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemUsedMachineId with a new GUID
    /// </summary>
    public static ItemUsedMachineId CreateUnique()
    {
        return new ItemUsedMachineId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemUsedMachineId id) => id.Value.ToString();
    public static implicit operator Guid(ItemUsedMachineId id) => id.Value;
}
}
