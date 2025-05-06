using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerBankChequeMaster Identifier Value Object
/// </summary>
public sealed class GeneralLedgerBankChequeMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerBankChequeMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerBankChequeMasterId instance
    /// </summary>
    public GeneralLedgerBankChequeMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerBankChequeMasterId with a new GUID
    /// </summary>
    public static GeneralLedgerBankChequeMasterId CreateUnique()
    {
        return new GeneralLedgerBankChequeMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerBankChequeMasterId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerBankChequeMasterId id) => id.Value;
}
}
