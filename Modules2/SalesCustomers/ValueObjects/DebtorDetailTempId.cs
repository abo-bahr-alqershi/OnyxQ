using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// DebtorDetailTemp Identifier Value Object
/// </summary>
public sealed class DebtorDetailTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DebtorDetailTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DebtorDetailTempId instance
    /// </summary>
    public DebtorDetailTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DebtorDetailTempId with a new GUID
    /// </summary>
    public static DebtorDetailTempId CreateUnique()
    {
        return new DebtorDetailTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DebtorDetailTempId id) => id.Value.ToString();
    public static implicit operator Guid(DebtorDetailTempId id) => id.Value;
}
}
