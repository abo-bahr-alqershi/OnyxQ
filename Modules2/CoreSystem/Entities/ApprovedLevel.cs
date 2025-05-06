using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل مستوى الموافقة في النظام ويحدد مستويات الموافقة المطلوبة للعمليات أو المستندات.
public class ApprovedLevel : Entity<ApprovedLevelId>
{
    // المعرف الفريد لمستوى الموافقة (مفتاح رئيسي).
    public ApprovedLevelId Id { get; private set; }

    // ترتيب مستوى الموافقة ضمن التسلسل.
    public int? LevelOrder { get; private set; }

    // اسم مستوى الموافقة.
    public string LevelName { get; private set; }

    // وصف أو ملاحظات حول مستوى الموافقة.
    public string LevelDescription { get; private set; }

    #region Navigation Properties
    // الحركات المرتبطة بهذا المستوى من الموافقة.
    public ICollection<ApprovedMovement> ApprovedMovements { get; private set; }
    #endregion

    private ApprovedLevel() { }

    public ApprovedLevel(ApprovedLevelId id, string levelName)
    {
        Id = id;
        LevelName = levelName;
        ApprovedMovements = new List<ApprovedMovement>();
    }

    #region Methods
    // أضف هنا منطق الدومين الخاص بمستوى الموافقة.
    #endregion
}
}
