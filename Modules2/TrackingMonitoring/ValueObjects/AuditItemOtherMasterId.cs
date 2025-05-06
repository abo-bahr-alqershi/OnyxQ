using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects
{
/// <summary>
/// AuditItemOtherMaster Identifier Value Object
/// </summary>
public sealed class AuditItemOtherMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AuditItemOtherMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AuditItemOtherMasterId instance
    /// </summary>
    public AuditItemOtherMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AuditItemOtherMasterId with a new GUID
    /// </summary>
    public static AuditItemOtherMasterId CreateUnique()
    {
        return new AuditItemOtherMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AuditItemOtherMasterId id) => id.Value.ToString();
    public static implicit operator Guid(AuditItemOtherMasterId id) => id.Value;
}
}
