using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects
{
/// <summary>
/// MissingDocumentTemp Identifier Value Object
/// </summary>
public sealed class MissingDocumentTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the MissingDocumentTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new MissingDocumentTempId instance
    /// </summary>
    public MissingDocumentTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new MissingDocumentTempId with a new GUID
    /// </summary>
    public static MissingDocumentTempId CreateUnique()
    {
        return new MissingDocumentTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(MissingDocumentTempId id) => id.Value.ToString();
    public static implicit operator Guid(MissingDocumentTempId id) => id.Value;
}
}
