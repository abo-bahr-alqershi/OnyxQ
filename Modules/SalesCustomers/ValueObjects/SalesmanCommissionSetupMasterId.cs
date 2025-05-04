using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesmanCommissionSetupMaster Identifier Value Object
/// </summary>
public sealed class SalesmanCommissionSetupMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesmanCommissionSetupMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesmanCommissionSetupMasterId instance
    /// </summary>
    public SalesmanCommissionSetupMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesmanCommissionSetupMasterId with a new GUID
    /// </summary>
    public static SalesmanCommissionSetupMasterId CreateUnique()
    {
        return new SalesmanCommissionSetupMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesmanCommissionSetupMasterId id) => id.Value.ToString();
    public static implicit operator Guid(SalesmanCommissionSetupMasterId id) => id.Value;
}
}
