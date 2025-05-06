using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// InvoiceMaster Identifier Value Object
/// </summary>
public sealed class InvoiceMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InvoiceMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InvoiceMasterId instance
    /// </summary>
    public InvoiceMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InvoiceMasterId with a new GUID
    /// </summary>
    public static InvoiceMasterId CreateUnique()
    {
        return new InvoiceMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InvoiceMasterId id) => id.Value.ToString();
    public static implicit operator Guid(InvoiceMasterId id) => id.Value;
}
}
