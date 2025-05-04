using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// DefaultDataOnline Identifier Value Object
/// </summary>
public sealed class DefaultDataOnlineId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DefaultDataOnline
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DefaultDataOnlineId instance
    /// </summary>
    public DefaultDataOnlineId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DefaultDataOnlineId with a new GUID
    /// </summary>
    public static DefaultDataOnlineId CreateUnique()
    {
        return new DefaultDataOnlineId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DefaultDataOnlineId id) => id.Value.ToString();
    public static implicit operator Guid(DefaultDataOnlineId id) => id.Value;
}
}
