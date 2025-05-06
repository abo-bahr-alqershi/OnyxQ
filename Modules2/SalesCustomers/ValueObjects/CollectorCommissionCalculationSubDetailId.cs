using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CollectorCommissionCalculationSubDetail Identifier Value Object
/// </summary>
public sealed class CollectorCommissionCalculationSubDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CollectorCommissionCalculationSubDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CollectorCommissionCalculationSubDetailId instance
    /// </summary>
    public CollectorCommissionCalculationSubDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CollectorCommissionCalculationSubDetailId with a new GUID
    /// </summary>
    public static CollectorCommissionCalculationSubDetailId CreateUnique()
    {
        return new CollectorCommissionCalculationSubDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CollectorCommissionCalculationSubDetailId id) => id.Value.ToString();
    public static implicit operator Guid(CollectorCommissionCalculationSubDetailId id) => id.Value;
}
}
