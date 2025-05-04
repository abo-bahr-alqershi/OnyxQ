using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects
{
/// <summary>
/// FormDetail Identifier Value Object
/// </summary>
public sealed class FormDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the FormDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new FormDetailId instance
    /// </summary>
    public FormDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new FormDetailId with a new GUID
    /// </summary>
    public static FormDetailId CreateUnique()
    {
        return new FormDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(FormDetailId id) => id.Value.ToString();
    public static implicit operator Guid(FormDetailId id) => id.Value;
}
}
