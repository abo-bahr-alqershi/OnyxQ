using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerVoucherTypePrivilege Identifier Value Object
/// </summary>
public sealed class GeneralLedgerVoucherTypePrivilegeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerVoucherTypePrivilege
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerVoucherTypePrivilegeId instance
    /// </summary>
    public GeneralLedgerVoucherTypePrivilegeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerVoucherTypePrivilegeId with a new GUID
    /// </summary>
    public static GeneralLedgerVoucherTypePrivilegeId CreateUnique()
    {
        return new GeneralLedgerVoucherTypePrivilegeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerVoucherTypePrivilegeId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerVoucherTypePrivilegeId id) => id.Value;
}
}
