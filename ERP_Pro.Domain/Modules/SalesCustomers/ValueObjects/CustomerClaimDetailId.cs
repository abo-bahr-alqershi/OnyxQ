using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerClaimDetail Identifier Value Object
/// </summary>
public sealed class CustomerClaimDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerClaimDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerClaimDetailId instance
    /// </summary>
    public CustomerClaimDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerClaimDetailId with a new GUID
    /// </summary>
    public static CustomerClaimDetailId CreateUnique()
    {
        return new CustomerClaimDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerClaimDetailId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerClaimDetailId id) => id.Value;
}
}
