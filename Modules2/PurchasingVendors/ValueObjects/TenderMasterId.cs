using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// TenderMaster Identifier Value Object
/// </summary>
public sealed class TenderMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TenderMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TenderMasterId instance
    /// </summary>
    public TenderMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TenderMasterId with a new GUID
    /// </summary>
    public static TenderMasterId CreateUnique()
    {
        return new TenderMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TenderMasterId id) => id.Value.ToString();
    public static implicit operator Guid(TenderMasterId id) => id.Value;
}
}
