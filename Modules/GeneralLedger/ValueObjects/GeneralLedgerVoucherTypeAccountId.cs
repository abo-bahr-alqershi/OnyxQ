using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerVoucherTypeAccount Identifier Value Object
/// </summary>
public sealed class GeneralLedgerVoucherTypeAccountId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerVoucherTypeAccount
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerVoucherTypeAccountId instance
    /// </summary>
    public GeneralLedgerVoucherTypeAccountId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerVoucherTypeAccountId with a new GUID
    /// </summary>
    public static GeneralLedgerVoucherTypeAccountId CreateUnique()
    {
        return new GeneralLedgerVoucherTypeAccountId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerVoucherTypeAccountId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerVoucherTypeAccountId id) => id.Value;
}
}
