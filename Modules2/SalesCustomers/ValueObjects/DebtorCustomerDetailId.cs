using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// DebtorCustomerDetail Identifier Value Object
/// </summary>
public sealed class DebtorCustomerDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DebtorCustomerDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DebtorCustomerDetailId instance
    /// </summary>
    public DebtorCustomerDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DebtorCustomerDetailId with a new GUID
    /// </summary>
    public static DebtorCustomerDetailId CreateUnique()
    {
        return new DebtorCustomerDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DebtorCustomerDetailId id) => id.Value.ToString();
    public static implicit operator Guid(DebtorCustomerDetailId id) => id.Value;
}
}
