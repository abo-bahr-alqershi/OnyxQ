using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesmanCommissionCalculationSubDetail Identifier Value Object
/// </summary>
public sealed class SalesmanCommissionCalculationSubDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesmanCommissionCalculationSubDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesmanCommissionCalculationSubDetailId instance
    /// </summary>
    public SalesmanCommissionCalculationSubDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesmanCommissionCalculationSubDetailId with a new GUID
    /// </summary>
    public static SalesmanCommissionCalculationSubDetailId CreateUnique()
    {
        return new SalesmanCommissionCalculationSubDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesmanCommissionCalculationSubDetailId id) => id.Value.ToString();
    public static implicit operator Guid(SalesmanCommissionCalculationSubDetailId id) => id.Value;
}
}
