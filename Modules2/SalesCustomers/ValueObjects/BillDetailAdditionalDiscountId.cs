using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// BillDetailAdditionalDiscount Identifier Value Object
/// </summary>
public sealed class BillDetailAdditionalDiscountId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BillDetailAdditionalDiscount
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BillDetailAdditionalDiscountId instance
    /// </summary>
    public BillDetailAdditionalDiscountId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BillDetailAdditionalDiscountId with a new GUID
    /// </summary>
    public static BillDetailAdditionalDiscountId CreateUnique()
    {
        return new BillDetailAdditionalDiscountId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BillDetailAdditionalDiscountId id) => id.Value.ToString();
    public static implicit operator Guid(BillDetailAdditionalDiscountId id) => id.Value;
}
}
