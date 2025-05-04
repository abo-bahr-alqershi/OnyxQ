using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// TransferInBranchTemp Identifier Value Object
/// </summary>
public sealed class TransferInBranchTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TransferInBranchTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TransferInBranchTempId instance
    /// </summary>
    public TransferInBranchTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TransferInBranchTempId with a new GUID
    /// </summary>
    public static TransferInBranchTempId CreateUnique()
    {
        return new TransferInBranchTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TransferInBranchTempId id) => id.Value.ToString();
    public static implicit operator Guid(TransferInBranchTempId id) => id.Value;
}
}
