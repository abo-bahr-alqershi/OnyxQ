using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل كيان إدارة النقد الرئيسي ويحتوي على جميع خصائص المستندات النقدية الرئيسية
/// </summary>
public class CashManagementMaster : Entity<CashManagementMasterId>
{

    private CashManagementMaster() { }

    public CashManagementMaster(CashManagementMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// معرف فريد للكيان
    /// </summary>
    public CashManagementMasterId Id { get; private set; }

    /// <summary>
    /// رقم المستند
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// رقم تسلسلي للمستند
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// تاريخ المستند
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// وصف المستند
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// موقع رصيد النقدية
    /// </summary>
    public decimal? CashBalanceLocation { get; private set; }

    /// <summary>
    /// فرق المبلغ المحلي
    /// </summary>
    public decimal? DiffAmtLoc { get; private set; }

    /// <summary>
    /// اسم الشخص الأول
    /// </summary>
    public string Person1 { get; private set; }

    /// <summary>
    /// اسم الشخص الثاني
    /// </summary>
    public string Person2 { get; private set; }

    /// <summary>
    /// اسم الشخص الثالث
    /// </summary>
    public string Person3 { get; private set; }

    /// <summary>
    /// اسم الشخص الرابع
    /// </summary>
    public string Person4 { get; private set; }

    /// <summary>
    /// اسم الشخص الخامس
    /// </summary>
    public string Person5 { get; private set; }

    /// <summary>
    /// اسم الشخص السادس
    /// </summary>
    public string Person6 { get; private set; }

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

    #region Navigation Properties
    /// <summary>
    /// علاقة مرجعية مع الحساب (متعدد إلى واحد)
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع النقدية باليد (متعدد إلى واحد)
    /// </summary>
    public HandCash HandCash { get; private set; }
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}
