using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects
{
/// <summary>
/// AuditItemDetail Identifier Value Object
/// </summary>
public sealed class AuditItemDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AuditItemDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AuditItemDetailId instance
    /// </summary>
    public AuditItemDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AuditItemDetailId with a new GUID
    /// </summary>
    public static AuditItemDetailId CreateUnique()
    {
        return new AuditItemDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AuditItemDetailId id) => id.Value.ToString();
    public static implicit operator Guid(AuditItemDetailId id) => id.Value;
}
}
