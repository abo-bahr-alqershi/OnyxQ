using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// EmployeeCommissionSetupDetail Identifier Value Object
/// </summary>
public sealed class EmployeeCommissionSetupDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the EmployeeCommissionSetupDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new EmployeeCommissionSetupDetailId instance
    /// </summary>
    public EmployeeCommissionSetupDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new EmployeeCommissionSetupDetailId with a new GUID
    /// </summary>
    public static EmployeeCommissionSetupDetailId CreateUnique()
    {
        return new EmployeeCommissionSetupDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(EmployeeCommissionSetupDetailId id) => id.Value.ToString();
    public static implicit operator Guid(EmployeeCommissionSetupDetailId id) => id.Value;
}
}
