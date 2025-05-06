using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerVoucherMasterAccount Identifier Value Object
/// </summary>
public sealed class GeneralLedgerVoucherMasterAccountId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerVoucherMasterAccount
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerVoucherMasterAccountId instance
    /// </summary>
    public GeneralLedgerVoucherMasterAccountId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerVoucherMasterAccountId with a new GUID
    /// </summary>
    public static GeneralLedgerVoucherMasterAccountId CreateUnique()
    {
        return new GeneralLedgerVoucherMasterAccountId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerVoucherMasterAccountId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerVoucherMasterAccountId id) => id.Value;
}
}
