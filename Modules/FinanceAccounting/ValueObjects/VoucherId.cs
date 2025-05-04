using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// Voucher Identifier Value Object
/// </summary>
public sealed class VoucherId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Voucher
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new VoucherId instance
    /// </summary>
    public VoucherId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new VoucherId with a new GUID
    /// </summary>
    public static VoucherId CreateUnique()
    {
        return new VoucherId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(VoucherId id) => id.Value.ToString();
    public static implicit operator Guid(VoucherId id) => id.Value;
}
}
