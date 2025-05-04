using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerCashflowMaster Identifier Value Object
/// </summary>
public sealed class GeneralLedgerCashflowMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerCashflowMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerCashflowMasterId instance
    /// </summary>
    public GeneralLedgerCashflowMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerCashflowMasterId with a new GUID
    /// </summary>
    public static GeneralLedgerCashflowMasterId CreateUnique()
    {
        return new GeneralLedgerCashflowMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerCashflowMasterId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerCashflowMasterId id) => id.Value;
}
}
