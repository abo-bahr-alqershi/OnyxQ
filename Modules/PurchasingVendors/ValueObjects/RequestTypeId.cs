using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// RequestType Identifier Value Object
/// </summary>
public sealed class RequestTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the RequestType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new RequestTypeId instance
    /// </summary>
    public RequestTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new RequestTypeId with a new GUID
    /// </summary>
    public static RequestTypeId CreateUnique()
    {
        return new RequestTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(RequestTypeId id) => id.Value.ToString();
    public static implicit operator Guid(RequestTypeId id) => id.Value;
}
}
