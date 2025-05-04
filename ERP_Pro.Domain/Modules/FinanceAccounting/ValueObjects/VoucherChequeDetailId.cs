using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// VoucherChequeDetail Identifier Value Object
/// </summary>
public sealed class VoucherChequeDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the VoucherChequeDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new VoucherChequeDetailId instance
    /// </summary>
    public VoucherChequeDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new VoucherChequeDetailId with a new GUID
    /// </summary>
    public static VoucherChequeDetailId CreateUnique()
    {
        return new VoucherChequeDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(VoucherChequeDetailId id) => id.Value.ToString();
    public static implicit operator Guid(VoucherChequeDetailId id) => id.Value;
}
}
