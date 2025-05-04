using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ServicesMaintenance.ValueObjects
{
/// <summary>
/// BranchCargoService Identifier Value Object
/// </summary>
public sealed class BranchCargoServiceId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchCargoService
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchCargoServiceId instance
    /// </summary>
    public BranchCargoServiceId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchCargoServiceId with a new GUID
    /// </summary>
    public static BranchCargoServiceId CreateUnique()
    {
        return new BranchCargoServiceId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchCargoServiceId id) => id.Value.ToString();
    public static implicit operator Guid(BranchCargoServiceId id) => id.Value;
}
}
