using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CashCustomerGroup Identifier Value Object
/// </summary>
public sealed class CashCustomerGroupId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CashCustomerGroup
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CashCustomerGroupId instance
    /// </summary>
    public CashCustomerGroupId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CashCustomerGroupId with a new GUID
    /// </summary>
    public static CashCustomerGroupId CreateUnique()
    {
        return new CashCustomerGroupId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CashCustomerGroupId id) => id.Value.ToString();
    public static implicit operator Guid(CashCustomerGroupId id) => id.Value;
}
}
