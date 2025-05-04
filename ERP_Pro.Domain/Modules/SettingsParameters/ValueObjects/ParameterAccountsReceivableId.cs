using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SettingsParameters.ValueObjects
{
/// <summary>
/// ParameterAccountsReceivable Identifier Value Object
/// </summary>
public sealed class ParameterAccountsReceivableId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ParameterAccountsReceivable
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ParameterAccountsReceivableId instance
    /// </summary>
    public ParameterAccountsReceivableId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ParameterAccountsReceivableId with a new GUID
    /// </summary>
    public static ParameterAccountsReceivableId CreateUnique()
    {
        return new ParameterAccountsReceivableId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ParameterAccountsReceivableId id) => id.Value.ToString();
    public static implicit operator Guid(ParameterAccountsReceivableId id) => id.Value;
}
}
