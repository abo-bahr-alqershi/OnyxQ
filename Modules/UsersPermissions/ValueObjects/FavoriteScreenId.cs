using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// FavoriteScreen Identifier Value Object
/// </summary>
public sealed class FavoriteScreenId : ValueObject
{
    /// <summary>
    /// The unique identifier for the FavoriteScreen
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new FavoriteScreenId instance
    /// </summary>
    public FavoriteScreenId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new FavoriteScreenId with a new GUID
    /// </summary>
    public static FavoriteScreenId CreateUnique()
    {
        return new FavoriteScreenId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(FavoriteScreenId id) => id.Value.ToString();
    public static implicit operator Guid(FavoriteScreenId id) => id.Value;
}
}
