using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// VoucherType Identifier Value Object
/// </summary>
public sealed class VoucherTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the VoucherType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new VoucherTypeId instance
    /// </summary>
    public VoucherTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new VoucherTypeId with a new GUID
    /// </summary>
    public static VoucherTypeId CreateUnique()
    {
        return new VoucherTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(VoucherTypeId id) => id.Value.ToString();
    public static implicit operator Guid(VoucherTypeId id) => id.Value;
}
}
