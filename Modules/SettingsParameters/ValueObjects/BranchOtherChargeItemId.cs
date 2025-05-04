using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SettingsParameters.ValueObjects
{
/// <summary>
/// BranchOtherChargeItem Identifier Value Object
/// </summary>
public sealed class BranchOtherChargeItemId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchOtherChargeItem
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchOtherChargeItemId instance
    /// </summary>
    public BranchOtherChargeItemId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchOtherChargeItemId with a new GUID
    /// </summary>
    public static BranchOtherChargeItemId CreateUnique()
    {
        return new BranchOtherChargeItemId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchOtherChargeItemId id) => id.Value.ToString();
    public static implicit operator Guid(BranchOtherChargeItemId id) => id.Value;
}
}
