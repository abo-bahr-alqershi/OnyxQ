using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// DocumentPostUnpostTemp Identifier Value Object
/// </summary>
public sealed class DocumentPostUnpostTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DocumentPostUnpostTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DocumentPostUnpostTempId instance
    /// </summary>
    public DocumentPostUnpostTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DocumentPostUnpostTempId with a new GUID
    /// </summary>
    public static DocumentPostUnpostTempId CreateUnique()
    {
        return new DocumentPostUnpostTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DocumentPostUnpostTempId id) => id.Value.ToString();
    public static implicit operator Guid(DocumentPostUnpostTempId id) => id.Value;
}
}
