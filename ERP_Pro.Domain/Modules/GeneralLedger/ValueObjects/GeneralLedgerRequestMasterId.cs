using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerRequestMaster Identifier Value Object
/// </summary>
public sealed class GeneralLedgerRequestMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerRequestMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerRequestMasterId instance
    /// </summary>
    public GeneralLedgerRequestMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerRequestMasterId with a new GUID
    /// </summary>
    public static GeneralLedgerRequestMasterId CreateUnique()
    {
        return new GeneralLedgerRequestMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerRequestMasterId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerRequestMasterId id) => id.Value;
}
}
