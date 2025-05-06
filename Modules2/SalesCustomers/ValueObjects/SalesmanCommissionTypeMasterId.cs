using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesmanCommissionTypeMaster Identifier Value Object
/// </summary>
public sealed class SalesmanCommissionTypeMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesmanCommissionTypeMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesmanCommissionTypeMasterId instance
    /// </summary>
    public SalesmanCommissionTypeMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesmanCommissionTypeMasterId with a new GUID
    /// </summary>
    public static SalesmanCommissionTypeMasterId CreateUnique()
    {
        return new SalesmanCommissionTypeMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesmanCommissionTypeMasterId id) => id.Value.ToString();
    public static implicit operator Guid(SalesmanCommissionTypeMasterId id) => id.Value;
}
}
