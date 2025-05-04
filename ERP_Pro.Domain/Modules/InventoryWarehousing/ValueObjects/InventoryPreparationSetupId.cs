using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// InventoryPreparationSetup Identifier Value Object
/// </summary>
public sealed class InventoryPreparationSetupId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InventoryPreparationSetup
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InventoryPreparationSetupId instance
    /// </summary>
    public InventoryPreparationSetupId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InventoryPreparationSetupId with a new GUID
    /// </summary>
    public static InventoryPreparationSetupId CreateUnique()
    {
        return new InventoryPreparationSetupId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InventoryPreparationSetupId id) => id.Value.ToString();
    public static implicit operator Guid(InventoryPreparationSetupId id) => id.Value;
}
}
