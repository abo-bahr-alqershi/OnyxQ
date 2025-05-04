using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// LogCheckBeforeClose Identifier Value Object
/// </summary>
public sealed class LogCheckBeforeCloseId : ValueObject
{
    /// <summary>
    /// The unique identifier for the LogCheckBeforeClose
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new LogCheckBeforeCloseId instance
    /// </summary>
    public LogCheckBeforeCloseId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new LogCheckBeforeCloseId with a new GUID
    /// </summary>
    public static LogCheckBeforeCloseId CreateUnique()
    {
        return new LogCheckBeforeCloseId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(LogCheckBeforeCloseId id) => id.Value.ToString();
    public static implicit operator Guid(LogCheckBeforeCloseId id) => id.Value;
}
}
