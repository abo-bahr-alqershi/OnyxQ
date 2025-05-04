using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// TransferOutTemp Identifier Value Object
/// </summary>
public sealed class TransferOutTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TransferOutTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TransferOutTempId instance
    /// </summary>
    public TransferOutTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TransferOutTempId with a new GUID
    /// </summary>
    public static TransferOutTempId CreateUnique()
    {
        return new TransferOutTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TransferOutTempId id) => id.Value.ToString();
    public static implicit operator Guid(TransferOutTempId id) => id.Value;
}
}
