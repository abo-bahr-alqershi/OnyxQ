using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// JournalFileDetail Identifier Value Object
/// </summary>
public sealed class JournalFileDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the JournalFileDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new JournalFileDetailId instance
    /// </summary>
    public JournalFileDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new JournalFileDetailId with a new GUID
    /// </summary>
    public static JournalFileDetailId CreateUnique()
    {
        return new JournalFileDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(JournalFileDetailId id) => id.Value.ToString();
    public static implicit operator Guid(JournalFileDetailId id) => id.Value;
}
}
