using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects
{
/// <summary>
/// InsuranceCard Identifier Value Object
/// </summary>
public sealed class InsuranceCardId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InsuranceCard
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InsuranceCardId instance
    /// </summary>
    public InsuranceCardId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InsuranceCardId with a new GUID
    /// </summary>
    public static InsuranceCardId CreateUnique()
    {
        return new InsuranceCardId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InsuranceCardId id) => id.Value.ToString();
    public static implicit operator Guid(InsuranceCardId id) => id.Value;
}
}
