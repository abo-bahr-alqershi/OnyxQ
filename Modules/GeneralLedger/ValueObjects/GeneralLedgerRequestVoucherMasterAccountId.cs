using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerRequestVoucherMasterAccount Identifier Value Object
/// </summary>
public sealed class GeneralLedgerRequestVoucherMasterAccountId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerRequestVoucherMasterAccountId instance
    /// </summary>
    public GeneralLedgerRequestVoucherMasterAccountId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerRequestVoucherMasterAccountId with a new GUID
    /// </summary>
    public static GeneralLedgerRequestVoucherMasterAccountId CreateUnique()
    {
        return new GeneralLedgerRequestVoucherMasterAccountId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerRequestVoucherMasterAccountId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerRequestVoucherMasterAccountId id) => id.Value;
}
}
