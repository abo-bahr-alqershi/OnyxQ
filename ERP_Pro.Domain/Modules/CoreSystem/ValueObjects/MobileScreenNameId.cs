using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// MobileScreenName Identifier Value Object
/// </summary>
public sealed class MobileScreenNameId : ValueObject
{
    /// <summary>
    /// The unique identifier for the MobileScreenName
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new MobileScreenNameId instance
    /// </summary>
    public MobileScreenNameId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new MobileScreenNameId with a new GUID
    /// </summary>
    public static MobileScreenNameId CreateUnique()
    {
        return new MobileScreenNameId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(MobileScreenNameId id) => id.Value.ToString();
    public static implicit operator Guid(MobileScreenNameId id) => id.Value;
}
}
