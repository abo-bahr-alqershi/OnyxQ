using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// PerformaInvoiceBillDetail Identifier Value Object
/// </summary>
public sealed class PerformaInvoiceBillDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PerformaInvoiceBillDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PerformaInvoiceBillDetailId instance
    /// </summary>
    public PerformaInvoiceBillDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PerformaInvoiceBillDetailId with a new GUID
    /// </summary>
    public static PerformaInvoiceBillDetailId CreateUnique()
    {
        return new PerformaInvoiceBillDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PerformaInvoiceBillDetailId id) => id.Value.ToString();
    public static implicit operator Guid(PerformaInvoiceBillDetailId id) => id.Value;
}
}
