using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects
{
/// <summary>
/// ReportSampleUser Identifier Value Object
/// </summary>
public sealed class ReportSampleUserId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ReportSampleUser
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ReportSampleUserId instance
    /// </summary>
    public ReportSampleUserId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ReportSampleUserId with a new GUID
    /// </summary>
    public static ReportSampleUserId CreateUnique()
    {
        return new ReportSampleUserId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ReportSampleUserId id) => id.Value.ToString();
    public static implicit operator Guid(ReportSampleUserId id) => id.Value;
}
}
