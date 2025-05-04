using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// PerformaInvoiceItemExpense Identifier Value Object
/// </summary>
public sealed class PerformaInvoiceItemExpenseId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PerformaInvoiceItemExpense
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PerformaInvoiceItemExpenseId instance
    /// </summary>
    public PerformaInvoiceItemExpenseId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PerformaInvoiceItemExpenseId with a new GUID
    /// </summary>
    public static PerformaInvoiceItemExpenseId CreateUnique()
    {
        return new PerformaInvoiceItemExpenseId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PerformaInvoiceItemExpenseId id) => id.Value.ToString();
    public static implicit operator Guid(PerformaInvoiceItemExpenseId id) => id.Value;
}
}
