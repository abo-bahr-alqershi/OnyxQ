using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// DebtorCustomerMaster Identifier Value Object
/// </summary>
public sealed class DebtorCustomerMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DebtorCustomerMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DebtorCustomerMasterId instance
    /// </summary>
    public DebtorCustomerMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DebtorCustomerMasterId with a new GUID
    /// </summary>
    public static DebtorCustomerMasterId CreateUnique()
    {
        return new DebtorCustomerMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DebtorCustomerMasterId id) => id.Value.ToString();
    public static implicit operator Guid(DebtorCustomerMasterId id) => id.Value;
}
}
