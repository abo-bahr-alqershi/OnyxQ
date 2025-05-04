using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// PostDetail Identifier Value Object
/// </summary>
public sealed class PostDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PostDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PostDetailId instance
    /// </summary>
    public PostDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PostDetailId with a new GUID
    /// </summary>
    public static PostDetailId CreateUnique()
    {
        return new PostDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PostDetailId id) => id.Value.ToString();
    public static implicit operator Guid(PostDetailId id) => id.Value;
}
}
