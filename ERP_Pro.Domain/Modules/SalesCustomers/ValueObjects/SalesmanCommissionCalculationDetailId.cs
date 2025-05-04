using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesmanCommissionCalculationDetail Identifier Value Object
/// </summary>
public sealed class SalesmanCommissionCalculationDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesmanCommissionCalculationDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesmanCommissionCalculationDetailId instance
    /// </summary>
    public SalesmanCommissionCalculationDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesmanCommissionCalculationDetailId with a new GUID
    /// </summary>
    public static SalesmanCommissionCalculationDetailId CreateUnique()
    {
        return new SalesmanCommissionCalculationDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesmanCommissionCalculationDetailId id) => id.Value.ToString();
    public static implicit operator Guid(SalesmanCommissionCalculationDetailId id) => id.Value;
}
}
