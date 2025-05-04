using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects
{
/// <summary>
/// LightDocumentBranch Identifier Value Object
/// </summary>
public sealed class LightDocumentBranchId : ValueObject
{
    /// <summary>
    /// The unique identifier for the LightDocumentBranch
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new LightDocumentBranchId instance
    /// </summary>
    public LightDocumentBranchId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new LightDocumentBranchId with a new GUID
    /// </summary>
    public static LightDocumentBranchId CreateUnique()
    {
        return new LightDocumentBranchId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(LightDocumentBranchId id) => id.Value.ToString();
    public static implicit operator Guid(LightDocumentBranchId id) => id.Value;
}
}
