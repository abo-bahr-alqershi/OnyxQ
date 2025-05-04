using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects
{
/// <summary>
/// InsuranceCompanyClass Identifier Value Object
/// </summary>
public sealed class InsuranceCompanyClassId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InsuranceCompanyClass
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InsuranceCompanyClassId instance
    /// </summary>
    public InsuranceCompanyClassId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InsuranceCompanyClassId with a new GUID
    /// </summary>
    public static InsuranceCompanyClassId CreateUnique()
    {
        return new InsuranceCompanyClassId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InsuranceCompanyClassId id) => id.Value.ToString();
    public static implicit operator Guid(InsuranceCompanyClassId id) => id.Value;
}
}
