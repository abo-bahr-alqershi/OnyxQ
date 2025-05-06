using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects
{
/// <summary>
/// InsuranceClassLimitMonth Identifier Value Object
/// </summary>
public sealed class InsuranceClassLimitMonthId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InsuranceClassLimitMonth
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InsuranceClassLimitMonthId instance
    /// </summary>
    public InsuranceClassLimitMonthId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InsuranceClassLimitMonthId with a new GUID
    /// </summary>
    public static InsuranceClassLimitMonthId CreateUnique()
    {
        return new InsuranceClassLimitMonthId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InsuranceClassLimitMonthId id) => id.Value.ToString();
    public static implicit operator Guid(InsuranceClassLimitMonthId id) => id.Value;
}
}
