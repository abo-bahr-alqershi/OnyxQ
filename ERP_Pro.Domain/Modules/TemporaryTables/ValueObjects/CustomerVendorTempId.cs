using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// CustomerVendorTemp Identifier Value Object
/// </summary>
public sealed class CustomerVendorTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerVendorTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerVendorTempId instance
    /// </summary>
    public CustomerVendorTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerVendorTempId with a new GUID
    /// </summary>
    public static CustomerVendorTempId CreateUnique()
    {
        return new CustomerVendorTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerVendorTempId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerVendorTempId id) => id.Value;
}
}
