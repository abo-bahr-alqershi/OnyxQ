using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CollectorCommissionCalculationDetail Identifier Value Object
/// </summary>
public sealed class CollectorCommissionCalculationDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CollectorCommissionCalculationDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CollectorCommissionCalculationDetailId instance
    /// </summary>
    public CollectorCommissionCalculationDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CollectorCommissionCalculationDetailId with a new GUID
    /// </summary>
    public static CollectorCommissionCalculationDetailId CreateUnique()
    {
        return new CollectorCommissionCalculationDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CollectorCommissionCalculationDetailId id) => id.Value.ToString();
    public static implicit operator Guid(CollectorCommissionCalculationDetailId id) => id.Value;
}
}
