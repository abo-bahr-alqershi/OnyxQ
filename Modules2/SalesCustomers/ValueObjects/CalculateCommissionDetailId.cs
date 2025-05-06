using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CalculateCommissionDetail Identifier Value Object
/// </summary>
public sealed class CalculateCommissionDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CalculateCommissionDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CalculateCommissionDetailId instance
    /// </summary>
    public CalculateCommissionDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CalculateCommissionDetailId with a new GUID
    /// </summary>
    public static CalculateCommissionDetailId CreateUnique()
    {
        return new CalculateCommissionDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CalculateCommissionDetailId id) => id.Value.ToString();
    public static implicit operator Guid(CalculateCommissionDetailId id) => id.Value;
}
}
