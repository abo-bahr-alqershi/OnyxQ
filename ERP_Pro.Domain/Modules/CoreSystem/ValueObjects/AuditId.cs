using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// Audit Identifier Value Object
/// </summary>
public sealed class AuditId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Audit
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AuditId instance
    /// </summary>
    public AuditId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AuditId with a new GUID
    /// </summary>
    public static AuditId CreateUnique()
    {
        return new AuditId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AuditId id) => id.Value.ToString();
    public static implicit operator Guid(AuditId id) => id.Value;
}
}
