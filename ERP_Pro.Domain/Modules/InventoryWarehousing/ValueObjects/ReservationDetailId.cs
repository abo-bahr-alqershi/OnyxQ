using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ReservationDetail Identifier Value Object
/// </summary>
public sealed class ReservationDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ReservationDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ReservationDetailId instance
    /// </summary>
    public ReservationDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ReservationDetailId with a new GUID
    /// </summary>
    public static ReservationDetailId CreateUnique()
    {
        return new ReservationDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ReservationDetailId id) => id.Value.ToString();
    public static implicit operator Guid(ReservationDetailId id) => id.Value;
}
}
