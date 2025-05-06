using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects
{
/// <summary>
/// InsuranceCardChronic Identifier Value Object
/// </summary>
public sealed class InsuranceCardChronicId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InsuranceCardChronic
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InsuranceCardChronicId instance
    /// </summary>
    public InsuranceCardChronicId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InsuranceCardChronicId with a new GUID
    /// </summary>
    public static InsuranceCardChronicId CreateUnique()
    {
        return new InsuranceCardChronicId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InsuranceCardChronicId id) => id.Value.ToString();
    public static implicit operator Guid(InsuranceCardChronicId id) => id.Value;
}
}
