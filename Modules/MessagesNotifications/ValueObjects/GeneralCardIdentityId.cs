using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects
{
/// <summary>
/// GeneralCardIdentity Identifier Value Object
/// </summary>
public sealed class GeneralCardIdentityId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralCardIdentity
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralCardIdentityId instance
    /// </summary>
    public GeneralCardIdentityId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralCardIdentityId with a new GUID
    /// </summary>
    public static GeneralCardIdentityId CreateUnique()
    {
        return new GeneralCardIdentityId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralCardIdentityId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralCardIdentityId id) => id.Value;
}
}
