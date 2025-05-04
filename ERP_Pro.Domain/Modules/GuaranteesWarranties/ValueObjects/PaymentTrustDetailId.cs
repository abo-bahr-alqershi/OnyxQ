using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.ValueObjects
{
/// <summary>
/// PaymentTrustDetail Identifier Value Object
/// </summary>
public sealed class PaymentTrustDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PaymentTrustDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PaymentTrustDetailId instance
    /// </summary>
    public PaymentTrustDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PaymentTrustDetailId with a new GUID
    /// </summary>
    public static PaymentTrustDetailId CreateUnique()
    {
        return new PaymentTrustDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PaymentTrustDetailId id) => id.Value.ToString();
    public static implicit operator Guid(PaymentTrustDetailId id) => id.Value;
}
}
