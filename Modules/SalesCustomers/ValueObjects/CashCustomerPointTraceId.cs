using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CashCustomerPointTrace Identifier Value Object
/// </summary>
public sealed class CashCustomerPointTraceId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CashCustomerPointTrace
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CashCustomerPointTraceId instance
    /// </summary>
    public CashCustomerPointTraceId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CashCustomerPointTraceId with a new GUID
    /// </summary>
    public static CashCustomerPointTraceId CreateUnique()
    {
        return new CashCustomerPointTraceId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CashCustomerPointTraceId id) => id.Value.ToString();
    public static implicit operator Guid(CashCustomerPointTraceId id) => id.Value;
}
}
