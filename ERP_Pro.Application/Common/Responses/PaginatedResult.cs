// PaginatedResult.cs
// تم إنشاؤه تلقائيًا.

using System;
using System.Collections.Generic;

namespace ERP_Pro.Application.Common.Responses;

/// <summary>
/// نموذج نتائج مقسمة إلى صفحات
/// </summary>
/// <typeparam name="T">نوع العناصر</typeparam>
public class PaginatedResult<T>
{
    /// <summary>
    /// قائمة العناصر في الصفحة الحالية
    /// </summary>
    public IReadOnlyCollection<T> Items { get; private set; }
    
    /// <summary>
    /// رقم الصفحة الحالية
    /// </summary>
    public int PageNumber { get; private set; }
    
    /// <summary>
    /// حجم الصفحة (عدد العناصر في الصفحة)
    /// </summary>
    public int PageSize { get; private set; }
    
    /// <summary>
    /// إجمالي عدد العناصر
    /// </summary>
    public int TotalCount { get; private set; }
    
    /// <summary>
    /// إجمالي عدد الصفحات
    /// </summary>
    public int TotalPages { get; private set; }
    
    /// <summary>
    /// هل توجد صفحة سابقة
    /// </summary>
    public bool HasPreviousPage => PageNumber > 1;
    
    /// <summary>
    /// هل توجد صفحة تالية
    /// </summary>
    public bool HasNextPage => PageNumber < TotalPages;

    public PaginatedResult(IReadOnlyCollection<T> items, int totalCount, int pageNumber, int pageSize)
    {
        Items = items;
        TotalCount = totalCount;
        PageNumber = pageNumber;
        PageSize = pageSize;
        TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
    }

    /// <summary>
    /// إنشاء نتيجة فارغة
    /// </summary>
    public static PaginatedResult<T> Empty => new PaginatedResult<T>(new List<T>(), 0, 0, 10);

    /// <summary>
    /// تحويل نتيجة مقسمة إلى استجابة
    /// </summary>
    public ResponseResult<PaginatedResult<T>> ToResponseResult(string message = null)
    {
        return ResponseResult<PaginatedResult<T>>.Success(this, message);
    }
}