using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// ReportUserTemplateMaster Identifier Value Object
/// </summary>
public sealed class ReportUserTemplateMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ReportUserTemplateMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ReportUserTemplateMasterId instance
    /// </summary>
    public ReportUserTemplateMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ReportUserTemplateMasterId with a new GUID
    /// </summary>
    public static ReportUserTemplateMasterId CreateUnique()
    {
        return new ReportUserTemplateMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ReportUserTemplateMasterId id) => id.Value.ToString();
    public static implicit operator Guid(ReportUserTemplateMasterId id) => id.Value;
}
}
