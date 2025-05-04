using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// PointTypeCalculationDetail Identifier Value Object
/// </summary>
public sealed class PointTypeCalculationDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PointTypeCalculationDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PointTypeCalculationDetailId instance
    /// </summary>
    public PointTypeCalculationDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PointTypeCalculationDetailId with a new GUID
    /// </summary>
    public static PointTypeCalculationDetailId CreateUnique()
    {
        return new PointTypeCalculationDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PointTypeCalculationDetailId id) => id.Value.ToString();
    public static implicit operator Guid(PointTypeCalculationDetailId id) => id.Value;
}
}
