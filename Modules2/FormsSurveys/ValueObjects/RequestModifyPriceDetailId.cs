using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects
{
/// <summary>
/// RequestModifyPriceDetail Identifier Value Object
/// </summary>
public sealed class RequestModifyPriceDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the RequestModifyPriceDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new RequestModifyPriceDetailId instance
    /// </summary>
    public RequestModifyPriceDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new RequestModifyPriceDetailId with a new GUID
    /// </summary>
    public static RequestModifyPriceDetailId CreateUnique()
    {
        return new RequestModifyPriceDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(RequestModifyPriceDetailId id) => id.Value.ToString();
    public static implicit operator Guid(RequestModifyPriceDetailId id) => id.Value;
}
}
