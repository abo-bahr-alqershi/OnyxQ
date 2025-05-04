using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects
{
/// <summary>
/// AuditHistory Identifier Value Object
/// </summary>
public sealed class AuditHistoryId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AuditHistory
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AuditHistoryId instance
    /// </summary>
    public AuditHistoryId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AuditHistoryId with a new GUID
    /// </summary>
    public static AuditHistoryId CreateUnique()
    {
        return new AuditHistoryId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AuditHistoryId id) => id.Value.ToString();
    public static implicit operator Guid(AuditHistoryId id) => id.Value;
}
}
