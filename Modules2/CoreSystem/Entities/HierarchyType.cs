using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل نوع الهيكل التنظيمي ويحتوي على معلومات التصنيفات المختلفة للهيكل.
public class HierarchyType : Entity<HierarchyTypeId>
{
    // المعرف الفريد لنوع الهيكل (مفتاح رئيسي).
    public HierarchyTypeId Id { get; private set; }
    // الرقم المختصر لنوع الهيكل.
    public decimal? TypeNumberShort { get; private set; }
    // الاسم الأخير المختصر لنوع الهيكل.
    public string TypeLastNameShort { get; private set; }
    // الاسم الأول المختصر لنوع الهيكل.
    public string TypeFirstNameShort { get; private set; }
    #region Methods
    // أضف هنا منطق الدومين الخاص بنوع الهيكل التنظيمي
    #endregion
}
}
