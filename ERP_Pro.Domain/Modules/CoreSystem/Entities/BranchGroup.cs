using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل مجموعة الفروع ويحتوي على معلومات المجموعة وأسمائها.
public class BranchGroup : Entity<BranchGroupId>
{
    // المعرف الفريد لمجموعة الفروع (مفتاح رئيسي).
    public BranchGroupId Id { get; private set; }

    // رقم المجموعة المختصر.
    public decimal? GroupNumberShort { get; private set; }

    // الاسم الأخير للمجموعة.
    public string GroupLastNameShort { get; private set; }

    // الاسم الأول للمجموعة.
    public string GroupFirstNameShort { get; private set; }

    #region Methods
    // أضف هنا منطق الدومين الخاص بمجموعة الفروع
    #endregion
}
}
