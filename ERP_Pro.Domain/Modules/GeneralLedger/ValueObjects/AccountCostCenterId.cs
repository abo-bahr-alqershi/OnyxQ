using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// AccountCostCenter Identifier Value Object
/// </summary>
public sealed class AccountCostCenterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountCostCenter
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountCostCenterId instance
    /// </summary>
    public AccountCostCenterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountCostCenterId with a new GUID
    /// </summary>
    public static AccountCostCenterId CreateUnique()
    {
        return new AccountCostCenterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountCostCenterId id) => id.Value.ToString();
    public static implicit operator Guid(AccountCostCenterId id) => id.Value;
}
}
