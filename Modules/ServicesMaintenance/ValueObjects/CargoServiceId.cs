using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ServicesMaintenance.ValueObjects
{
/// <summary>
/// CargoService Identifier Value Object
/// </summary>
public sealed class CargoServiceId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CargoService
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CargoServiceId instance
    /// </summary>
    public CargoServiceId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CargoServiceId with a new GUID
    /// </summary>
    public static CargoServiceId CreateUnique()
    {
        return new CargoServiceId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CargoServiceId id) => id.Value.ToString();
    public static implicit operator Guid(CargoServiceId id) => id.Value;
}
}
