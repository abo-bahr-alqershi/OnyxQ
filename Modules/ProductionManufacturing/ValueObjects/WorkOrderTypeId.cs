using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.ValueObjects
{
/// <summary>
/// WorkOrderType Identifier Value Object
/// </summary>
public sealed class WorkOrderTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the WorkOrderType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new WorkOrderTypeId instance
    /// </summary>
    public WorkOrderTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new WorkOrderTypeId with a new GUID
    /// </summary>
    public static WorkOrderTypeId CreateUnique()
    {
        return new WorkOrderTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(WorkOrderTypeId id) => id.Value.ToString();
    public static implicit operator Guid(WorkOrderTypeId id) => id.Value;
}
}
