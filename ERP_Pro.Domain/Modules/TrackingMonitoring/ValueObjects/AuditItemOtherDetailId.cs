using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects
{
/// <summary>
/// AuditItemOtherDetail Identifier Value Object
/// </summary>
public sealed class AuditItemOtherDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AuditItemOtherDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AuditItemOtherDetailId instance
    /// </summary>
    public AuditItemOtherDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AuditItemOtherDetailId with a new GUID
    /// </summary>
    public static AuditItemOtherDetailId CreateUnique()
    {
        return new AuditItemOtherDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AuditItemOtherDetailId id) => id.Value.ToString();
    public static implicit operator Guid(AuditItemOtherDetailId id) => id.Value;
}
}
