using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// AccountAnalysis Identifier Value Object
/// </summary>
public sealed class AccountAnalysisId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountAnalysis
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountAnalysisId instance
    /// </summary>
    public AccountAnalysisId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountAnalysisId with a new GUID
    /// </summary>
    public static AccountAnalysisId CreateUnique()
    {
        return new AccountAnalysisId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountAnalysisId id) => id.Value.ToString();
    public static implicit operator Guid(AccountAnalysisId id) => id.Value;
}
}
