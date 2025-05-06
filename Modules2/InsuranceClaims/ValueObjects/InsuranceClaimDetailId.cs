using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects
{
/// <summary>
/// InsuranceClaimDetail Identifier Value Object
/// </summary>
public sealed class InsuranceClaimDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InsuranceClaimDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InsuranceClaimDetailId instance
    /// </summary>
    public InsuranceClaimDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InsuranceClaimDetailId with a new GUID
    /// </summary>
    public static InsuranceClaimDetailId CreateUnique()
    {
        return new InsuranceClaimDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InsuranceClaimDetailId id) => id.Value.ToString();
    public static implicit operator Guid(InsuranceClaimDetailId id) => id.Value;
}
}
