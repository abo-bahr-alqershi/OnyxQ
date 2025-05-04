using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// SystemLog Identifier Value Object
/// </summary>
public sealed class SystemLogId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SystemLog
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SystemLogId instance
    /// </summary>
    public SystemLogId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SystemLogId with a new GUID
    /// </summary>
    public static SystemLogId CreateUnique()
    {
        return new SystemLogId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SystemLogId id) => id.Value.ToString();
    public static implicit operator Guid(SystemLogId id) => id.Value;
}
}
