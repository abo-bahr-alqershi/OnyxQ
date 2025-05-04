using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// EmployeeCommissionSetupMaster Identifier Value Object
/// </summary>
public sealed class EmployeeCommissionSetupMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the EmployeeCommissionSetupMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new EmployeeCommissionSetupMasterId instance
    /// </summary>
    public EmployeeCommissionSetupMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new EmployeeCommissionSetupMasterId with a new GUID
    /// </summary>
    public static EmployeeCommissionSetupMasterId CreateUnique()
    {
        return new EmployeeCommissionSetupMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(EmployeeCommissionSetupMasterId id) => id.Value.ToString();
    public static implicit operator Guid(EmployeeCommissionSetupMasterId id) => id.Value;
}
}
