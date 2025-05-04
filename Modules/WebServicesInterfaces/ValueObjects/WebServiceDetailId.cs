using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.WebServicesInterfaces.ValueObjects
{
/// <summary>
/// WebServiceDetail Identifier Value Object
/// </summary>
public sealed class WebServiceDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the WebServiceDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new WebServiceDetailId instance
    /// </summary>
    public WebServiceDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new WebServiceDetailId with a new GUID
    /// </summary>
    public static WebServiceDetailId CreateUnique()
    {
        return new WebServiceDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(WebServiceDetailId id) => id.Value.ToString();
    public static implicit operator Guid(WebServiceDetailId id) => id.Value;
}
}
