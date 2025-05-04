using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects
{
/// <summary>
/// ArchiveMaster Identifier Value Object
/// </summary>
public sealed class ArchiveMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ArchiveMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ArchiveMasterId instance
    /// </summary>
    public ArchiveMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ArchiveMasterId with a new GUID
    /// </summary>
    public static ArchiveMasterId CreateUnique()
    {
        return new ArchiveMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ArchiveMasterId id) => id.Value.ToString();
    public static implicit operator Guid(ArchiveMasterId id) => id.Value;
}
}
