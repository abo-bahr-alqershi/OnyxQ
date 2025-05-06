using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ArticlesContent.ValueObjects
{
/// <summary>
/// Article Identifier Value Object
/// </summary>
public sealed class ArticleId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Article
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ArticleId instance
    /// </summary>
    public ArticleId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ArticleId with a new GUID
    /// </summary>
    public static ArticleId CreateUnique()
    {
        return new ArticleId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ArticleId id) => id.Value.ToString();
    public static implicit operator Guid(ArticleId id) => id.Value;
}
}
