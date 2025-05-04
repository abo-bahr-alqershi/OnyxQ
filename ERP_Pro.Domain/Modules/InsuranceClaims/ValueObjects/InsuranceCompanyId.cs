using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects
{
/// <summary>
/// InsuranceCompany Identifier Value Object
/// </summary>
public sealed class InsuranceCompanyId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InsuranceCompany
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InsuranceCompanyId instance
    /// </summary>
    public InsuranceCompanyId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InsuranceCompanyId with a new GUID
    /// </summary>
    public static InsuranceCompanyId CreateUnique()
    {
        return new InsuranceCompanyId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InsuranceCompanyId id) => id.Value.ToString();
    public static implicit operator Guid(InsuranceCompanyId id) => id.Value;
}
}
