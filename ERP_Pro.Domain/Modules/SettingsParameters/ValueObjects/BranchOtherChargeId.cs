using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SettingsParameters.ValueObjects
{
/// <summary>
/// BranchOtherCharge Identifier Value Object
/// </summary>
public sealed class BranchOtherChargeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchOtherCharge
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchOtherChargeId instance
    /// </summary>
    public BranchOtherChargeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchOtherChargeId with a new GUID
    /// </summary>
    public static BranchOtherChargeId CreateUnique()
    {
        return new BranchOtherChargeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchOtherChargeId id) => id.Value.ToString();
    public static implicit operator Guid(BranchOtherChargeId id) => id.Value;
}
}
