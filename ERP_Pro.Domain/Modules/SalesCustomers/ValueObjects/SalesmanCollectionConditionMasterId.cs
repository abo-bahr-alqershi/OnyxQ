using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesmanCollectionConditionMaster Identifier Value Object
/// </summary>
public sealed class SalesmanCollectionConditionMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesmanCollectionConditionMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesmanCollectionConditionMasterId instance
    /// </summary>
    public SalesmanCollectionConditionMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesmanCollectionConditionMasterId with a new GUID
    /// </summary>
    public static SalesmanCollectionConditionMasterId CreateUnique()
    {
        return new SalesmanCollectionConditionMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesmanCollectionConditionMasterId id) => id.Value.ToString();
    public static implicit operator Guid(SalesmanCollectionConditionMasterId id) => id.Value;
}
}
