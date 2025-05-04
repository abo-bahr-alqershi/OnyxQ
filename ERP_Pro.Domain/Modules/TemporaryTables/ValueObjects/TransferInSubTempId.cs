using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// TransferInSubTemp Identifier Value Object
/// </summary>
public sealed class TransferInSubTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TransferInSubTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TransferInSubTempId instance
    /// </summary>
    public TransferInSubTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TransferInSubTempId with a new GUID
    /// </summary>
    public static TransferInSubTempId CreateUnique()
    {
        return new TransferInSubTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TransferInSubTempId id) => id.Value.ToString();
    public static implicit operator Guid(TransferInSubTempId id) => id.Value;
}
}
