using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerBankIdentificationMaster Identifier Value Object
/// </summary>
public sealed class GeneralLedgerBankIdentificationMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerBankIdentificationMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerBankIdentificationMasterId instance
    /// </summary>
    public GeneralLedgerBankIdentificationMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerBankIdentificationMasterId with a new GUID
    /// </summary>
    public static GeneralLedgerBankIdentificationMasterId CreateUnique()
    {
        return new GeneralLedgerBankIdentificationMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerBankIdentificationMasterId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerBankIdentificationMasterId id) => id.Value;
}
}
