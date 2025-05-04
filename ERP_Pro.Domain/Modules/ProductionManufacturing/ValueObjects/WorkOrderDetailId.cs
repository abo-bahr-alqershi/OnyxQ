using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.ValueObjects
{
/// <summary>
/// WorkOrderDetail Identifier Value Object
/// </summary>
public sealed class WorkOrderDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the WorkOrderDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new WorkOrderDetailId instance
    /// </summary>
    public WorkOrderDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new WorkOrderDetailId with a new GUID
    /// </summary>
    public static WorkOrderDetailId CreateUnique()
    {
        return new WorkOrderDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(WorkOrderDetailId id) => id.Value.ToString();
    public static implicit operator Guid(WorkOrderDetailId id) => id.Value;
}
}
