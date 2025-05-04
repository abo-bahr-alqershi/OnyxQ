using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// CollectorImportExcelTemplate Identifier Value Object
/// </summary>
public sealed class CollectorImportExcelTemplateId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CollectorImportExcelTemplate
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CollectorImportExcelTemplateId instance
    /// </summary>
    public CollectorImportExcelTemplateId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CollectorImportExcelTemplateId with a new GUID
    /// </summary>
    public static CollectorImportExcelTemplateId CreateUnique()
    {
        return new CollectorImportExcelTemplateId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CollectorImportExcelTemplateId id) => id.Value.ToString();
    public static implicit operator Guid(CollectorImportExcelTemplateId id) => id.Value;
}
}
