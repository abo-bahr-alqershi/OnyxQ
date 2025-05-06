using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.WebServicesInterfaces.ValueObjects
{
/// <summary>
/// WebServiceMaster Identifier Value Object
/// </summary>
public sealed class WebServiceMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the WebServiceMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new WebServiceMasterId instance
    /// </summary>
    public WebServiceMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new WebServiceMasterId with a new GUID
    /// </summary>
    public static WebServiceMasterId CreateUnique()
    {
        return new WebServiceMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(WebServiceMasterId id) => id.Value.ToString();
    public static implicit operator Guid(WebServiceMasterId id) => id.Value;
}
}
