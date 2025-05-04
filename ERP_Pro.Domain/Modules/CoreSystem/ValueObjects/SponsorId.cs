using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// Sponsor Identifier Value Object
/// </summary>
public sealed class SponsorId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Sponsor
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SponsorId instance
    /// </summary>
    public SponsorId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SponsorId with a new GUID
    /// </summary>
    public static SponsorId CreateUnique()
    {
        return new SponsorId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SponsorId id) => id.Value.ToString();
    public static implicit operator Guid(SponsorId id) => id.Value;
}
}
