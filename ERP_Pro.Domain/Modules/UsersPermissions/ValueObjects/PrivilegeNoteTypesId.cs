using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// PrivilegeNoteTypes Identifier Value Object
/// </summary>
public sealed class PrivilegeNoteTypesId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PrivilegeNoteTypes
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PrivilegeNoteTypesId instance
    /// </summary>
    public PrivilegeNoteTypesId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PrivilegeNoteTypesId with a new GUID
    /// </summary>
    public static PrivilegeNoteTypesId CreateUnique()
    {
        return new PrivilegeNoteTypesId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PrivilegeNoteTypesId id) => id.Value.ToString();
    public static implicit operator Guid(PrivilegeNoteTypesId id) => id.Value;
}
}
