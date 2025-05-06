using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CollectorCommissionSetupMaster Identifier Value Object
/// </summary>
public sealed class CollectorCommissionSetupMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CollectorCommissionSetupMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CollectorCommissionSetupMasterId instance
    /// </summary>
    public CollectorCommissionSetupMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CollectorCommissionSetupMasterId with a new GUID
    /// </summary>
    public static CollectorCommissionSetupMasterId CreateUnique()
    {
        return new CollectorCommissionSetupMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CollectorCommissionSetupMasterId id) => id.Value.ToString();
    public static implicit operator Guid(CollectorCommissionSetupMasterId id) => id.Value;
}
}
