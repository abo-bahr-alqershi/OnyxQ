using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ParameterOnline Identifier Value Object
/// </summary>
public sealed class ParameterOnlineId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ParameterOnline
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ParameterOnlineId instance
    /// </summary>
    public ParameterOnlineId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ParameterOnlineId with a new GUID
    /// </summary>
    public static ParameterOnlineId CreateUnique()
    {
        return new ParameterOnlineId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ParameterOnlineId id) => id.Value.ToString();
    public static implicit operator Guid(ParameterOnlineId id) => id.Value;
}
}
