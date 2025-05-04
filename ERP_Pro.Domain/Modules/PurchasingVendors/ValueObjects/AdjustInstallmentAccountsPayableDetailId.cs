using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// AdjustInstallmentAccountsPayableDetail Identifier Value Object
/// </summary>
public sealed class AdjustInstallmentAccountsPayableDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AdjustInstallmentAccountsPayableDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AdjustInstallmentAccountsPayableDetailId instance
    /// </summary>
    public AdjustInstallmentAccountsPayableDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AdjustInstallmentAccountsPayableDetailId with a new GUID
    /// </summary>
    public static AdjustInstallmentAccountsPayableDetailId CreateUnique()
    {
        return new AdjustInstallmentAccountsPayableDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AdjustInstallmentAccountsPayableDetailId id) => id.Value.ToString();
    public static implicit operator Guid(AdjustInstallmentAccountsPayableDetailId id) => id.Value;
}
}
