using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// BranchDocument Identifier Value Object
/// </summary>
public sealed class BranchDocumentId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchDocument
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchDocumentId instance
    /// </summary>
    public BranchDocumentId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchDocumentId with a new GUID
    /// </summary>
    public static BranchDocumentId CreateUnique()
    {
        return new BranchDocumentId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchDocumentId id) => id.Value.ToString();
    public static implicit operator Guid(BranchDocumentId id) => id.Value;
}
}
