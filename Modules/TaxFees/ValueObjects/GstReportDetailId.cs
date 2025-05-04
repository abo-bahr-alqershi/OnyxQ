using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TaxFees.ValueObjects
{
/// <summary>
/// GstReportDetail Identifier Value Object
/// </summary>
public sealed class GstReportDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GstReportDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GstReportDetailId instance
    /// </summary>
    public GstReportDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GstReportDetailId with a new GUID
    /// </summary>
    public static GstReportDetailId CreateUnique()
    {
        return new GstReportDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GstReportDetailId id) => id.Value.ToString();
    public static implicit operator Guid(GstReportDetailId id) => id.Value;
}
}
