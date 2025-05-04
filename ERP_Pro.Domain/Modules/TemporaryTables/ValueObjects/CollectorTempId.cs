using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// CollectorTemp Identifier Value Object
/// </summary>
public sealed class CollectorTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CollectorTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CollectorTempId instance
    /// </summary>
    public CollectorTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CollectorTempId with a new GUID
    /// </summary>
    public static CollectorTempId CreateUnique()
    {
        return new CollectorTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CollectorTempId id) => id.Value.ToString();
    public static implicit operator Guid(CollectorTempId id) => id.Value;
}
}
