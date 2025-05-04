using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// YearReMoveDataDetail Identifier Value Object
/// </summary>
public sealed class YearReMoveDataDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the YearReMoveDataDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new YearReMoveDataDetailId instance
    /// </summary>
    public YearReMoveDataDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new YearReMoveDataDetailId with a new GUID
    /// </summary>
    public static YearReMoveDataDetailId CreateUnique()
    {
        return new YearReMoveDataDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(YearReMoveDataDetailId id) => id.Value.ToString();
    public static implicit operator Guid(YearReMoveDataDetailId id) => id.Value;
}
}
