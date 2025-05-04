using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SettingsParameters.ValueObjects
{
/// <summary>
/// ParameterReportMaster Identifier Value Object
/// </summary>
public sealed class ParameterReportMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ParameterReportMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ParameterReportMasterId instance
    /// </summary>
    public ParameterReportMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ParameterReportMasterId with a new GUID
    /// </summary>
    public static ParameterReportMasterId CreateUnique()
    {
        return new ParameterReportMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ParameterReportMasterId id) => id.Value.ToString();
    public static implicit operator Guid(ParameterReportMasterId id) => id.Value;
}
}
