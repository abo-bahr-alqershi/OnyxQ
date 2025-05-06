using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// ConnectContact Identifier Value Object
/// </summary>
public sealed class ConnectContactId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ConnectContact
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ConnectContactId instance
    /// </summary>
    public ConnectContactId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ConnectContactId with a new GUID
    /// </summary>
    public static ConnectContactId CreateUnique()
    {
        return new ConnectContactId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ConnectContactId id) => id.Value.ToString();
    public static implicit operator Guid(ConnectContactId id) => id.Value;
}
}
