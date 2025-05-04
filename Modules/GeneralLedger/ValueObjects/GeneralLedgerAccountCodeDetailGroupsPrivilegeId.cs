using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerAccountCodeDetailGroupsPrivilege Identifier Value Object
/// </summary>
public sealed class GeneralLedgerAccountCodeDetailGroupsPrivilegeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerAccountCodeDetailGroupsPrivilege
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerAccountCodeDetailGroupsPrivilegeId instance
    /// </summary>
    public GeneralLedgerAccountCodeDetailGroupsPrivilegeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerAccountCodeDetailGroupsPrivilegeId with a new GUID
    /// </summary>
    public static GeneralLedgerAccountCodeDetailGroupsPrivilegeId CreateUnique()
    {
        return new GeneralLedgerAccountCodeDetailGroupsPrivilegeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerAccountCodeDetailGroupsPrivilegeId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerAccountCodeDetailGroupsPrivilegeId id) => id.Value;
}
}
