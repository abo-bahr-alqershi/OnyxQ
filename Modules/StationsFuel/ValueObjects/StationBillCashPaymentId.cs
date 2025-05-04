using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.StationsFuel.ValueObjects
{
/// <summary>
/// StationBillCashPayment Identifier Value Object
/// </summary>
public sealed class StationBillCashPaymentId : ValueObject
{
    /// <summary>
    /// The unique identifier for the StationBillCashPayment
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new StationBillCashPaymentId instance
    /// </summary>
    public StationBillCashPaymentId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new StationBillCashPaymentId with a new GUID
    /// </summary>
    public static StationBillCashPaymentId CreateUnique()
    {
        return new StationBillCashPaymentId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(StationBillCashPaymentId id) => id.Value.ToString();
    public static implicit operator Guid(StationBillCashPaymentId id) => id.Value;
}
}
