using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// ShowDocumentPrivilege Identifier Value Object
/// </summary>
public sealed class ShowDocumentPrivilegeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ShowDocumentPrivilege
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ShowDocumentPrivilegeId instance
    /// </summary>
    public ShowDocumentPrivilegeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ShowDocumentPrivilegeId with a new GUID
    /// </summary>
    public static ShowDocumentPrivilegeId CreateUnique()
    {
        return new ShowDocumentPrivilegeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ShowDocumentPrivilegeId id) => id.Value.ToString();
    public static implicit operator Guid(ShowDocumentPrivilegeId id) => id.Value;
}
}
