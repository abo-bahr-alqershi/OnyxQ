using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// ApprovalAppDevice Identifier Value Object
/// </summary>
public sealed class ApprovalAppDeviceId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ApprovalAppDevice
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ApprovalAppDeviceId instance
    /// </summary>
    public ApprovalAppDeviceId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ApprovalAppDeviceId with a new GUID
    /// </summary>
    public static ApprovalAppDeviceId CreateUnique()
    {
        return new ApprovalAppDeviceId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ApprovalAppDeviceId id) => id.Value.ToString();
    public static implicit operator Guid(ApprovalAppDeviceId id) => id.Value;
}
}
