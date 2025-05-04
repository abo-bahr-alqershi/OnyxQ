using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// BatchNumberContentMaster Identifier Value Object
/// </summary>
public sealed class BatchNumberContentMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BatchNumberContentMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BatchNumberContentMasterId instance
    /// </summary>
    public BatchNumberContentMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BatchNumberContentMasterId with a new GUID
    /// </summary>
    public static BatchNumberContentMasterId CreateUnique()
    {
        return new BatchNumberContentMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BatchNumberContentMasterId id) => id.Value.ToString();
    public static implicit operator Guid(BatchNumberContentMasterId id) => id.Value;
}
}
