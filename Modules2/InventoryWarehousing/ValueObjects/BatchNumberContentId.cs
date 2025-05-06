using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// BatchNumberContent Identifier Value Object
/// </summary>
public sealed class BatchNumberContentId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BatchNumberContent
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BatchNumberContentId instance
    /// </summary>
    public BatchNumberContentId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BatchNumberContentId with a new GUID
    /// </summary>
    public static BatchNumberContentId CreateUnique()
    {
        return new BatchNumberContentId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BatchNumberContentId id) => id.Value.ToString();
    public static implicit operator Guid(BatchNumberContentId id) => id.Value;
}
}
