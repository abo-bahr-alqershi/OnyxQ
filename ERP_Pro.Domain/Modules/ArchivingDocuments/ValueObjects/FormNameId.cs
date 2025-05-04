using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects
{
/// <summary>
/// FormName Identifier Value Object
/// </summary>
public sealed class FormNameId : ValueObject
{
    /// <summary>
    /// The unique identifier for the FormName
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new FormNameId instance
    /// </summary>
    public FormNameId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new FormNameId with a new GUID
    /// </summary>
    public static FormNameId CreateUnique()
    {
        return new FormNameId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(FormNameId id) => id.Value.ToString();
    public static implicit operator Guid(FormNameId id) => id.Value;
}
}
