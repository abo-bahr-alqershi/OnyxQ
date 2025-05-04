using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// PostMaster Identifier Value Object
/// </summary>
public sealed class PostMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PostMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PostMasterId instance
    /// </summary>
    public PostMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PostMasterId with a new GUID
    /// </summary>
    public static PostMasterId CreateUnique()
    {
        return new PostMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PostMasterId id) => id.Value.ToString();
    public static implicit operator Guid(PostMasterId id) => id.Value;
}
}
