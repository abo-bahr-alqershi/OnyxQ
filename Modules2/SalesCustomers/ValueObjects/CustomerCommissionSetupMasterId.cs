using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerCommissionSetupMaster Identifier Value Object
/// </summary>
public sealed class CustomerCommissionSetupMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerCommissionSetupMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerCommissionSetupMasterId instance
    /// </summary>
    public CustomerCommissionSetupMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerCommissionSetupMasterId with a new GUID
    /// </summary>
    public static CustomerCommissionSetupMasterId CreateUnique()
    {
        return new CustomerCommissionSetupMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerCommissionSetupMasterId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerCommissionSetupMasterId id) => id.Value;
}
}
