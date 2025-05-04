using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CollectionPlan Identifier Value Object
/// </summary>
public sealed class CollectionPlanId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CollectionPlan
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CollectionPlanId instance
    /// </summary>
    public CollectionPlanId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CollectionPlanId with a new GUID
    /// </summary>
    public static CollectionPlanId CreateUnique()
    {
        return new CollectionPlanId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CollectionPlanId id) => id.Value.ToString();
    public static implicit operator Guid(CollectionPlanId id) => id.Value;
}
}
