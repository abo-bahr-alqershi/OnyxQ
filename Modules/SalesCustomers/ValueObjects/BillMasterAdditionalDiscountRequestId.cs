using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// BillMasterAdditionalDiscountRequest Identifier Value Object
/// </summary>
public sealed class BillMasterAdditionalDiscountRequestId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BillMasterAdditionalDiscountRequest
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BillMasterAdditionalDiscountRequestId instance
    /// </summary>
    public BillMasterAdditionalDiscountRequestId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BillMasterAdditionalDiscountRequestId with a new GUID
    /// </summary>
    public static BillMasterAdditionalDiscountRequestId CreateUnique()
    {
        return new BillMasterAdditionalDiscountRequestId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BillMasterAdditionalDiscountRequestId id) => id.Value.ToString();
    public static implicit operator Guid(BillMasterAdditionalDiscountRequestId id) => id.Value;
}
}
