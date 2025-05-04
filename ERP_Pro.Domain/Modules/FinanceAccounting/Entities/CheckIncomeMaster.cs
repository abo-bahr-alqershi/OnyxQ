using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل مستند دخل الشيكات ويحتوي على جميع خصائص مستندات دخل الشيكات
/// </summary>
public class CheckIncomeMaster : Entity<CheckIncomeMasterId>
{

    private CheckIncomeMaster() { }

    public CheckIncomeMaster(CheckIncomeMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// معرف فريد لمستند دخل الشيكات
    /// </summary>
    public CheckIncomeMasterId Id { get; private set; }

    /// <summary>
    /// رقم المستند
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// رقم تسلسلي للمستند
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// نوع المستند
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// تاريخ المستند
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// كود تفاصيل الحساب
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// نوع تفاصيل الحساب
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// كود المورد
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// اسم المورد
    /// </summary>
    public string VendorName { get; private set; }

    /// <summary>
    /// كود المستودع
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// رقم المرجع
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// وصف المستند
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// كود مركز التكلفة
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// رقم المشروع
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// رقم النشاط
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// حالة المعالجة
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// رقم الشركة المختصر
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// رقم الفرع
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// سنة الفرع
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// مستخدم الفرع
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}
