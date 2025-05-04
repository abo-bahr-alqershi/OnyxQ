using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// TransferQuantityApprovedTemp Identifier Value Object
/// </summary>
public sealed class TransferQuantityApprovedTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TransferQuantityApprovedTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TransferQuantityApprovedTempId instance
    /// </summary>
    public TransferQuantityApprovedTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TransferQuantityApprovedTempId with a new GUID
    /// </summary>
    public static TransferQuantityApprovedTempId CreateUnique()
    {
        return new TransferQuantityApprovedTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TransferQuantityApprovedTempId id) => id.Value.ToString();
    public static implicit operator Guid(TransferQuantityApprovedTempId id) => id.Value;
}
}
