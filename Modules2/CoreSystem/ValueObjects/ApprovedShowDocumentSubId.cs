using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// ApprovedShowDocumentSub Identifier Value Object
/// </summary>
public sealed class ApprovedShowDocumentSubId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ApprovedShowDocumentSub
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ApprovedShowDocumentSubId instance
    /// </summary>
    public ApprovedShowDocumentSubId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ApprovedShowDocumentSubId with a new GUID
    /// </summary>
    public static ApprovedShowDocumentSubId CreateUnique()
    {
        return new ApprovedShowDocumentSubId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ApprovedShowDocumentSubId id) => id.Value.ToString();
    public static implicit operator Guid(ApprovedShowDocumentSubId id) => id.Value;
}
}
