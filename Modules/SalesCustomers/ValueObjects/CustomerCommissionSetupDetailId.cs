using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerCommissionSetupDetail Identifier Value Object
/// </summary>
public sealed class CustomerCommissionSetupDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerCommissionSetupDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerCommissionSetupDetailId instance
    /// </summary>
    public CustomerCommissionSetupDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerCommissionSetupDetailId with a new GUID
    /// </summary>
    public static CustomerCommissionSetupDetailId CreateUnique()
    {
        return new CustomerCommissionSetupDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerCommissionSetupDetailId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerCommissionSetupDetailId id) => id.Value;
}
}
