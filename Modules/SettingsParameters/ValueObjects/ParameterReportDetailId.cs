using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SettingsParameters.ValueObjects
{
/// <summary>
/// ParameterReportDetail Identifier Value Object
/// </summary>
public sealed class ParameterReportDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ParameterReportDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ParameterReportDetailId instance
    /// </summary>
    public ParameterReportDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ParameterReportDetailId with a new GUID
    /// </summary>
    public static ParameterReportDetailId CreateUnique()
    {
        return new ParameterReportDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ParameterReportDetailId id) => id.Value.ToString();
    public static implicit operator Guid(ParameterReportDetailId id) => id.Value;
}
}
