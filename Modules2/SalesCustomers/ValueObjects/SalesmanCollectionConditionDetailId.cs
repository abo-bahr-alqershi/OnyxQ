using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesmanCollectionConditionDetail Identifier Value Object
/// </summary>
public sealed class SalesmanCollectionConditionDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesmanCollectionConditionDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesmanCollectionConditionDetailId instance
    /// </summary>
    public SalesmanCollectionConditionDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesmanCollectionConditionDetailId with a new GUID
    /// </summary>
    public static SalesmanCollectionConditionDetailId CreateUnique()
    {
        return new SalesmanCollectionConditionDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesmanCollectionConditionDetailId id) => id.Value.ToString();
    public static implicit operator Guid(SalesmanCollectionConditionDetailId id) => id.Value;
}
}
