using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects
{
/// <summary>
/// OrderDetail Identifier Value Object
/// </summary>
public sealed class OrderDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the OrderDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new OrderDetailId instance
    /// </summary>
    public OrderDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new OrderDetailId with a new GUID
    /// </summary>
    public static OrderDetailId CreateUnique()
    {
        return new OrderDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(OrderDetailId id) => id.Value.ToString();
    public static implicit operator Guid(OrderDetailId id) => id.Value;
}
}
