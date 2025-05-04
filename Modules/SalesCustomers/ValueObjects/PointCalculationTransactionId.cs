using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// PointCalculationTransaction Identifier Value Object
/// </summary>
public sealed class PointCalculationTransactionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PointCalculationTransaction
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PointCalculationTransactionId instance
    /// </summary>
    public PointCalculationTransactionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PointCalculationTransactionId with a new GUID
    /// </summary>
    public static PointCalculationTransactionId CreateUnique()
    {
        return new PointCalculationTransactionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PointCalculationTransactionId id) => id.Value.ToString();
    public static implicit operator Guid(PointCalculationTransactionId id) => id.Value;
}
}
