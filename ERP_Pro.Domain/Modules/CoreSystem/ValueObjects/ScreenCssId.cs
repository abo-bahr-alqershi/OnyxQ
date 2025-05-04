using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// ScreenCss Identifier Value Object
/// </summary>
public sealed class ScreenCssId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ScreenCss
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ScreenCssId instance
    /// </summary>
    public ScreenCssId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ScreenCssId with a new GUID
    /// </summary>
    public static ScreenCssId CreateUnique()
    {
        return new ScreenCssId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ScreenCssId id) => id.Value.ToString();
    public static implicit operator Guid(ScreenCssId id) => id.Value;
}
}
