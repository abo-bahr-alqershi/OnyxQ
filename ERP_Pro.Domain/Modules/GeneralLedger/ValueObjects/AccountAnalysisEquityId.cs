using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// AccountAnalysisEquity Identifier Value Object
/// </summary>
public sealed class AccountAnalysisEquityId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountAnalysisEquity
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountAnalysisEquityId instance
    /// </summary>
    public AccountAnalysisEquityId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountAnalysisEquityId with a new GUID
    /// </summary>
    public static AccountAnalysisEquityId CreateUnique()
    {
        return new AccountAnalysisEquityId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountAnalysisEquityId id) => id.Value.ToString();
    public static implicit operator Guid(AccountAnalysisEquityId id) => id.Value;
}
}
