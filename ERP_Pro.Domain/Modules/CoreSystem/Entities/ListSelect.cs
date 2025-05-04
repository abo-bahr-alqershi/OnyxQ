using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل كيان اختيار من قائمة ويحتوي على خصائص الاستعلامات والفرز والبحث.
public class ListSelect : Entity<ListSelectId>
{
    // المعرف الفريد لاختيار القائمة (مفتاح رئيسي).
    public ListSelectId Id { get; private set; }
    // اسم العنصر الأخير في القائمة.
    public string LastName { get; private set; }
    // استعلام SQL للعنصر الأخير.
    public string LastSql { get; private set; }
    // شرط where للعنصر الأخير.
    public string LastWhere { get; private set; }
    // ترتيب العنصر الأخير.
    public string LastOrderBy { get; private set; }
    // استعلام SQL سابق للعنصر الأخير.
    public string LastSqlPrevious { get; private set; }
    #region Methods
    // أضف هنا منطق الدومين الخاص باختيار القائمة
    #endregion
}
}
