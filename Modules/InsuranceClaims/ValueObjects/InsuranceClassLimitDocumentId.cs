using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects
{
/// <summary>
/// InsuranceClassLimitDocument Identifier Value Object
/// </summary>
public sealed class InsuranceClassLimitDocumentId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InsuranceClassLimitDocument
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InsuranceClassLimitDocumentId instance
    /// </summary>
    public InsuranceClassLimitDocumentId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InsuranceClassLimitDocumentId with a new GUID
    /// </summary>
    public static InsuranceClassLimitDocumentId CreateUnique()
    {
        return new InsuranceClassLimitDocumentId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InsuranceClassLimitDocumentId id) => id.Value.ToString();
    public static implicit operator Guid(InsuranceClassLimitDocumentId id) => id.Value;
}
}
