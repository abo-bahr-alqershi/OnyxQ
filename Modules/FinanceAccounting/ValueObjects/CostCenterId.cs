using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// CostCenter Identifier Value Object
/// </summary>
public sealed class CostCenterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CostCenter
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CostCenterId instance
    /// </summary>
    public CostCenterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CostCenterId with a new GUID
    /// </summary>
    public static CostCenterId CreateUnique()
    {
        return new CostCenterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CostCenterId id) => id.Value.ToString();
    public static implicit operator Guid(CostCenterId id) => id.Value;
}
}
