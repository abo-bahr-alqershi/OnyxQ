using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// ChequeTrace Identifier Value Object
/// </summary>
public sealed class ChequeTraceId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ChequeTrace
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ChequeTraceId instance
    /// </summary>
    public ChequeTraceId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ChequeTraceId with a new GUID
    /// </summary>
    public static ChequeTraceId CreateUnique()
    {
        return new ChequeTraceId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ChequeTraceId id) => id.Value.ToString();
    public static implicit operator Guid(ChequeTraceId id) => id.Value;
}
}
