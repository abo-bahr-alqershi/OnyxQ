using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// SystemType Identifier Value Object
/// </summary>
public sealed class SystemTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SystemType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SystemTypeId instance
    /// </summary>
    public SystemTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SystemTypeId with a new GUID
    /// </summary>
    public static SystemTypeId CreateUnique()
    {
        return new SystemTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SystemTypeId id) => id.Value.ToString();
    public static implicit operator Guid(SystemTypeId id) => id.Value;
}
}
