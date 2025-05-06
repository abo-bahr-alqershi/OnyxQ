using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesmanCommissionDetail Identifier Value Object
/// </summary>
public sealed class SalesmanCommissionDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesmanCommissionDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesmanCommissionDetailId instance
    /// </summary>
    public SalesmanCommissionDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesmanCommissionDetailId with a new GUID
    /// </summary>
    public static SalesmanCommissionDetailId CreateUnique()
    {
        return new SalesmanCommissionDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesmanCommissionDetailId id) => id.Value.ToString();
    public static implicit operator Guid(SalesmanCommissionDetailId id) => id.Value;
}
}
