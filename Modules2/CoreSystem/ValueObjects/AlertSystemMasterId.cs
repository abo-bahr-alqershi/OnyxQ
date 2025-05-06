using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// AlertSystemMaster Identifier Value Object
/// </summary>
public sealed class AlertSystemMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AlertSystemMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AlertSystemMasterId instance
    /// </summary>
    public AlertSystemMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AlertSystemMasterId with a new GUID
    /// </summary>
    public static AlertSystemMasterId CreateUnique()
    {
        return new AlertSystemMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AlertSystemMasterId id) => id.Value.ToString();
    public static implicit operator Guid(AlertSystemMasterId id) => id.Value;
}
}
