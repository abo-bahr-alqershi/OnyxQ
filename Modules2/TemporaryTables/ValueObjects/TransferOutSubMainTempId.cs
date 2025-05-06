using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// TransferOutSubMainTemp Identifier Value Object
/// </summary>
public sealed class TransferOutSubMainTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TransferOutSubMainTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TransferOutSubMainTempId instance
    /// </summary>
    public TransferOutSubMainTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TransferOutSubMainTempId with a new GUID
    /// </summary>
    public static TransferOutSubMainTempId CreateUnique()
    {
        return new TransferOutSubMainTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TransferOutSubMainTempId id) => id.Value.ToString();
    public static implicit operator Guid(TransferOutSubMainTempId id) => id.Value;
}
}
