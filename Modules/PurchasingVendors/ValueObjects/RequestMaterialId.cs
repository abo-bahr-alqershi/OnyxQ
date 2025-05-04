using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// RequestMaterial Identifier Value Object
/// </summary>
public sealed class RequestMaterialId : ValueObject
{
    /// <summary>
    /// The unique identifier for the RequestMaterial
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new RequestMaterialId instance
    /// </summary>
    public RequestMaterialId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new RequestMaterialId with a new GUID
    /// </summary>
    public static RequestMaterialId CreateUnique()
    {
        return new RequestMaterialId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(RequestMaterialId id) => id.Value.ToString();
    public static implicit operator Guid(RequestMaterialId id) => id.Value;
}
}
