using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesmanCommissionTypeDetail Identifier Value Object
/// </summary>
public sealed class SalesmanCommissionTypeDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesmanCommissionTypeDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesmanCommissionTypeDetailId instance
    /// </summary>
    public SalesmanCommissionTypeDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesmanCommissionTypeDetailId with a new GUID
    /// </summary>
    public static SalesmanCommissionTypeDetailId CreateUnique()
    {
        return new SalesmanCommissionTypeDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesmanCommissionTypeDetailId id) => id.Value.ToString();
    public static implicit operator Guid(SalesmanCommissionTypeDetailId id) => id.Value;
}
}
