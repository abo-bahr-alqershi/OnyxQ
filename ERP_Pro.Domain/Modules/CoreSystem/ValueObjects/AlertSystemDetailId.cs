using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// AlertSystemDetail Identifier Value Object
/// </summary>
public sealed class AlertSystemDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AlertSystemDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AlertSystemDetailId instance
    /// </summary>
    public AlertSystemDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AlertSystemDetailId with a new GUID
    /// </summary>
    public static AlertSystemDetailId CreateUnique()
    {
        return new AlertSystemDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AlertSystemDetailId id) => id.Value.ToString();
    public static implicit operator Guid(AlertSystemDetailId id) => id.Value;
}
}
