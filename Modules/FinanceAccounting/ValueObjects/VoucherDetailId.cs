using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// VoucherDetail Identifier Value Object
/// </summary>
public sealed class VoucherDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the VoucherDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new VoucherDetailId instance
    /// </summary>
    public VoucherDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new VoucherDetailId with a new GUID
    /// </summary>
    public static VoucherDetailId CreateUnique()
    {
        return new VoucherDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(VoucherDetailId id) => id.Value.ToString();
    public static implicit operator Guid(VoucherDetailId id) => id.Value;
}
}
