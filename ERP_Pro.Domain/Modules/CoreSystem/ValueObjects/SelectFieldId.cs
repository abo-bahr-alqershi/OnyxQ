using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// SelectField Identifier Value Object
/// </summary>
public sealed class SelectFieldId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SelectField
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SelectFieldId instance
    /// </summary>
    public SelectFieldId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SelectFieldId with a new GUID
    /// </summary>
    public static SelectFieldId CreateUnique()
    {
        return new SelectFieldId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SelectFieldId id) => id.Value.ToString();
    public static implicit operator Guid(SelectFieldId id) => id.Value;
}
}
