using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects
{
/// <summary>
/// ExternalSystemSyncLog Identifier Value Object
/// </summary>
public sealed class ExternalSystemSyncLogId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ExternalSystemSyncLog
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ExternalSystemSyncLogId instance
    /// </summary>
    public ExternalSystemSyncLogId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ExternalSystemSyncLogId with a new GUID
    /// </summary>
    public static ExternalSystemSyncLogId CreateUnique()
    {
        return new ExternalSystemSyncLogId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ExternalSystemSyncLogId id) => id.Value.ToString();
    public static implicit operator Guid(ExternalSystemSyncLogId id) => id.Value;
}
}
