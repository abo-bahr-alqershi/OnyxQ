using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// ApexFavoriteScreen Identifier Value Object
/// </summary>
public sealed class ApexFavoriteScreenId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ApexFavoriteScreen
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ApexFavoriteScreenId instance
    /// </summary>
    public ApexFavoriteScreenId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ApexFavoriteScreenId with a new GUID
    /// </summary>
    public static ApexFavoriteScreenId CreateUnique()
    {
        return new ApexFavoriteScreenId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ApexFavoriteScreenId id) => id.Value.ToString();
    public static implicit operator Guid(ApexFavoriteScreenId id) => id.Value;
}
}
