using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects
{
/// <summary>
/// PaymentDetail Identifier Value Object
/// </summary>
public sealed class PaymentDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PaymentDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PaymentDetailId instance
    /// </summary>
    public PaymentDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PaymentDetailId with a new GUID
    /// </summary>
    public static PaymentDetailId CreateUnique()
    {
        return new PaymentDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PaymentDetailId id) => id.Value.ToString();
    public static implicit operator Guid(PaymentDetailId id) => id.Value;
}
}
