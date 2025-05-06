using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.ValueObjects
{
/// <summary>
/// ContactManager Identifier Value Object
/// </summary>
public sealed class ContactManagerId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ContactManager
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ContactManagerId instance
    /// </summary>
    public ContactManagerId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ContactManagerId with a new GUID
    /// </summary>
    public static ContactManagerId CreateUnique()
    {
        return new ContactManagerId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ContactManagerId id) => id.Value.ToString();
    public static implicit operator Guid(ContactManagerId id) => id.Value;
}
}
