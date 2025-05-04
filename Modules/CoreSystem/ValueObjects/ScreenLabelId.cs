using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// ScreenLabel Identifier Value Object
/// </summary>
public sealed class ScreenLabelId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ScreenLabel
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ScreenLabelId instance
    /// </summary>
    public ScreenLabelId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ScreenLabelId with a new GUID
    /// </summary>
    public static ScreenLabelId CreateUnique()
    {
        return new ScreenLabelId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ScreenLabelId id) => id.Value.ToString();
    public static implicit operator Guid(ScreenLabelId id) => id.Value;
}
}
