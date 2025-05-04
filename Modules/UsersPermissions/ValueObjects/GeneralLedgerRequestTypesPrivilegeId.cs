using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// GeneralLedgerRequestTypesPrivilege Identifier Value Object
/// </summary>
public sealed class GeneralLedgerRequestTypesPrivilegeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerRequestTypesPrivilege
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerRequestTypesPrivilegeId instance
    /// </summary>
    public GeneralLedgerRequestTypesPrivilegeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerRequestTypesPrivilegeId with a new GUID
    /// </summary>
    public static GeneralLedgerRequestTypesPrivilegeId CreateUnique()
    {
        return new GeneralLedgerRequestTypesPrivilegeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerRequestTypesPrivilegeId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerRequestTypesPrivilegeId id) => id.Value;
}
}
