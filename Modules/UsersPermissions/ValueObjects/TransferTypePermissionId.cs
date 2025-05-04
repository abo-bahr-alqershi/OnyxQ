using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// TransferTypePermission Identifier Value Object
/// </summary>
public sealed class TransferTypePermissionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TransferTypePermission
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TransferTypePermissionId instance
    /// </summary>
    public TransferTypePermissionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TransferTypePermissionId with a new GUID
    /// </summary>
    public static TransferTypePermissionId CreateUnique()
    {
        return new TransferTypePermissionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TransferTypePermissionId id) => id.Value.ToString();
    public static implicit operator Guid(TransferTypePermissionId id) => id.Value;
}
}
