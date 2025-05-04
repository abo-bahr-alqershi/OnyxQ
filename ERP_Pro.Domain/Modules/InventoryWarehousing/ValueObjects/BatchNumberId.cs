using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// BatchNumber Identifier Value Object
/// </summary>
public sealed class BatchNumberId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BatchNumber
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BatchNumberId instance
    /// </summary>
    public BatchNumberId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BatchNumberId with a new GUID
    /// </summary>
    public static BatchNumberId CreateUnique()
    {
        return new BatchNumberId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BatchNumberId id) => id.Value.ToString();
    public static implicit operator Guid(BatchNumberId id) => id.Value;
}
}
