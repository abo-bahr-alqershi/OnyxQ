using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// MobileScreen Identifier Value Object
/// </summary>
public sealed class MobileScreenId : ValueObject
{
    /// <summary>
    /// The unique identifier for the MobileScreen
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new MobileScreenId instance
    /// </summary>
    public MobileScreenId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new MobileScreenId with a new GUID
    /// </summary>
    public static MobileScreenId CreateUnique()
    {
        return new MobileScreenId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(MobileScreenId id) => id.Value.ToString();
    public static implicit operator Guid(MobileScreenId id) => id.Value;
}
}
