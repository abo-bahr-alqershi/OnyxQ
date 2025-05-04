using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل نوع تقرير الحساب ويحتوي على جميع خصائص أنواع تقارير الحسابات
/// </summary>
public class AccountReportType : Entity<AccountReportTypeId>
{

    private AccountReportType() { }

    public AccountReportType(AccountReportTypeId id, decimal? reportType)
    {
        Id = id;
        ReportType = reportType;
    }

    /// <summary>
    /// معرف فريد لنوع تقرير الحساب
    /// </summary>
    public AccountReportTypeId Id { get; private set; }

    /// <summary>
    /// نوع التقرير
    /// </summary>
    public decimal? ReportType { get; private set; }

    /// <summary>
    /// اسم التقرير
    /// </summary>
    public string ReportName { get; private set; }

    /// <summary>
    /// اسم التقرير بالإنجليزية
    /// </summary>
    public string ReportNameEnglish { get; private set; }

    /// <summary>
    /// تقرير الميزانية العمومية
    /// </summary>
    public decimal? ReportBalanceSheet { get; private set; }

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}
