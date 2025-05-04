using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// BillExpireMaster Identifier Value Object
/// </summary>
public sealed class BillExpireMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BillExpireMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BillExpireMasterId instance
    /// </summary>
    public BillExpireMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BillExpireMasterId with a new GUID
    /// </summary>
    public static BillExpireMasterId CreateUnique()
    {
        return new BillExpireMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BillExpireMasterId id) => id.Value.ToString();
    public static implicit operator Guid(BillExpireMasterId id) => id.Value;
}
}
