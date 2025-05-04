using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// CashInHandDetail Identifier Value Object
/// </summary>
public sealed class CashInHandDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CashInHandDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CashInHandDetailId instance
    /// </summary>
    public CashInHandDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CashInHandDetailId with a new GUID
    /// </summary>
    public static CashInHandDetailId CreateUnique()
    {
        return new CashInHandDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CashInHandDetailId id) => id.Value.ToString();
    public static implicit operator Guid(CashInHandDetailId id) => id.Value;
}
}
