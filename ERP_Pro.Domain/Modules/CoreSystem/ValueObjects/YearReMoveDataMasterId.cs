using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// YearReMoveDataMaster Identifier Value Object
/// </summary>
public sealed class YearReMoveDataMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the YearReMoveDataMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new YearReMoveDataMasterId instance
    /// </summary>
    public YearReMoveDataMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new YearReMoveDataMasterId with a new GUID
    /// </summary>
    public static YearReMoveDataMasterId CreateUnique()
    {
        return new YearReMoveDataMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(YearReMoveDataMasterId id) => id.Value.ToString();
    public static implicit operator Guid(YearReMoveDataMasterId id) => id.Value;
}
}
