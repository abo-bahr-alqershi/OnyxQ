using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// PerformaInvoiceBillDetailAdditionalDiscount Identifier Value Object
/// </summary>
public sealed class PerformaInvoiceBillDetailAdditionalDiscountId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PerformaInvoiceBillDetailAdditionalDiscountId instance
    /// </summary>
    public PerformaInvoiceBillDetailAdditionalDiscountId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PerformaInvoiceBillDetailAdditionalDiscountId with a new GUID
    /// </summary>
    public static PerformaInvoiceBillDetailAdditionalDiscountId CreateUnique()
    {
        return new PerformaInvoiceBillDetailAdditionalDiscountId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PerformaInvoiceBillDetailAdditionalDiscountId id) => id.Value.ToString();
    public static implicit operator Guid(PerformaInvoiceBillDetailAdditionalDiscountId id) => id.Value;
}
}
