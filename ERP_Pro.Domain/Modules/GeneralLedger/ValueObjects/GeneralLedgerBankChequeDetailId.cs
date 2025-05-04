using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerBankChequeDetail Identifier Value Object
/// </summary>
public sealed class GeneralLedgerBankChequeDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerBankChequeDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerBankChequeDetailId instance
    /// </summary>
    public GeneralLedgerBankChequeDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerBankChequeDetailId with a new GUID
    /// </summary>
    public static GeneralLedgerBankChequeDetailId CreateUnique()
    {
        return new GeneralLedgerBankChequeDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerBankChequeDetailId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerBankChequeDetailId id) => id.Value;
}
}
