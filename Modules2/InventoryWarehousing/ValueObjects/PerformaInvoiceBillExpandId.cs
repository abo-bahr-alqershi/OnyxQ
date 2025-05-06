using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// PerformaInvoiceBillExpand Identifier Value Object
/// </summary>
public sealed class PerformaInvoiceBillExpandId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PerformaInvoiceBillExpand
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PerformaInvoiceBillExpandId instance
    /// </summary>
    public PerformaInvoiceBillExpandId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PerformaInvoiceBillExpandId with a new GUID
    /// </summary>
    public static PerformaInvoiceBillExpandId CreateUnique()
    {
        return new PerformaInvoiceBillExpandId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PerformaInvoiceBillExpandId id) => id.Value.ToString();
    public static implicit operator Guid(PerformaInvoiceBillExpandId id) => id.Value;
}
}
