using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects
{
/// <summary>
/// RequestCompensationQuantityCalculationMaster Identifier Value Object
/// </summary>
public sealed class RequestCompensationQuantityCalculationMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the RequestCompensationQuantityCalculationMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new RequestCompensationQuantityCalculationMasterId instance
    /// </summary>
    public RequestCompensationQuantityCalculationMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new RequestCompensationQuantityCalculationMasterId with a new GUID
    /// </summary>
    public static RequestCompensationQuantityCalculationMasterId CreateUnique()
    {
        return new RequestCompensationQuantityCalculationMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(RequestCompensationQuantityCalculationMasterId id) => id.Value.ToString();
    public static implicit operator Guid(RequestCompensationQuantityCalculationMasterId id) => id.Value;
}
}
