using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesmanSalesCommission Identifier Value Object
/// </summary>
public sealed class SalesmanSalesCommissionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesmanSalesCommission
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesmanSalesCommissionId instance
    /// </summary>
    public SalesmanSalesCommissionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesmanSalesCommissionId with a new GUID
    /// </summary>
    public static SalesmanSalesCommissionId CreateUnique()
    {
        return new SalesmanSalesCommissionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesmanSalesCommissionId id) => id.Value.ToString();
    public static implicit operator Guid(SalesmanSalesCommissionId id) => id.Value;
}
}
