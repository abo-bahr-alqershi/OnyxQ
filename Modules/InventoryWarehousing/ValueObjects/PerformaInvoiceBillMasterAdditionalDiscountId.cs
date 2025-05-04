using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// PerformaInvoiceBillMasterAdditionalDiscount Identifier Value Object
/// </summary>
public sealed class PerformaInvoiceBillMasterAdditionalDiscountId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PerformaInvoiceBillMasterAdditionalDiscountId instance
    /// </summary>
    public PerformaInvoiceBillMasterAdditionalDiscountId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PerformaInvoiceBillMasterAdditionalDiscountId with a new GUID
    /// </summary>
    public static PerformaInvoiceBillMasterAdditionalDiscountId CreateUnique()
    {
        return new PerformaInvoiceBillMasterAdditionalDiscountId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PerformaInvoiceBillMasterAdditionalDiscountId id) => id.Value.ToString();
    public static implicit operator Guid(PerformaInvoiceBillMasterAdditionalDiscountId id) => id.Value;
}
}
