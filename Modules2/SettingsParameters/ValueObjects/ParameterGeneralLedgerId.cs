using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SettingsParameters.ValueObjects
{
/// <summary>
/// ParameterGeneralLedger Identifier Value Object
/// </summary>
public sealed class ParameterGeneralLedgerId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ParameterGeneralLedger
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ParameterGeneralLedgerId instance
    /// </summary>
    public ParameterGeneralLedgerId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ParameterGeneralLedgerId with a new GUID
    /// </summary>
    public static ParameterGeneralLedgerId CreateUnique()
    {
        return new ParameterGeneralLedgerId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ParameterGeneralLedgerId id) => id.Value.ToString();
    public static implicit operator Guid(ParameterGeneralLedgerId id) => id.Value;
}
}
