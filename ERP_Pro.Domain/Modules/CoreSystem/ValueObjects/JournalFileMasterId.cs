using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// JournalFileMaster Identifier Value Object
/// </summary>
public sealed class JournalFileMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the JournalFileMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new JournalFileMasterId instance
    /// </summary>
    public JournalFileMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new JournalFileMasterId with a new GUID
    /// </summary>
    public static JournalFileMasterId CreateUnique()
    {
        return new JournalFileMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(JournalFileMasterId id) => id.Value.ToString();
    public static implicit operator Guid(JournalFileMasterId id) => id.Value;
}
}
