using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// AutoSalesOrderDetail Identifier Value Object
/// </summary>
public sealed class AutoSalesOrderDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AutoSalesOrderDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AutoSalesOrderDetailId instance
    /// </summary>
    public AutoSalesOrderDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AutoSalesOrderDetailId with a new GUID
    /// </summary>
    public static AutoSalesOrderDetailId CreateUnique()
    {
        return new AutoSalesOrderDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AutoSalesOrderDetailId id) => id.Value.ToString();
    public static implicit operator Guid(AutoSalesOrderDetailId id) => id.Value;
}
}
