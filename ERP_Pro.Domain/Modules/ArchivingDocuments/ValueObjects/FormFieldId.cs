using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects
{
/// <summary>
/// FormField Identifier Value Object
/// </summary>
public sealed class FormFieldId : ValueObject
{
    /// <summary>
    /// The unique identifier for the FormField
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new FormFieldId instance
    /// </summary>
    public FormFieldId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new FormFieldId with a new GUID
    /// </summary>
    public static FormFieldId CreateUnique()
    {
        return new FormFieldId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(FormFieldId id) => id.Value.ToString();
    public static implicit operator Guid(FormFieldId id) => id.Value;
}
}
