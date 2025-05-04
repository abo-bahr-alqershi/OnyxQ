using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerRequestTypes Identifier Value Object
/// </summary>
public sealed class GeneralLedgerRequestTypesId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerRequestTypes
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerRequestTypesId instance
    /// </summary>
    public GeneralLedgerRequestTypesId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerRequestTypesId with a new GUID
    /// </summary>
    public static GeneralLedgerRequestTypesId CreateUnique()
    {
        return new GeneralLedgerRequestTypesId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerRequestTypesId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerRequestTypesId id) => id.Value;
}
}
