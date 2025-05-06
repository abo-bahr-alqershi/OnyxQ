using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// OutgoingPlanMaster Identifier Value Object
/// </summary>
public sealed class OutgoingPlanMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the OutgoingPlanMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new OutgoingPlanMasterId instance
    /// </summary>
    public OutgoingPlanMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new OutgoingPlanMasterId with a new GUID
    /// </summary>
    public static OutgoingPlanMasterId CreateUnique()
    {
        return new OutgoingPlanMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(OutgoingPlanMasterId id) => id.Value.ToString();
    public static implicit operator Guid(OutgoingPlanMasterId id) => id.Value;
}
}
