using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ServicesMaintenance.ValueObjects
{
/// <summary>
/// RepairOrderDetail Identifier Value Object
/// </summary>
public sealed class RepairOrderDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the RepairOrderDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new RepairOrderDetailId instance
    /// </summary>
    public RepairOrderDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new RepairOrderDetailId with a new GUID
    /// </summary>
    public static RepairOrderDetailId CreateUnique()
    {
        return new RepairOrderDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(RepairOrderDetailId id) => id.Value.ToString();
    public static implicit operator Guid(RepairOrderDetailId id) => id.Value;
}
}
