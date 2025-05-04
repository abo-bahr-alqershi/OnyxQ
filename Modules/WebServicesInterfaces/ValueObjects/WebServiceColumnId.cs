using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.WebServicesInterfaces.ValueObjects
{
/// <summary>
/// WebServiceColumn Identifier Value Object
/// </summary>
public sealed class WebServiceColumnId : ValueObject
{
    /// <summary>
    /// The unique identifier for the WebServiceColumn
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new WebServiceColumnId instance
    /// </summary>
    public WebServiceColumnId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new WebServiceColumnId with a new GUID
    /// </summary>
    public static WebServiceColumnId CreateUnique()
    {
        return new WebServiceColumnId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(WebServiceColumnId id) => id.Value.ToString();
    public static implicit operator Guid(WebServiceColumnId id) => id.Value;
}
}
