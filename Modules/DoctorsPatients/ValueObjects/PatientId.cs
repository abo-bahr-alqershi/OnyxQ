using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.DoctorsPatients.ValueObjects
{
/// <summary>
/// Patient Identifier Value Object
/// </summary>
public sealed class PatientId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Patient
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PatientId instance
    /// </summary>
    public PatientId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PatientId with a new GUID
    /// </summary>
    public static PatientId CreateUnique()
    {
        return new PatientId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PatientId id) => id.Value.ToString();
    public static implicit operator Guid(PatientId id) => id.Value;
}
}
