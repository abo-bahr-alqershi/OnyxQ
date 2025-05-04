using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// MissingEquityDetailTemp Identifier Value Object
/// </summary>
public sealed class MissingEquityDetailTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the MissingEquityDetailTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new MissingEquityDetailTempId instance
    /// </summary>
    public MissingEquityDetailTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new MissingEquityDetailTempId with a new GUID
    /// </summary>
    public static MissingEquityDetailTempId CreateUnique()
    {
        return new MissingEquityDetailTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(MissingEquityDetailTempId id) => id.Value.ToString();
    public static implicit operator Guid(MissingEquityDetailTempId id) => id.Value;
}
}
