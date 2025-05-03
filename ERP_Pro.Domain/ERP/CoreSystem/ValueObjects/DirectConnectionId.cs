using ERP_Pro.Domain.Common.Models;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents the unique identifier for a direct connection.
/// يمثل المعرف الفريد للاتصال المباشر
/// </summary>
public sealed class DirectConnectionId : ValueObject
{
    /// <summary>
    /// Gets the value of the direct connection ID.
    /// الحصول على قيمة معرف الاتصال المباشر
    /// </summary>
    public Guid Value { get; }

    private DirectConnectionId(Guid value)
    {
        Value = value;
    }

    public static DirectConnectionId CreateUnique()
    {
        return new DirectConnectionId(Guid.NewGuid());
    }

    public static DirectConnectionId Create(Guid value)
    {
        return new DirectConnectionId(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
} 