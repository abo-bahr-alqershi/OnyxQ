using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesPlanDetail Identifier Value Object
/// </summary>
public sealed class SalesPlanDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesPlanDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesPlanDetailId instance
    /// </summary>
    public SalesPlanDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesPlanDetailId with a new GUID
    /// </summary>
    public static SalesPlanDetailId CreateUnique()
    {
        return new SalesPlanDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesPlanDetailId id) => id.Value.ToString();
    public static implicit operator Guid(SalesPlanDetailId id) => id.Value;
}
}
