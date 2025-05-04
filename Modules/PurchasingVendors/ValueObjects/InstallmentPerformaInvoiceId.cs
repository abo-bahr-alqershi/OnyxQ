using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// InstallmentPerformaInvoice Identifier Value Object
/// </summary>
public sealed class InstallmentPerformaInvoiceId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InstallmentPerformaInvoice
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InstallmentPerformaInvoiceId instance
    /// </summary>
    public InstallmentPerformaInvoiceId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InstallmentPerformaInvoiceId with a new GUID
    /// </summary>
    public static InstallmentPerformaInvoiceId CreateUnique()
    {
        return new InstallmentPerformaInvoiceId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InstallmentPerformaInvoiceId id) => id.Value.ToString();
    public static implicit operator Guid(InstallmentPerformaInvoiceId id) => id.Value;
}
}
