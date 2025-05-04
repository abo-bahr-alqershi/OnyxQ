using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// TransferInSubMainTemp Identifier Value Object
/// </summary>
public sealed class TransferInSubMainTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TransferInSubMainTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TransferInSubMainTempId instance
    /// </summary>
    public TransferInSubMainTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TransferInSubMainTempId with a new GUID
    /// </summary>
    public static TransferInSubMainTempId CreateUnique()
    {
        return new TransferInSubMainTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TransferInSubMainTempId id) => id.Value.ToString();
    public static implicit operator Guid(TransferInSubMainTempId id) => id.Value;
}
}
