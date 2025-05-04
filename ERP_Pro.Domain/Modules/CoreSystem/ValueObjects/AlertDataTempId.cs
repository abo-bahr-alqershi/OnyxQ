using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// AlertDataTemp Identifier Value Object
/// </summary>
public sealed class AlertDataTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AlertDataTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AlertDataTempId instance
    /// </summary>
    public AlertDataTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AlertDataTempId with a new GUID
    /// </summary>
    public static AlertDataTempId CreateUnique()
    {
        return new AlertDataTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AlertDataTempId id) => id.Value.ToString();
    public static implicit operator Guid(AlertDataTempId id) => id.Value;
}
}
