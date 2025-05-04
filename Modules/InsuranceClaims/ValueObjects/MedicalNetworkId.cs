using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects
{
/// <summary>
/// MedicalNetwork Identifier Value Object
/// </summary>
public sealed class MedicalNetworkId : ValueObject
{
    /// <summary>
    /// The unique identifier for the MedicalNetwork
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new MedicalNetworkId instance
    /// </summary>
    public MedicalNetworkId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new MedicalNetworkId with a new GUID
    /// </summary>
    public static MedicalNetworkId CreateUnique()
    {
        return new MedicalNetworkId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(MedicalNetworkId id) => id.Value.ToString();
    public static implicit operator Guid(MedicalNetworkId id) => id.Value;
}
}
