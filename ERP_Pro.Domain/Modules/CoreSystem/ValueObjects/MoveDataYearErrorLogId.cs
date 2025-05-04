using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// MoveDataYearErrorLog Identifier Value Object
/// </summary>
public sealed class MoveDataYearErrorLogId : ValueObject
{
    /// <summary>
    /// The unique identifier for the MoveDataYearErrorLog
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new MoveDataYearErrorLogId instance
    /// </summary>
    public MoveDataYearErrorLogId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new MoveDataYearErrorLogId with a new GUID
    /// </summary>
    public static MoveDataYearErrorLogId CreateUnique()
    {
        return new MoveDataYearErrorLogId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(MoveDataYearErrorLogId id) => id.Value.ToString();
    public static implicit operator Guid(MoveDataYearErrorLogId id) => id.Value;
}
}
