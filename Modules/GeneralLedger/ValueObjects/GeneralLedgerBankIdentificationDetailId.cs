using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerBankIdentificationDetail Identifier Value Object
/// </summary>
public sealed class GeneralLedgerBankIdentificationDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerBankIdentificationDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerBankIdentificationDetailId instance
    /// </summary>
    public GeneralLedgerBankIdentificationDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerBankIdentificationDetailId with a new GUID
    /// </summary>
    public static GeneralLedgerBankIdentificationDetailId CreateUnique()
    {
        return new GeneralLedgerBankIdentificationDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerBankIdentificationDetailId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerBankIdentificationDetailId id) => id.Value;
}
}
