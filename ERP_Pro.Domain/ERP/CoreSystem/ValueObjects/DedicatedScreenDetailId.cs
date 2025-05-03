using ERP_Pro.Domain.Common.Models;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents the unique identifier for a dedicated screen detail.
/// يمثل المعرف الفريد لتفاصيل الشاشة المخصصة
/// </summary>
public sealed class DedicatedScreenDetailId : ValueObject
{
    /// <summary>
    /// Gets the value of the dedicated screen detail ID.
    /// الحصول على قيمة معرف تفاصيل الشاشة المخصصة
    /// </summary>
    public Guid Value { get; }

    private DedicatedScreenDetailId(Guid value)
    {
        Value = value;
    }

    public static DedicatedScreenDetailId CreateUnique()
    {
        return new DedicatedScreenDetailId(Guid.NewGuid());
    }

    public static DedicatedScreenDetailId Create(Guid value)
    {
        return new DedicatedScreenDetailId(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
} 