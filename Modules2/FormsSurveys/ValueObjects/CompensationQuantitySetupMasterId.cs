using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects
{
/// <summary>
/// CompensationQuantitySetupMaster Identifier Value Object
/// </summary>
public sealed class CompensationQuantitySetupMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CompensationQuantitySetupMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CompensationQuantitySetupMasterId instance
    /// </summary>
    public CompensationQuantitySetupMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CompensationQuantitySetupMasterId with a new GUID
    /// </summary>
    public static CompensationQuantitySetupMasterId CreateUnique()
    {
        return new CompensationQuantitySetupMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CompensationQuantitySetupMasterId id) => id.Value.ToString();
    public static implicit operator Guid(CompensationQuantitySetupMasterId id) => id.Value;
}
}
