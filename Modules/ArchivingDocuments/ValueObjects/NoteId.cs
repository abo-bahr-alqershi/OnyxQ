using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects
{
/// <summary>
/// Note Identifier Value Object
/// </summary>
public sealed class NoteId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Note
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new NoteId instance
    /// </summary>
    public NoteId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new NoteId with a new GUID
    /// </summary>
    public static NoteId CreateUnique()
    {
        return new NoteId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(NoteId id) => id.Value.ToString();
    public static implicit operator Guid(NoteId id) => id.Value;
}
}
