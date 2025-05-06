using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// LibraryFile Identifier Value Object
/// </summary>
public sealed class LibraryFileId : ValueObject
{
    /// <summary>
    /// The unique identifier for the LibraryFile
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new LibraryFileId instance
    /// </summary>
    public LibraryFileId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new LibraryFileId with a new GUID
    /// </summary>
    public static LibraryFileId CreateUnique()
    {
        return new LibraryFileId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(LibraryFileId id) => id.Value.ToString();
    public static implicit operator Guid(LibraryFileId id) => id.Value;
}
}
