using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SettingsParameters.ValueObjects
{
/// <summary>
/// ParameterAccountsPayable Identifier Value Object
/// </summary>
public sealed class ParameterAccountsPayableId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ParameterAccountsPayable
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ParameterAccountsPayableId instance
    /// </summary>
    public ParameterAccountsPayableId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ParameterAccountsPayableId with a new GUID
    /// </summary>
    public static ParameterAccountsPayableId CreateUnique()
    {
        return new ParameterAccountsPayableId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ParameterAccountsPayableId id) => id.Value.ToString();
    public static implicit operator Guid(ParameterAccountsPayableId id) => id.Value;
}
}
