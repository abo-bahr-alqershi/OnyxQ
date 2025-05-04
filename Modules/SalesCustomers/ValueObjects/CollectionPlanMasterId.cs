using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CollectionPlanMaster Identifier Value Object
/// </summary>
public sealed class CollectionPlanMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CollectionPlanMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CollectionPlanMasterId instance
    /// </summary>
    public CollectionPlanMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CollectionPlanMasterId with a new GUID
    /// </summary>
    public static CollectionPlanMasterId CreateUnique()
    {
        return new CollectionPlanMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CollectionPlanMasterId id) => id.Value.ToString();
    public static implicit operator Guid(CollectionPlanMasterId id) => id.Value;
}
}
