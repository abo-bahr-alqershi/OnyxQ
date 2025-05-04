using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// OutgoingPlanDetail Identifier Value Object
/// </summary>
public sealed class OutgoingPlanDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the OutgoingPlanDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new OutgoingPlanDetailId instance
    /// </summary>
    public OutgoingPlanDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new OutgoingPlanDetailId with a new GUID
    /// </summary>
    public static OutgoingPlanDetailId CreateUnique()
    {
        return new OutgoingPlanDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(OutgoingPlanDetailId id) => id.Value.ToString();
    public static implicit operator Guid(OutgoingPlanDetailId id) => id.Value;
}
}
