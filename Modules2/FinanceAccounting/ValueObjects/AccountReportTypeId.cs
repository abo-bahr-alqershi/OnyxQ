using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// AccountReportType Identifier Value Object
/// </summary>
public sealed class AccountReportTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountReportType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountReportTypeId instance
    /// </summary>
    public AccountReportTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountReportTypeId with a new GUID
    /// </summary>
    public static AccountReportTypeId CreateUnique()
    {
        return new AccountReportTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountReportTypeId id) => id.Value.ToString();
    public static implicit operator Guid(AccountReportTypeId id) => id.Value;
}
}
