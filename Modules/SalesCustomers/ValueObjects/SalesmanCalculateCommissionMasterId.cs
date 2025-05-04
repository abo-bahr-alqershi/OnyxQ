using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesmanCalculateCommissionMaster Identifier Value Object
/// </summary>
public sealed class SalesmanCalculateCommissionMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesmanCalculateCommissionMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesmanCalculateCommissionMasterId instance
    /// </summary>
    public SalesmanCalculateCommissionMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesmanCalculateCommissionMasterId with a new GUID
    /// </summary>
    public static SalesmanCalculateCommissionMasterId CreateUnique()
    {
        return new SalesmanCalculateCommissionMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesmanCalculateCommissionMasterId id) => id.Value.ToString();
    public static implicit operator Guid(SalesmanCalculateCommissionMasterId id) => id.Value;
}
}
