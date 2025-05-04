using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects
{
/// <summary>
/// RequestModifyPriceMaster Identifier Value Object
/// </summary>
public sealed class RequestModifyPriceMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the RequestModifyPriceMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new RequestModifyPriceMasterId instance
    /// </summary>
    public RequestModifyPriceMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new RequestModifyPriceMasterId with a new GUID
    /// </summary>
    public static RequestModifyPriceMasterId CreateUnique()
    {
        return new RequestModifyPriceMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(RequestModifyPriceMasterId id) => id.Value.ToString();
    public static implicit operator Guid(RequestModifyPriceMasterId id) => id.Value;
}
}
