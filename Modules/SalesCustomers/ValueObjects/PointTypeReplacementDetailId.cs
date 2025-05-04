using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// PointTypeReplacementDetail Identifier Value Object
/// </summary>
public sealed class PointTypeReplacementDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PointTypeReplacementDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PointTypeReplacementDetailId instance
    /// </summary>
    public PointTypeReplacementDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PointTypeReplacementDetailId with a new GUID
    /// </summary>
    public static PointTypeReplacementDetailId CreateUnique()
    {
        return new PointTypeReplacementDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PointTypeReplacementDetailId id) => id.Value.ToString();
    public static implicit operator Guid(PointTypeReplacementDetailId id) => id.Value;
}
}
