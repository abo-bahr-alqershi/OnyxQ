using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// ReportUserTemplateDetail Identifier Value Object
/// </summary>
public sealed class ReportUserTemplateDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ReportUserTemplateDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ReportUserTemplateDetailId instance
    /// </summary>
    public ReportUserTemplateDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ReportUserTemplateDetailId with a new GUID
    /// </summary>
    public static ReportUserTemplateDetailId CreateUnique()
    {
        return new ReportUserTemplateDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ReportUserTemplateDetailId id) => id.Value.ToString();
    public static implicit operator Guid(ReportUserTemplateDetailId id) => id.Value;
}
}
