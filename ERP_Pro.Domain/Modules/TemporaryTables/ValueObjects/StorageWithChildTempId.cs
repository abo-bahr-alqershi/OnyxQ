using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// StorageWithChildTemp Identifier Value Object
/// </summary>
public sealed class StorageWithChildTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the StorageWithChildTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new StorageWithChildTempId instance
    /// </summary>
    public StorageWithChildTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new StorageWithChildTempId with a new GUID
    /// </summary>
    public static StorageWithChildTempId CreateUnique()
    {
        return new StorageWithChildTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(StorageWithChildTempId id) => id.Value.ToString();
    public static implicit operator Guid(StorageWithChildTempId id) => id.Value;
}
}
