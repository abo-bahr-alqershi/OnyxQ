using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// InventoryMachineMaster Identifier Value Object
/// </summary>
public sealed class InventoryMachineMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InventoryMachineMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InventoryMachineMasterId instance
    /// </summary>
    public InventoryMachineMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InventoryMachineMasterId with a new GUID
    /// </summary>
    public static InventoryMachineMasterId CreateUnique()
    {
        return new InventoryMachineMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InventoryMachineMasterId id) => id.Value.ToString();
    public static implicit operator Guid(InventoryMachineMasterId id) => id.Value;
}
}
