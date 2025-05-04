using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// IncomingOutgoingDetail Identifier Value Object
/// </summary>
public sealed class IncomingOutgoingDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the IncomingOutgoingDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new IncomingOutgoingDetailId instance
    /// </summary>
    public IncomingOutgoingDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new IncomingOutgoingDetailId with a new GUID
    /// </summary>
    public static IncomingOutgoingDetailId CreateUnique()
    {
        return new IncomingOutgoingDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(IncomingOutgoingDetailId id) => id.Value.ToString();
    public static implicit operator Guid(IncomingOutgoingDetailId id) => id.Value;
}
}
