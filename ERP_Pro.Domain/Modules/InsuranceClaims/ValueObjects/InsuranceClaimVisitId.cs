using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects
{
/// <summary>
/// InsuranceClaimVisit Identifier Value Object
/// </summary>
public sealed class InsuranceClaimVisitId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InsuranceClaimVisit
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InsuranceClaimVisitId instance
    /// </summary>
    public InsuranceClaimVisitId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InsuranceClaimVisitId with a new GUID
    /// </summary>
    public static InsuranceClaimVisitId CreateUnique()
    {
        return new InsuranceClaimVisitId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InsuranceClaimVisitId id) => id.Value.ToString();
    public static implicit operator Guid(InsuranceClaimVisitId id) => id.Value;
}
}
