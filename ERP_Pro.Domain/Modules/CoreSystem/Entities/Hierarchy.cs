using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.HumanResources.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل الهيكل التنظيمي ويحتوي على جميع خصائص الهيكل ومستوياته وعلاقاته.
public class Hierarchy : Entity<HierarchyId>
{
    private Hierarchy() { }

    public Hierarchy(HierarchyId id, decimal? hierarchyNumber)
    {
        Id = id;
        HierarchyNumber = hierarchyNumber;
    }

    // المعرف الفريد للهيكل التنظيمي (مفتاح رئيسي).
    public HierarchyId Id { get; private set; }
    // رقم الهيكل التنظيمي.
    public decimal? HierarchyNumber { get; private set; }
    // الاسم الأخير للهيكل التنظيمي.
    public string HierarchyLastName { get; private set; }
    // الاسم الأول للهيكل التنظيمي.
    public string HierarchyFirstName { get; private set; }
    // الهيكل الأب.
    public decimal? HierarchyParent { get; private set; }
    // رقم المستوى.
    public decimal? LevelNumber { get; private set; }
    // نوع التقييم.
    public decimal? EvaluationType { get; private set; }
    // علم التعطيل.
    public decimal? InactiveFlag { get; private set; }
    // سبب التعطيل.
    public string InactiveReason { get; private set; }
    // معرف المستخدم الذي قام بالتعطيل.
    public decimal? InactivatedByUserId { get; private set; }
    // تاريخ التعطيل.
    public DateTime? InactiveDate { get; private set; }
    // كود الهيكل التنظيمي.
    public string HierarchyCode { get; private set; }

    #region Navigation Properties
    // نوع الهيكل التنظيمي المرتبط.
    public HierarchyType HierarchyType { get; private set; }
    #endregion

    #region Methods
    // أضف هنا منطق الدومين الخاص بالهيكل التنظيمي
    #endregion
}
}
