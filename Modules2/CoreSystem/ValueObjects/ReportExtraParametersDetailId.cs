using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// ReportExtraParametersDetail Identifier Value Object
/// </summary>
public sealed class ReportExtraParametersDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ReportExtraParametersDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ReportExtraParametersDetailId instance
    /// </summary>
    public ReportExtraParametersDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ReportExtraParametersDetailId with a new GUID
    /// </summary>
    public static ReportExtraParametersDetailId CreateUnique()
    {
        return new ReportExtraParametersDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ReportExtraParametersDetailId id) => id.Value.ToString();
    public static implicit operator Guid(ReportExtraParametersDetailId id) => id.Value;
}
}
