using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// Theme Identifier Value Object
/// </summary>
public sealed class ThemeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Theme
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ThemeId instance
    /// </summary>
    public ThemeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ThemeId with a new GUID
    /// </summary>
    public static ThemeId CreateUnique()
    {
        return new ThemeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ThemeId id) => id.Value.ToString();
    public static implicit operator Guid(ThemeId id) => id.Value;
}
}
