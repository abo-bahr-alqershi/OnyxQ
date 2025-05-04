using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.DoctorsPatients.ValueObjects
{
/// <summary>
/// Doctor Identifier Value Object
/// </summary>
public sealed class DoctorId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Doctor
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DoctorId instance
    /// </summary>
    public DoctorId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DoctorId with a new GUID
    /// </summary>
    public static DoctorId CreateUnique()
    {
        return new DoctorId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DoctorId id) => id.Value.ToString();
    public static implicit operator Guid(DoctorId id) => id.Value;
}
}
