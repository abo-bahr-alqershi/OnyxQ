using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerCashflowTemp Identifier Value Object
/// </summary>
public sealed class GeneralLedgerCashflowTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerCashflowTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerCashflowTempId instance
    /// </summary>
    public GeneralLedgerCashflowTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerCashflowTempId with a new GUID
    /// </summary>
    public static GeneralLedgerCashflowTempId CreateUnique()
    {
        return new GeneralLedgerCashflowTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerCashflowTempId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerCashflowTempId id) => id.Value;
}
}
