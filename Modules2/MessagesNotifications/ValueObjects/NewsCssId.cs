using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects
{
/// <summary>
/// NewsCss Identifier Value Object
/// </summary>
public sealed class NewsCssId : ValueObject
{
    /// <summary>
    /// The unique identifier for the NewsCss
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new NewsCssId instance
    /// </summary>
    public NewsCssId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new NewsCssId with a new GUID
    /// </summary>
    public static NewsCssId CreateUnique()
    {
        return new NewsCssId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(NewsCssId id) => id.Value.ToString();
    public static implicit operator Guid(NewsCssId id) => id.Value;
}
}
