using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TaxFees.ValueObjects
{
/// <summary>
/// RequestTaxItemMovement Identifier Value Object
/// </summary>
public sealed class RequestTaxItemMovementId : ValueObject
{
    /// <summary>
    /// The unique identifier for the RequestTaxItemMovement
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new RequestTaxItemMovementId instance
    /// </summary>
    public RequestTaxItemMovementId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new RequestTaxItemMovementId with a new GUID
    /// </summary>
    public static RequestTaxItemMovementId CreateUnique()
    {
        return new RequestTaxItemMovementId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(RequestTaxItemMovementId id) => id.Value.ToString();
    public static implicit operator Guid(RequestTaxItemMovementId id) => id.Value;
}
}
