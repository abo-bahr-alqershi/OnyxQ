using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// AuditReportTemp Identifier Value Object
/// </summary>
public sealed class AuditReportTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AuditReportTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AuditReportTempId instance
    /// </summary>
    public AuditReportTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AuditReportTempId with a new GUID
    /// </summary>
    public static AuditReportTempId CreateUnique()
    {
        return new AuditReportTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AuditReportTempId id) => id.Value.ToString();
    public static implicit operator Guid(AuditReportTempId id) => id.Value;
}
}
