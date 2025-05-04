using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// AutoSalesOrderMaster Identifier Value Object
/// </summary>
public sealed class AutoSalesOrderMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AutoSalesOrderMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AutoSalesOrderMasterId instance
    /// </summary>
    public AutoSalesOrderMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AutoSalesOrderMasterId with a new GUID
    /// </summary>
    public static AutoSalesOrderMasterId CreateUnique()
    {
        return new AutoSalesOrderMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AutoSalesOrderMasterId id) => id.Value.ToString();
    public static implicit operator Guid(AutoSalesOrderMasterId id) => id.Value;
}
}
