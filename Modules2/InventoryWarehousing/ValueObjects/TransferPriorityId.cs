using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// TransferPriority Identifier Value Object
/// </summary>
public sealed class TransferPriorityId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TransferPriority
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TransferPriorityId instance
    /// </summary>
    public TransferPriorityId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TransferPriorityId with a new GUID
    /// </summary>
    public static TransferPriorityId CreateUnique()
    {
        return new TransferPriorityId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TransferPriorityId id) => id.Value.ToString();
    public static implicit operator Guid(TransferPriorityId id) => id.Value;
}
}
