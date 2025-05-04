using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// TransferOutSubTemp Identifier Value Object
/// </summary>
public sealed class TransferOutSubTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TransferOutSubTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TransferOutSubTempId instance
    /// </summary>
    public TransferOutSubTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TransferOutSubTempId with a new GUID
    /// </summary>
    public static TransferOutSubTempId CreateUnique()
    {
        return new TransferOutSubTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TransferOutSubTempId id) => id.Value.ToString();
    public static implicit operator Guid(TransferOutSubTempId id) => id.Value;
}
}
