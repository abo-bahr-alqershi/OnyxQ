using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.StationsFuel.ValueObjects
{
/// <summary>
/// StationWarehouseTransferDetail Identifier Value Object
/// </summary>
public sealed class StationWarehouseTransferDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the StationWarehouseTransferDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new StationWarehouseTransferDetailId instance
    /// </summary>
    public StationWarehouseTransferDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new StationWarehouseTransferDetailId with a new GUID
    /// </summary>
    public static StationWarehouseTransferDetailId CreateUnique()
    {
        return new StationWarehouseTransferDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(StationWarehouseTransferDetailId id) => id.Value.ToString();
    public static implicit operator Guid(StationWarehouseTransferDetailId id) => id.Value;
}
}
