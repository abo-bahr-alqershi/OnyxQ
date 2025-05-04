using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// Machine Identifier Value Object
/// </summary>
public sealed class MachineId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Machine
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new MachineId instance
    /// </summary>
    public MachineId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new MachineId with a new GUID
    /// </summary>
    public static MachineId CreateUnique()
    {
        return new MachineId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(MachineId id) => id.Value.ToString();
    public static implicit operator Guid(MachineId id) => id.Value;
}
}
