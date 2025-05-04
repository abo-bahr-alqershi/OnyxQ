using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects
{
/// <summary>
/// AuditPrintReport Identifier Value Object
/// </summary>
public sealed class AuditPrintReportId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AuditPrintReport
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AuditPrintReportId instance
    /// </summary>
    public AuditPrintReportId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AuditPrintReportId with a new GUID
    /// </summary>
    public static AuditPrintReportId CreateUnique()
    {
        return new AuditPrintReportId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AuditPrintReportId id) => id.Value.ToString();
    public static implicit operator Guid(AuditPrintReportId id) => id.Value;
}
}
