using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// OutgoingBillMaster Identifier Value Object
/// </summary>
public sealed class OutgoingBillMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the OutgoingBillMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new OutgoingBillMasterId instance
    /// </summary>
    public OutgoingBillMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new OutgoingBillMasterId with a new GUID
    /// </summary>
    public static OutgoingBillMasterId CreateUnique()
    {
        return new OutgoingBillMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(OutgoingBillMasterId id) => id.Value.ToString();
    public static implicit operator Guid(OutgoingBillMasterId id) => id.Value;
}
}
