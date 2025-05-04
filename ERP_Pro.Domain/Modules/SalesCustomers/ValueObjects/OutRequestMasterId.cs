using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// OutRequestMaster Identifier Value Object
/// </summary>
public sealed class OutRequestMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the OutRequestMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new OutRequestMasterId instance
    /// </summary>
    public OutRequestMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new OutRequestMasterId with a new GUID
    /// </summary>
    public static OutRequestMasterId CreateUnique()
    {
        return new OutRequestMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(OutRequestMasterId id) => id.Value.ToString();
    public static implicit operator Guid(OutRequestMasterId id) => id.Value;
}
}
