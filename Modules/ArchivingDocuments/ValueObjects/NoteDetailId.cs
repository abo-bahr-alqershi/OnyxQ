using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects
{
/// <summary>
/// NoteDetail Identifier Value Object
/// </summary>
public sealed class NoteDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the NoteDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new NoteDetailId instance
    /// </summary>
    public NoteDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new NoteDetailId with a new GUID
    /// </summary>
    public static NoteDetailId CreateUnique()
    {
        return new NoteDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(NoteDetailId id) => id.Value.ToString();
    public static implicit operator Guid(NoteDetailId id) => id.Value;
}
}
