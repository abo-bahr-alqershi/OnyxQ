using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// TransferInTemp Identifier Value Object
/// </summary>
public sealed class TransferInTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TransferInTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TransferInTempId instance
    /// </summary>
    public TransferInTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TransferInTempId with a new GUID
    /// </summary>
    public static TransferInTempId CreateUnique()
    {
        return new TransferInTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TransferInTempId id) => id.Value.ToString();
    public static implicit operator Guid(TransferInTempId id) => id.Value;
}
}
