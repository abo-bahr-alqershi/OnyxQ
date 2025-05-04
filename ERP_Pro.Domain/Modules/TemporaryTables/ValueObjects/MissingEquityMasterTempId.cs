using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// MissingEquityMasterTemp Identifier Value Object
/// </summary>
public sealed class MissingEquityMasterTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the MissingEquityMasterTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new MissingEquityMasterTempId instance
    /// </summary>
    public MissingEquityMasterTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new MissingEquityMasterTempId with a new GUID
    /// </summary>
    public static MissingEquityMasterTempId CreateUnique()
    {
        return new MissingEquityMasterTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(MissingEquityMasterTempId id) => id.Value.ToString();
    public static implicit operator Guid(MissingEquityMasterTempId id) => id.Value;
}
}
