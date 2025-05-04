using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerClaimVisit Identifier Value Object
/// </summary>
public sealed class CustomerClaimVisitId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerClaimVisit
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerClaimVisitId instance
    /// </summary>
    public CustomerClaimVisitId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerClaimVisitId with a new GUID
    /// </summary>
    public static CustomerClaimVisitId CreateUnique()
    {
        return new CustomerClaimVisitId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerClaimVisitId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerClaimVisitId id) => id.Value;
}
}
