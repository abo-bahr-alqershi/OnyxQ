using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects
{
/// <summary>
/// CompensationQuantitySetupDetail Identifier Value Object
/// </summary>
public sealed class CompensationQuantitySetupDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CompensationQuantitySetupDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CompensationQuantitySetupDetailId instance
    /// </summary>
    public CompensationQuantitySetupDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CompensationQuantitySetupDetailId with a new GUID
    /// </summary>
    public static CompensationQuantitySetupDetailId CreateUnique()
    {
        return new CompensationQuantitySetupDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CompensationQuantitySetupDetailId id) => id.Value.ToString();
    public static implicit operator Guid(CompensationQuantitySetupDetailId id) => id.Value;
}
}
