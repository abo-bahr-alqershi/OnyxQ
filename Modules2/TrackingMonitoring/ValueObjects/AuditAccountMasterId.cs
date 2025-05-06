using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects
{
/// <summary>
/// AuditAccountMaster Identifier Value Object
/// </summary>
public sealed class AuditAccountMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AuditAccountMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AuditAccountMasterId instance
    /// </summary>
    public AuditAccountMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AuditAccountMasterId with a new GUID
    /// </summary>
    public static AuditAccountMasterId CreateUnique()
    {
        return new AuditAccountMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AuditAccountMasterId id) => id.Value.ToString();
    public static implicit operator Guid(AuditAccountMasterId id) => id.Value;
}
}
