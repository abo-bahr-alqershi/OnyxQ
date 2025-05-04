using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// UserNote Identifier Value Object
/// </summary>
public sealed class UserNoteId : ValueObject
{
    /// <summary>
    /// The unique identifier for the UserNote
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new UserNoteId instance
    /// </summary>
    public UserNoteId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new UserNoteId with a new GUID
    /// </summary>
    public static UserNoteId CreateUnique()
    {
        return new UserNoteId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(UserNoteId id) => id.Value.ToString();
    public static implicit operator Guid(UserNoteId id) => id.Value;
}
}
