using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// PerformaInvoiceBillMaster Identifier Value Object
/// </summary>
public sealed class PerformaInvoiceBillMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PerformaInvoiceBillMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PerformaInvoiceBillMasterId instance
    /// </summary>
    public PerformaInvoiceBillMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PerformaInvoiceBillMasterId with a new GUID
    /// </summary>
    public static PerformaInvoiceBillMasterId CreateUnique()
    {
        return new PerformaInvoiceBillMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PerformaInvoiceBillMasterId id) => id.Value.ToString();
    public static implicit operator Guid(PerformaInvoiceBillMasterId id) => id.Value;
}
}
