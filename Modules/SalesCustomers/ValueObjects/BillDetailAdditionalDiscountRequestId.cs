using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// BillDetailAdditionalDiscountRequest Identifier Value Object
/// </summary>
public sealed class BillDetailAdditionalDiscountRequestId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BillDetailAdditionalDiscountRequest
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BillDetailAdditionalDiscountRequestId instance
    /// </summary>
    public BillDetailAdditionalDiscountRequestId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BillDetailAdditionalDiscountRequestId with a new GUID
    /// </summary>
    public static BillDetailAdditionalDiscountRequestId CreateUnique()
    {
        return new BillDetailAdditionalDiscountRequestId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BillDetailAdditionalDiscountRequestId id) => id.Value.ToString();
    public static implicit operator Guid(BillDetailAdditionalDiscountRequestId id) => id.Value;
}
}
