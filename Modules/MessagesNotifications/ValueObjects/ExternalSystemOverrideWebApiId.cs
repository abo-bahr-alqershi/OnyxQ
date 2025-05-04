using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects
{
/// <summary>
/// ExternalSystemOverrideWebApi Identifier Value Object
/// </summary>
public sealed class ExternalSystemOverrideWebApiId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ExternalSystemOverrideWebApi
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ExternalSystemOverrideWebApiId instance
    /// </summary>
    public ExternalSystemOverrideWebApiId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ExternalSystemOverrideWebApiId with a new GUID
    /// </summary>
    public static ExternalSystemOverrideWebApiId CreateUnique()
    {
        return new ExternalSystemOverrideWebApiId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ExternalSystemOverrideWebApiId id) => id.Value.ToString();
    public static implicit operator Guid(ExternalSystemOverrideWebApiId id) => id.Value;
}
}
