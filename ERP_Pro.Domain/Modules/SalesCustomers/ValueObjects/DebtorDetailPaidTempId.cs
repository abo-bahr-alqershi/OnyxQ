using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// DebtorDetailPaidTemp Identifier Value Object
/// </summary>
public sealed class DebtorDetailPaidTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DebtorDetailPaidTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DebtorDetailPaidTempId instance
    /// </summary>
    public DebtorDetailPaidTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DebtorDetailPaidTempId with a new GUID
    /// </summary>
    public static DebtorDetailPaidTempId CreateUnique()
    {
        return new DebtorDetailPaidTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DebtorDetailPaidTempId id) => id.Value.ToString();
    public static implicit operator Guid(DebtorDetailPaidTempId id) => id.Value;
}
}
