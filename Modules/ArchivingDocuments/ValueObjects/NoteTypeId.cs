using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects
{
/// <summary>
/// NoteType Identifier Value Object
/// </summary>
public sealed class NoteTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the NoteType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new NoteTypeId instance
    /// </summary>
    public NoteTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new NoteTypeId with a new GUID
    /// </summary>
    public static NoteTypeId CreateUnique()
    {
        return new NoteTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(NoteTypeId id) => id.Value.ToString();
    public static implicit operator Guid(NoteTypeId id) => id.Value;
}
}
