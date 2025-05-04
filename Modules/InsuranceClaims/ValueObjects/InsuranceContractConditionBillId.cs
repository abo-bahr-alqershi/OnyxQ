using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects
{
/// <summary>
/// InsuranceContractConditionBill Identifier Value Object
/// </summary>
public sealed class InsuranceContractConditionBillId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InsuranceContractConditionBill
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InsuranceContractConditionBillId instance
    /// </summary>
    public InsuranceContractConditionBillId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InsuranceContractConditionBillId with a new GUID
    /// </summary>
    public static InsuranceContractConditionBillId CreateUnique()
    {
        return new InsuranceContractConditionBillId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InsuranceContractConditionBillId id) => id.Value.ToString();
    public static implicit operator Guid(InsuranceContractConditionBillId id) => id.Value;
}
}
