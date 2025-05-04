using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// AdjustInstallmentMaster Identifier Value Object
/// </summary>
public sealed class AdjustInstallmentMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AdjustInstallmentMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AdjustInstallmentMasterId instance
    /// </summary>
    public AdjustInstallmentMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AdjustInstallmentMasterId with a new GUID
    /// </summary>
    public static AdjustInstallmentMasterId CreateUnique()
    {
        return new AdjustInstallmentMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AdjustInstallmentMasterId id) => id.Value.ToString();
    public static implicit operator Guid(AdjustInstallmentMasterId id) => id.Value;
}
}
