using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesmanCommissionSlice Identifier Value Object
/// </summary>
public sealed class SalesmanCommissionSliceId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesmanCommissionSlice
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesmanCommissionSliceId instance
    /// </summary>
    public SalesmanCommissionSliceId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesmanCommissionSliceId with a new GUID
    /// </summary>
    public static SalesmanCommissionSliceId CreateUnique()
    {
        return new SalesmanCommissionSliceId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesmanCommissionSliceId id) => id.Value.ToString();
    public static implicit operator Guid(SalesmanCommissionSliceId id) => id.Value;
}
}
