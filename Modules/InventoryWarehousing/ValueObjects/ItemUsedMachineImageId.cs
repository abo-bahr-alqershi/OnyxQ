using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemUsedMachineImage Identifier Value Object
/// </summary>
public sealed class ItemUsedMachineImageId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemUsedMachineImage
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemUsedMachineImageId instance
    /// </summary>
    public ItemUsedMachineImageId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemUsedMachineImageId with a new GUID
    /// </summary>
    public static ItemUsedMachineImageId CreateUnique()
    {
        return new ItemUsedMachineImageId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemUsedMachineImageId id) => id.Value.ToString();
    public static implicit operator Guid(ItemUsedMachineImageId id) => id.Value;
}
}
