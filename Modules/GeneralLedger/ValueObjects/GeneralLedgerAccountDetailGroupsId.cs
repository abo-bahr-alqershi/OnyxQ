using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerAccountDetailGroups Identifier Value Object
/// </summary>
public sealed class GeneralLedgerAccountDetailGroupsId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerAccountDetailGroups
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerAccountDetailGroupsId instance
    /// </summary>
    public GeneralLedgerAccountDetailGroupsId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerAccountDetailGroupsId with a new GUID
    /// </summary>
    public static GeneralLedgerAccountDetailGroupsId CreateUnique()
    {
        return new GeneralLedgerAccountDetailGroupsId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerAccountDetailGroupsId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerAccountDetailGroupsId id) => id.Value;
}
}
