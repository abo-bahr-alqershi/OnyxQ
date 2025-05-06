using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// TraceLoginNote Identifier Value Object
/// </summary>
public sealed class TraceLoginNoteId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TraceLoginNote
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TraceLoginNoteId instance
    /// </summary>
    public TraceLoginNoteId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TraceLoginNoteId with a new GUID
    /// </summary>
    public static TraceLoginNoteId CreateUnique()
    {
        return new TraceLoginNoteId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TraceLoginNoteId id) => id.Value.ToString();
    public static implicit operator Guid(TraceLoginNoteId id) => id.Value;
}
}
