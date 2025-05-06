using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// ScreenLink Identifier Value Object
/// </summary>
public sealed class ScreenLinkId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ScreenLink
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ScreenLinkId instance
    /// </summary>
    public ScreenLinkId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ScreenLinkId with a new GUID
    /// </summary>
    public static ScreenLinkId CreateUnique()
    {
        return new ScreenLinkId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ScreenLinkId id) => id.Value.ToString();
    public static implicit operator Guid(ScreenLinkId id) => id.Value;
}
}
