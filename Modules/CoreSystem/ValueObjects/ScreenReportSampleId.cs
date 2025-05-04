using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// ScreenReportSample Identifier Value Object
/// </summary>
public sealed class ScreenReportSampleId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ScreenReportSample
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ScreenReportSampleId instance
    /// </summary>
    public ScreenReportSampleId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ScreenReportSampleId with a new GUID
    /// </summary>
    public static ScreenReportSampleId CreateUnique()
    {
        return new ScreenReportSampleId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ScreenReportSampleId id) => id.Value.ToString();
    public static implicit operator Guid(ScreenReportSampleId id) => id.Value;
}
}
