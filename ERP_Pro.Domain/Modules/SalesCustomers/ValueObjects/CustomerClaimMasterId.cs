using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerClaimMaster Identifier Value Object
/// </summary>
public sealed class CustomerClaimMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerClaimMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerClaimMasterId instance
    /// </summary>
    public CustomerClaimMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerClaimMasterId with a new GUID
    /// </summary>
    public static CustomerClaimMasterId CreateUnique()
    {
        return new CustomerClaimMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerClaimMasterId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerClaimMasterId id) => id.Value;
}
}
