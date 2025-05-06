using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TaxFees.ValueObjects
{
/// <summary>
/// GstReportMaster Identifier Value Object
/// </summary>
public sealed class GstReportMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GstReportMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GstReportMasterId instance
    /// </summary>
    public GstReportMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GstReportMasterId with a new GUID
    /// </summary>
    public static GstReportMasterId CreateUnique()
    {
        return new GstReportMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GstReportMasterId id) => id.Value.ToString();
    public static implicit operator Guid(GstReportMasterId id) => id.Value;
}
}
