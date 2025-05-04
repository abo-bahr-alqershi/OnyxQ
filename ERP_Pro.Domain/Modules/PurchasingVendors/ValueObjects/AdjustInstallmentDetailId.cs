using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// AdjustInstallmentDetail Identifier Value Object
/// </summary>
public sealed class AdjustInstallmentDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AdjustInstallmentDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AdjustInstallmentDetailId instance
    /// </summary>
    public AdjustInstallmentDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AdjustInstallmentDetailId with a new GUID
    /// </summary>
    public static AdjustInstallmentDetailId CreateUnique()
    {
        return new AdjustInstallmentDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AdjustInstallmentDetailId id) => id.Value.ToString();
    public static implicit operator Guid(AdjustInstallmentDetailId id) => id.Value;
}
}
