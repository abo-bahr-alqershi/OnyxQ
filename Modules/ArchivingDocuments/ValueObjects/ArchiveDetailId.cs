using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects
{
/// <summary>
/// ArchiveDetail Identifier Value Object
/// </summary>
public sealed class ArchiveDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ArchiveDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ArchiveDetailId instance
    /// </summary>
    public ArchiveDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ArchiveDetailId with a new GUID
    /// </summary>
    public static ArchiveDetailId CreateUnique()
    {
        return new ArchiveDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ArchiveDetailId id) => id.Value.ToString();
    public static implicit operator Guid(ArchiveDetailId id) => id.Value;
}
}
