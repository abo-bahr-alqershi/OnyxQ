using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesCommission Identifier Value Object
/// </summary>
public sealed class SalesCommissionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesCommission
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesCommissionId instance
    /// </summary>
    public SalesCommissionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesCommissionId with a new GUID
    /// </summary>
    public static SalesCommissionId CreateUnique()
    {
        return new SalesCommissionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesCommissionId id) => id.Value.ToString();
    public static implicit operator Guid(SalesCommissionId id) => id.Value;
}
}
