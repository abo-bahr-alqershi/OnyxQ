using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// VoucherDetails Identifier Value Object
/// </summary>
public sealed class VoucherDetailsId : ValueObject
{
    /// <summary>
    /// The unique identifier for the VoucherDetails
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new VoucherDetailsId instance
    /// </summary>
    public VoucherDetailsId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new VoucherDetailsId with a new GUID
    /// </summary>
    public static VoucherDetailsId CreateUnique()
    {
        return new VoucherDetailsId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(VoucherDetailsId id) => id.Value.ToString();
    public static implicit operator Guid(VoucherDetailsId id) => id.Value;
}
}
