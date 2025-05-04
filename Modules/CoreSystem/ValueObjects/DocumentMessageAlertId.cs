using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// DocumentMessageAlert Identifier Value Object
/// </summary>
public sealed class DocumentMessageAlertId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DocumentMessageAlert
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DocumentMessageAlertId instance
    /// </summary>
    public DocumentMessageAlertId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DocumentMessageAlertId with a new GUID
    /// </summary>
    public static DocumentMessageAlertId CreateUnique()
    {
        return new DocumentMessageAlertId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DocumentMessageAlertId id) => id.Value.ToString();
    public static implicit operator Guid(DocumentMessageAlertId id) => id.Value;
}
}
