using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerAccountCodeDetailGroups Identifier Value Object
/// </summary>
public sealed class GeneralLedgerAccountCodeDetailGroupsId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerAccountCodeDetailGroups
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerAccountCodeDetailGroupsId instance
    /// </summary>
    public GeneralLedgerAccountCodeDetailGroupsId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerAccountCodeDetailGroupsId with a new GUID
    /// </summary>
    public static GeneralLedgerAccountCodeDetailGroupsId CreateUnique()
    {
        return new GeneralLedgerAccountCodeDetailGroupsId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerAccountCodeDetailGroupsId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerAccountCodeDetailGroupsId id) => id.Value;
}
}
