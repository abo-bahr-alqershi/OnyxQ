using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects
{
/// <summary>
/// RequestCompensationQuantityCalculationDetail Identifier Value Object
/// </summary>
public sealed class RequestCompensationQuantityCalculationDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the RequestCompensationQuantityCalculationDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new RequestCompensationQuantityCalculationDetailId instance
    /// </summary>
    public RequestCompensationQuantityCalculationDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new RequestCompensationQuantityCalculationDetailId with a new GUID
    /// </summary>
    public static RequestCompensationQuantityCalculationDetailId CreateUnique()
    {
        return new RequestCompensationQuantityCalculationDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(RequestCompensationQuantityCalculationDetailId id) => id.Value.ToString();
    public static implicit operator Guid(RequestCompensationQuantityCalculationDetailId id) => id.Value;
}
}
