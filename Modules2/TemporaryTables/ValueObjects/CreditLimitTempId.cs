using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// CreditLimitTemp Identifier Value Object
/// </summary>
public sealed class CreditLimitTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CreditLimitTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CreditLimitTempId instance
    /// </summary>
    public CreditLimitTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CreditLimitTempId with a new GUID
    /// </summary>
    public static CreditLimitTempId CreateUnique()
    {
        return new CreditLimitTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CreditLimitTempId id) => id.Value.ToString();
    public static implicit operator Guid(CreditLimitTempId id) => id.Value;
}
}
