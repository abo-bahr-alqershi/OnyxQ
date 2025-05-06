using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CalculateCommissionMaster Identifier Value Object
/// </summary>
public sealed class CalculateCommissionMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CalculateCommissionMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CalculateCommissionMasterId instance
    /// </summary>
    public CalculateCommissionMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CalculateCommissionMasterId with a new GUID
    /// </summary>
    public static CalculateCommissionMasterId CreateUnique()
    {
        return new CalculateCommissionMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CalculateCommissionMasterId id) => id.Value.ToString();
    public static implicit operator Guid(CalculateCommissionMasterId id) => id.Value;
}
}
