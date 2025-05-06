using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.StationsFuel.ValueObjects
{
/// <summary>
/// StationCreditBillDetail Identifier Value Object
/// </summary>
public sealed class StationCreditBillDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the StationCreditBillDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new StationCreditBillDetailId instance
    /// </summary>
    public StationCreditBillDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new StationCreditBillDetailId with a new GUID
    /// </summary>
    public static StationCreditBillDetailId CreateUnique()
    {
        return new StationCreditBillDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(StationCreditBillDetailId id) => id.Value.ToString();
    public static implicit operator Guid(StationCreditBillDetailId id) => id.Value;
}
}
