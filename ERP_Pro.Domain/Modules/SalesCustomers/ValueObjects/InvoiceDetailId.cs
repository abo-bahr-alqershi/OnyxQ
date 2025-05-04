using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// InvoiceDetail Identifier Value Object
/// </summary>
public sealed class InvoiceDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InvoiceDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InvoiceDetailId instance
    /// </summary>
    public InvoiceDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InvoiceDetailId with a new GUID
    /// </summary>
    public static InvoiceDetailId CreateUnique()
    {
        return new InvoiceDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InvoiceDetailId id) => id.Value.ToString();
    public static implicit operator Guid(InvoiceDetailId id) => id.Value;
}
}
