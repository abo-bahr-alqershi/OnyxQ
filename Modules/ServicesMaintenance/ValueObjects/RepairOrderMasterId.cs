using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ServicesMaintenance.ValueObjects
{
/// <summary>
/// RepairOrderMaster Identifier Value Object
/// </summary>
public sealed class RepairOrderMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the RepairOrderMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new RepairOrderMasterId instance
    /// </summary>
    public RepairOrderMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new RepairOrderMasterId with a new GUID
    /// </summary>
    public static RepairOrderMasterId CreateUnique()
    {
        return new RepairOrderMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(RepairOrderMasterId id) => id.Value.ToString();
    public static implicit operator Guid(RepairOrderMasterId id) => id.Value;
}
}
