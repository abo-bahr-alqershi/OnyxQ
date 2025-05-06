using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// PointTypeMaster Identifier Value Object
/// </summary>
public sealed class PointTypeMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PointTypeMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PointTypeMasterId instance
    /// </summary>
    public PointTypeMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PointTypeMasterId with a new GUID
    /// </summary>
    public static PointTypeMasterId CreateUnique()
    {
        return new PointTypeMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PointTypeMasterId id) => id.Value.ToString();
    public static implicit operator Guid(PointTypeMasterId id) => id.Value;
}
}
