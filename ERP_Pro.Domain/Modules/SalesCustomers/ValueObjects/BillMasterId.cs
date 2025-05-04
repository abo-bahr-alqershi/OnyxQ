using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// BillMaster Identifier Value Object
/// </summary>
public sealed class BillMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BillMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BillMasterId instance
    /// </summary>
    public BillMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BillMasterId with a new GUID
    /// </summary>
    public static BillMasterId CreateUnique()
    {
        return new BillMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BillMasterId id) => id.Value.ToString();
    public static implicit operator Guid(BillMasterId id) => id.Value;
}
}
