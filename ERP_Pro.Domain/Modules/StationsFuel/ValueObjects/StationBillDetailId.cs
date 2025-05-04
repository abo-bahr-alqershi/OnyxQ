using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.StationsFuel.ValueObjects
{
/// <summary>
/// StationBillDetail Identifier Value Object
/// </summary>
public sealed class StationBillDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the StationBillDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new StationBillDetailId instance
    /// </summary>
    public StationBillDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new StationBillDetailId with a new GUID
    /// </summary>
    public static StationBillDetailId CreateUnique()
    {
        return new StationBillDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(StationBillDetailId id) => id.Value.ToString();
    public static implicit operator Guid(StationBillDetailId id) => id.Value;
}
}
