using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects
{
/// <summary>
/// AuditAccountDetail Identifier Value Object
/// </summary>
public sealed class AuditAccountDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AuditAccountDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AuditAccountDetailId instance
    /// </summary>
    public AuditAccountDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AuditAccountDetailId with a new GUID
    /// </summary>
    public static AuditAccountDetailId CreateUnique()
    {
        return new AuditAccountDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AuditAccountDetailId id) => id.Value.ToString();
    public static implicit operator Guid(AuditAccountDetailId id) => id.Value;
}
}
