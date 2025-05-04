using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerAccountDetailPrivilege Identifier Value Object
/// </summary>
public sealed class GeneralLedgerAccountDetailPrivilegeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerAccountDetailPrivilege
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerAccountDetailPrivilegeId instance
    /// </summary>
    public GeneralLedgerAccountDetailPrivilegeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerAccountDetailPrivilegeId with a new GUID
    /// </summary>
    public static GeneralLedgerAccountDetailPrivilegeId CreateUnique()
    {
        return new GeneralLedgerAccountDetailPrivilegeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerAccountDetailPrivilegeId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerAccountDetailPrivilegeId id) => id.Value;
}
}
