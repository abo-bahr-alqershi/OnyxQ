using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesmanCommissionSetupDetail Identifier Value Object
/// </summary>
public sealed class SalesmanCommissionSetupDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesmanCommissionSetupDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesmanCommissionSetupDetailId instance
    /// </summary>
    public SalesmanCommissionSetupDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesmanCommissionSetupDetailId with a new GUID
    /// </summary>
    public static SalesmanCommissionSetupDetailId CreateUnique()
    {
        return new SalesmanCommissionSetupDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesmanCommissionSetupDetailId id) => id.Value.ToString();
    public static implicit operator Guid(SalesmanCommissionSetupDetailId id) => id.Value;
}
}
