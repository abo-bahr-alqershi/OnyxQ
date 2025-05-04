using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerAccountDetail Identifier Value Object
/// </summary>
public sealed class GeneralLedgerAccountDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerAccountDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerAccountDetailId instance
    /// </summary>
    public GeneralLedgerAccountDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerAccountDetailId with a new GUID
    /// </summary>
    public static GeneralLedgerAccountDetailId CreateUnique()
    {
        return new GeneralLedgerAccountDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerAccountDetailId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerAccountDetailId id) => id.Value;
}
}
