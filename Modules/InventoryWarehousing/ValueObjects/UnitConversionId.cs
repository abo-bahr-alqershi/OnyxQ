using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// UnitConversion Identifier Value Object
/// </summary>
public sealed class UnitConversionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the UnitConversion
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new UnitConversionId instance
    /// </summary>
    public UnitConversionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new UnitConversionId with a new GUID
    /// </summary>
    public static UnitConversionId CreateUnique()
    {
        return new UnitConversionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(UnitConversionId id) => id.Value.ToString();
    public static implicit operator Guid(UnitConversionId id) => id.Value;
}
}
