using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل ملف مكتبة النظام ويحتوي على جميع خصائص الملف وتواريخه.
public class LibraryFile : Entity<LibraryFileId>
{
    // المعرف الفريد لملف المكتبة (مفتاح رئيسي).
    public LibraryFileId Id { get; private set; }
    // اسم الملف.
    public string FileName { get; private set; }
    // إصدار تحديث المكتبة.
    public string LibraryVersionUpdate { get; private set; }
    // تاريخ الإنشاء.
    public DateTime? CreatedDate { get; private set; }
    // تاريخ آخر وصول.
    public DateTime? AccessedDate { get; private set; }
    // تاريخ آخر تعديل.
    public DateTime? ModifiedDate { get; private set; }
    // حجم الملف.
    public decimal? FileSize { get; private set; }
    #region Methods
    // أضف هنا منطق الدومين الخاص بملف المكتبة
    #endregion
}
}
