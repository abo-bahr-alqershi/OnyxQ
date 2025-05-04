using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesmanEmployeeCalculateCommission Identifier Value Object
/// </summary>
public sealed class SalesmanEmployeeCalculateCommissionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesmanEmployeeCalculateCommission
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesmanEmployeeCalculateCommissionId instance
    /// </summary>
    public SalesmanEmployeeCalculateCommissionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesmanEmployeeCalculateCommissionId with a new GUID
    /// </summary>
    public static SalesmanEmployeeCalculateCommissionId CreateUnique()
    {
        return new SalesmanEmployeeCalculateCommissionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesmanEmployeeCalculateCommissionId id) => id.Value.ToString();
    public static implicit operator Guid(SalesmanEmployeeCalculateCommissionId id) => id.Value;
}
}
