using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// SystemFlag Identifier Value Object
/// </summary>
public sealed class SystemFlagId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SystemFlag
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SystemFlagId instance
    /// </summary>
    public SystemFlagId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SystemFlagId with a new GUID
    /// </summary>
    public static SystemFlagId CreateUnique()
    {
        return new SystemFlagId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SystemFlagId id) => id.Value.ToString();
    public static implicit operator Guid(SystemFlagId id) => id.Value;
}
}
