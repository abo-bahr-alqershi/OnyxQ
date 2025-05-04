using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل الاتصال المباشر ويحتوي على خصائص الاتصال المباشر بين الكيانات أو الأنظمة.
public class DirectConnection : Entity<DirectConnectionId>
{
    // المعرف الفريد للاتصال المباشر (مفتاح رئيسي).
    public DirectConnectionId Id { get; private set; }
    // نوع الاتصال المباشر.
    public decimal? SType { get; private set; }
    // كود الاتصال المباشر.
    public string DirCode { get; private set; }
    // كود الاتصال الخارجي.
    public string DirCodeExtrnl { get; private set; }
    // وصف الاتصال المباشر.
    public string TDescription { get; private set; }
    // رقم الشركة المختصر.
    public decimal? CompanyNumberShort { get; private set; }
    // رقم الفرع.
    public decimal? BranchNumber { get; private set; }
    // سنة الفرع.
    public decimal? BranchYear { get; private set; }
    // المستخدم المسؤول عن الفرع.
    public decimal? BranchUser { get; private set; }
    #region Methods
    // أضف هنا منطق الدومين الخاص بالاتصال المباشر
    #endregion
}
}
