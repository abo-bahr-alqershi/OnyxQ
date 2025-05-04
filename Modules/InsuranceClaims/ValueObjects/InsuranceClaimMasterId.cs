using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects
{
/// <summary>
/// InsuranceClaimMaster Identifier Value Object
/// </summary>
public sealed class InsuranceClaimMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InsuranceClaimMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InsuranceClaimMasterId instance
    /// </summary>
    public InsuranceClaimMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InsuranceClaimMasterId with a new GUID
    /// </summary>
    public static InsuranceClaimMasterId CreateUnique()
    {
        return new InsuranceClaimMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InsuranceClaimMasterId id) => id.Value.ToString();
    public static implicit operator Guid(InsuranceClaimMasterId id) => id.Value;
}
}
