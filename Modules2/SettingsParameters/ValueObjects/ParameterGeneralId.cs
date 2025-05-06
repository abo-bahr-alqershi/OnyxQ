using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SettingsParameters.ValueObjects
{
/// <summary>
/// ParameterGeneral Identifier Value Object
/// </summary>
public sealed class ParameterGeneralId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ParameterGeneral
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ParameterGeneralId instance
    /// </summary>
    public ParameterGeneralId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ParameterGeneralId with a new GUID
    /// </summary>
    public static ParameterGeneralId CreateUnique()
    {
        return new ParameterGeneralId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ParameterGeneralId id) => id.Value.ToString();
    public static implicit operator Guid(ParameterGeneralId id) => id.Value;
}
}
