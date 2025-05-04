using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CollectorCommissionSetupDetail Identifier Value Object
/// </summary>
public sealed class CollectorCommissionSetupDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CollectorCommissionSetupDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CollectorCommissionSetupDetailId instance
    /// </summary>
    public CollectorCommissionSetupDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CollectorCommissionSetupDetailId with a new GUID
    /// </summary>
    public static CollectorCommissionSetupDetailId CreateUnique()
    {
        return new CollectorCommissionSetupDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CollectorCommissionSetupDetailId id) => id.Value.ToString();
    public static implicit operator Guid(CollectorCommissionSetupDetailId id) => id.Value;
}
}
