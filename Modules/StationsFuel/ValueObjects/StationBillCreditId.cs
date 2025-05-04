using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.StationsFuel.ValueObjects
{
/// <summary>
/// StationBillCredit Identifier Value Object
/// </summary>
public sealed class StationBillCreditId : ValueObject
{
    /// <summary>
    /// The unique identifier for the StationBillCredit
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new StationBillCreditId instance
    /// </summary>
    public StationBillCreditId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new StationBillCreditId with a new GUID
    /// </summary>
    public static StationBillCreditId CreateUnique()
    {
        return new StationBillCreditId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(StationBillCreditId id) => id.Value.ToString();
    public static implicit operator Guid(StationBillCreditId id) => id.Value;
}
}
