using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesmanCalculateCommissionDetail Identifier Value Object
/// </summary>
public sealed class SalesmanCalculateCommissionDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesmanCalculateCommissionDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesmanCalculateCommissionDetailId instance
    /// </summary>
    public SalesmanCalculateCommissionDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesmanCalculateCommissionDetailId with a new GUID
    /// </summary>
    public static SalesmanCalculateCommissionDetailId CreateUnique()
    {
        return new SalesmanCalculateCommissionDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesmanCalculateCommissionDetailId id) => id.Value.ToString();
    public static implicit operator Guid(SalesmanCalculateCommissionDetailId id) => id.Value;
}
}
