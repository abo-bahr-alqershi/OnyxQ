using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل حركة الموافقة في النظام ويحتوي على جميع تفاصيل الموافقة على المستندات المالية أو الإدارية.
public class ApprovedMovement : Entity<ApprovedMovementId>
{
    // المعرف الفريد لحركة الموافقة (مفتاح رئيسي).
    public ApprovedMovementId Id { get; private set; }

    // رقم التسلسل للمستند المرتبط بحركة الموافقة.
    public decimal? DocSer { get; private set; }

    // رقم المستند المرتبط بحركة الموافقة.
    public decimal? DocNo { get; private set; }

    // نوع قيد اليومية للمستند.
    public decimal? DocJvTyp { get; private set; }

    // تاريخ المستند المرتبط بحركة الموافقة.
    public DateTime? DocDate { get; private set; }

    // حالة الموافقة (قيمة مختصرة).
    public decimal? ApprovedFlagShort { get; private set; }

    // تاريخ الموافقة على المستند.
    public DateTime? ApprovedDate { get; private set; }

    // وصف أو ملاحظات حول الموافقة.
    public string ApprovedDescription { get; private set; }

    // رقم الطلب المرتبط بالموافقة (قيمة مختصرة).
    public decimal? OrderNumberShort { get; private set; }

    // رقم الشركة المرتبط بالموافقة (قيمة مختصرة).
    public decimal? CompanyNumberShort { get; private set; }

    // رقم الفرع المرتبط بحركة الموافقة.
    public decimal? BranchNumber { get; private set; }

    // سنة الفرع المرتبطة بحركة الموافقة.
    public decimal? BranchYear { get; private set; }

    // رقم مستخدم الفرع المرتبط بحركة الموافقة.
    public decimal? BranchUser { get; private set; }

    // مبلغ المستند المرتبط بحركة الموافقة.
    public decimal? DocAmt { get; private set; }

    // علم الترحيل الخارجي للموافقة.
    public decimal? ExternalPostFlag { get; private set; }

    #region Navigation Properties
    // مستوى الموافقة المرتبط بهذه الحركة.
    public ApprovedLevel ApprovedLevel { get; private set; }
    // المستخدم الذي قام بالموافقة على الحركة.
    public User User { get; private set; }
    #endregion

    private ApprovedMovement() { }

    public ApprovedMovement(ApprovedMovementId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    #region Methods
    // أضف هنا منطق الدومين الخاص بحركة الموافقة
    #endregion
}
}
