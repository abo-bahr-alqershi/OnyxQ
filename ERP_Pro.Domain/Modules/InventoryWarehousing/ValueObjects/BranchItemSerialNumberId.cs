using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// BranchItemSerialNumber Identifier Value Object
/// </summary>
public sealed class BranchItemSerialNumberId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchItemSerialNumber
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchItemSerialNumberId instance
    /// </summary>
    public BranchItemSerialNumberId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchItemSerialNumberId with a new GUID
    /// </summary>
    public static BranchItemSerialNumberId CreateUnique()
    {
        return new BranchItemSerialNumberId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchItemSerialNumberId id) => id.Value.ToString();
    public static implicit operator Guid(BranchItemSerialNumberId id) => id.Value;
}
}
