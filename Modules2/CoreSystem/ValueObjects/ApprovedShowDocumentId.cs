using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// ApprovedShowDocument Identifier Value Object
/// </summary>
public sealed class ApprovedShowDocumentId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ApprovedShowDocument
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ApprovedShowDocumentId instance
    /// </summary>
    public ApprovedShowDocumentId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ApprovedShowDocumentId with a new GUID
    /// </summary>
    public static ApprovedShowDocumentId CreateUnique()
    {
        return new ApprovedShowDocumentId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ApprovedShowDocumentId id) => id.Value.ToString();
    public static implicit operator Guid(ApprovedShowDocumentId id) => id.Value;
}
}
