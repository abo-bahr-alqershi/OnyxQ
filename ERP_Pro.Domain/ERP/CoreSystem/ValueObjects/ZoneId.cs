using ERP_Pro.Domain.Common.Models;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents the unique identifier for a zone.
/// يمثل المعرف الفريد للمنطقة
/// </summary>
public sealed class ZoneId : ValueObject
{
    /// <summary>
    /// Gets the value of the zone ID.
    /// الحصول على قيمة معرف المنطقة
    /// </summary>
    public Guid Value { get; }

    private ZoneId(Guid value)
    {
        Value = value;
    }

    public static ZoneId CreateUnique()
    {
        return new ZoneId(Guid.NewGuid());
    }

    public static ZoneId Create(Guid value)
    {
        return new ZoneId(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
} 