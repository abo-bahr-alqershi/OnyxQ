using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects
{
/// <summary>
/// InsuranceClassGroupItemOut Identifier Value Object
/// </summary>
public sealed class InsuranceClassGroupItemOutId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InsuranceClassGroupItemOut
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InsuranceClassGroupItemOutId instance
    /// </summary>
    public InsuranceClassGroupItemOutId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InsuranceClassGroupItemOutId with a new GUID
    /// </summary>
    public static InsuranceClassGroupItemOutId CreateUnique()
    {
        return new InsuranceClassGroupItemOutId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InsuranceClassGroupItemOutId id) => id.Value.ToString();
    public static implicit operator Guid(InsuranceClassGroupItemOutId id) => id.Value;
}
}
