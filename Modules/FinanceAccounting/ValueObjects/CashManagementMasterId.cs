using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// CashManagementMaster Identifier Value Object
/// </summary>
public sealed class CashManagementMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CashManagementMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CashManagementMasterId instance
    /// </summary>
    public CashManagementMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CashManagementMasterId with a new GUID
    /// </summary>
    public static CashManagementMasterId CreateUnique()
    {
        return new CashManagementMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CashManagementMasterId id) => id.Value.ToString();
    public static implicit operator Guid(CashManagementMasterId id) => id.Value;
}
}
