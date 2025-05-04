using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.ValueObjects
{
/// <summary>
/// Beneficiaries Identifier Value Object
/// </summary>
public sealed class BeneficiariesId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Beneficiaries
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BeneficiariesId instance
    /// </summary>
    public BeneficiariesId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BeneficiariesId with a new GUID
    /// </summary>
    public static BeneficiariesId CreateUnique()
    {
        return new BeneficiariesId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BeneficiariesId id) => id.Value.ToString();
    public static implicit operator Guid(BeneficiariesId id) => id.Value;
}
}
