using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.HumanResources.ValueObjects
{
/// <summary>
/// EmployeeGuarantor Identifier Value Object
/// </summary>
public sealed class EmployeeGuarantorId : ValueObject
{
    /// <summary>
    /// The unique identifier for the EmployeeGuarantor
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new EmployeeGuarantorId instance
    /// </summary>
    public EmployeeGuarantorId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new EmployeeGuarantorId with a new GUID
    /// </summary>
    public static EmployeeGuarantorId CreateUnique()
    {
        return new EmployeeGuarantorId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(EmployeeGuarantorId id) => id.Value.ToString();
    public static implicit operator Guid(EmployeeGuarantorId id) => id.Value;
}
}
