using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesPlanMaster Identifier Value Object
/// </summary>
public sealed class SalesPlanMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesPlanMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesPlanMasterId instance
    /// </summary>
    public SalesPlanMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesPlanMasterId with a new GUID
    /// </summary>
    public static SalesPlanMasterId CreateUnique()
    {
        return new SalesPlanMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesPlanMasterId id) => id.Value.ToString();
    public static implicit operator Guid(SalesPlanMasterId id) => id.Value;
}
}
