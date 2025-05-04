using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects
{
/// <summary>
/// InsuranceClassItemType Identifier Value Object
/// </summary>
public sealed class InsuranceClassItemTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InsuranceClassItemType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InsuranceClassItemTypeId instance
    /// </summary>
    public InsuranceClassItemTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InsuranceClassItemTypeId with a new GUID
    /// </summary>
    public static InsuranceClassItemTypeId CreateUnique()
    {
        return new InsuranceClassItemTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InsuranceClassItemTypeId id) => id.Value.ToString();
    public static implicit operator Guid(InsuranceClassItemTypeId id) => id.Value;
}
}
