using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects
{
/// <summary>
/// AuditItemMaster Identifier Value Object
/// </summary>
public sealed class AuditItemMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AuditItemMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AuditItemMasterId instance
    /// </summary>
    public AuditItemMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AuditItemMasterId with a new GUID
    /// </summary>
    public static AuditItemMasterId CreateUnique()
    {
        return new AuditItemMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AuditItemMasterId id) => id.Value.ToString();
    public static implicit operator Guid(AuditItemMasterId id) => id.Value;
}
}
