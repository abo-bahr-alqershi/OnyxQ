using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.ValueObjects
{
/// <summary>
/// AssembleItemExpand Identifier Value Object
/// </summary>
public sealed class AssembleItemExpandId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AssembleItemExpand
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AssembleItemExpandId instance
    /// </summary>
    public AssembleItemExpandId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AssembleItemExpandId with a new GUID
    /// </summary>
    public static AssembleItemExpandId CreateUnique()
    {
        return new AssembleItemExpandId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AssembleItemExpandId id) => id.Value.ToString();
    public static implicit operator Guid(AssembleItemExpandId id) => id.Value;
}
}
