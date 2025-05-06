using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ReservationMaster Identifier Value Object
/// </summary>
public sealed class ReservationMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ReservationMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ReservationMasterId instance
    /// </summary>
    public ReservationMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ReservationMasterId with a new GUID
    /// </summary>
    public static ReservationMasterId CreateUnique()
    {
        return new ReservationMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ReservationMasterId id) => id.Value.ToString();
    public static implicit operator Guid(ReservationMasterId id) => id.Value;
}
}
