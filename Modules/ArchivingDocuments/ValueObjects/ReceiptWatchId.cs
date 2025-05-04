using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects
{
/// <summary>
/// ReceiptWatch Identifier Value Object
/// </summary>
public sealed class ReceiptWatchId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ReceiptWatch
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ReceiptWatchId instance
    /// </summary>
    public ReceiptWatchId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ReceiptWatchId with a new GUID
    /// </summary>
    public static ReceiptWatchId CreateUnique()
    {
        return new ReceiptWatchId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ReceiptWatchId id) => id.Value.ToString();
    public static implicit operator Guid(ReceiptWatchId id) => id.Value;
}
}
