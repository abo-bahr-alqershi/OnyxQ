using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects
{
/// <summary>
/// MandatoryScreen Identifier Value Object
/// </summary>
public sealed class MandatoryScreenId : ValueObject
{
    /// <summary>
    /// The unique identifier for the MandatoryScreen
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new MandatoryScreenId instance
    /// </summary>
    public MandatoryScreenId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new MandatoryScreenId with a new GUID
    /// </summary>
    public static MandatoryScreenId CreateUnique()
    {
        return new MandatoryScreenId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(MandatoryScreenId id) => id.Value.ToString();
    public static implicit operator Guid(MandatoryScreenId id) => id.Value;
}
}
