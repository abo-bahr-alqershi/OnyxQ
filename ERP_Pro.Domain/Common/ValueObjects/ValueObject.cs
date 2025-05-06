namespace ERP_Pro.Domain.Common.ValueObjects;

/// <summary>
/// فئة أساسية لكائنات القيمة
/// </summary>
public abstract class ValueObject
{
    /// <summary>
    /// الحصول على مكونات المساواة لهذا الكائن
    /// </summary>
    /// <returns>قائمة بمكونات المساواة</returns>
    protected abstract IEnumerable<object> GetEqualityComponents();

    /// <summary>
    /// التحقق من المساواة بين كائنين
    /// </summary>
    /// <param name="obj">الكائن المراد المقارنة معه</param>
    /// <returns>قيمة منطقية تشير إلى المساواة</returns>
    public override bool Equals(object obj)
    {
        if (obj == null || obj.GetType() != GetType())
        {
            return false;
        }

        var other = (ValueObject)obj;
        return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
    }

    /// <summary>
    /// الحصول على رمز التجزئة للكائن
    /// </summary>
    /// <returns>رمز التجزئة</returns>
    public override int GetHashCode()
    {
        return GetEqualityComponents()
            .Select(x => x != null ? x.GetHashCode() : 0)
            .Aggregate((x, y) => x ^ y);
    }

    /// <summary>
    /// عامل المساواة
    /// </summary>
    /// <param name="left">الكائن الأول</param>
    /// <param name="right">الكائن الثاني</param>
    /// <returns>قيمة منطقية تشير إلى المساواة</returns>
    public static bool operator ==(ValueObject left, ValueObject right)
    {
        if (ReferenceEquals(left, null) && ReferenceEquals(right, null))
            return true;

        if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            return false;

        return left.Equals(right);
    }

    /// <summary>
    /// عامل عدم المساواة
    /// </summary>
    /// <param name="left">الكائن الأول</param>
    /// <param name="right">الكائن الثاني</param>
    /// <returns>قيمة منطقية تشير إلى عدم المساواة</returns>
    public static bool operator !=(ValueObject left, ValueObject right)
    {
        return !(left == right);
    }
} 