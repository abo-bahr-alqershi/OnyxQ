using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// WeeklyReportTemp Identifier Value Object
/// </summary>
public sealed class WeeklyReportTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the WeeklyReportTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new WeeklyReportTempId instance
    /// </summary>
    public WeeklyReportTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new WeeklyReportTempId with a new GUID
    /// </summary>
    public static WeeklyReportTempId CreateUnique()
    {
        return new WeeklyReportTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(WeeklyReportTempId id) => id.Value.ToString();
    public static implicit operator Guid(WeeklyReportTempId id) => id.Value;
}
}
