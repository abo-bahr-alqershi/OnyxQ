using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects
{
/// <summary>
/// AuditLimitExceeded Identifier Value Object
/// </summary>
public sealed class AuditLimitExceededId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AuditLimitExceeded
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AuditLimitExceededId instance
    /// </summary>
    public AuditLimitExceededId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AuditLimitExceededId with a new GUID
    /// </summary>
    public static AuditLimitExceededId CreateUnique()
    {
        return new AuditLimitExceededId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AuditLimitExceededId id) => id.Value.ToString();
    public static implicit operator Guid(AuditLimitExceededId id) => id.Value;
}
}
