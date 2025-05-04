using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// IncomeTypePermission Identifier Value Object
/// </summary>
public sealed class IncomeTypePermissionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the IncomeTypePermission
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new IncomeTypePermissionId instance
    /// </summary>
    public IncomeTypePermissionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new IncomeTypePermissionId with a new GUID
    /// </summary>
    public static IncomeTypePermissionId CreateUnique()
    {
        return new IncomeTypePermissionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(IncomeTypePermissionId id) => id.Value.ToString();
    public static implicit operator Guid(IncomeTypePermissionId id) => id.Value;
}
}
