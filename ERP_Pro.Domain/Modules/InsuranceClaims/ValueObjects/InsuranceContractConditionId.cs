using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects
{
/// <summary>
/// InsuranceContractCondition Identifier Value Object
/// </summary>
public sealed class InsuranceContractConditionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InsuranceContractCondition
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InsuranceContractConditionId instance
    /// </summary>
    public InsuranceContractConditionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InsuranceContractConditionId with a new GUID
    /// </summary>
    public static InsuranceContractConditionId CreateUnique()
    {
        return new InsuranceContractConditionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InsuranceContractConditionId id) => id.Value.ToString();
    public static implicit operator Guid(InsuranceContractConditionId id) => id.Value;
}
}
