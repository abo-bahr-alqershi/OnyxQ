using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// TransferOutBranchTemp Identifier Value Object
/// </summary>
public sealed class TransferOutBranchTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TransferOutBranchTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TransferOutBranchTempId instance
    /// </summary>
    public TransferOutBranchTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TransferOutBranchTempId with a new GUID
    /// </summary>
    public static TransferOutBranchTempId CreateUnique()
    {
        return new TransferOutBranchTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TransferOutBranchTempId id) => id.Value.ToString();
    public static implicit operator Guid(TransferOutBranchTempId id) => id.Value;
}
}
