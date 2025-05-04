using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects
{
/// <summary>
/// InsuranceClassMedicalNetwork Identifier Value Object
/// </summary>
public sealed class InsuranceClassMedicalNetworkId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InsuranceClassMedicalNetwork
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InsuranceClassMedicalNetworkId instance
    /// </summary>
    public InsuranceClassMedicalNetworkId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InsuranceClassMedicalNetworkId with a new GUID
    /// </summary>
    public static InsuranceClassMedicalNetworkId CreateUnique()
    {
        return new InsuranceClassMedicalNetworkId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InsuranceClassMedicalNetworkId id) => id.Value.ToString();
    public static implicit operator Guid(InsuranceClassMedicalNetworkId id) => id.Value;
}
}
