using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.GeneralLedger.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.PurchasingVendors.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.GuaranteesWarranties.Entities;
using ERP_Pro.Domain.ERP.StationsFuel.Entities;
using ERP_Pro.Domain.ERP.TaxFees.Entities;
using ERP_Pro.Domain.ERP.TemporaryTables.Entities;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل الحساب المالي ويحتوي على جميع خصائص الحسابات المالية
/// </summary>
public class Account : Entity<AccountId>
{

    private Account() { }

    public Account(AccountId id, string accountCode)
    {
        Id = id;
        AccountCode = accountCode;
    }

    /// <summary>
    /// معرف فريد للحساب
    /// </summary>
    public AccountId Id { get; private set; }

    /// <summary>
    /// كود الحساب
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// اسم الحساب
    /// </summary>
    public string AccountName { get; private set; }

    /// <summary>
    /// اسم الحساب بالإنجليزية الكامل
    /// </summary>
    public string AccountNameEnglishFull { get; private set; }

    /// <summary>
    /// مستوى الحساب
    /// </summary>
    public decimal? AccountLevel { get; private set; }

    /// <summary>
    /// كود الحساب الأب
    /// </summary>
    public string ParentAccountCode { get; private set; }

    /// <summary>
    /// تحليل الحساب
    /// </summary>
    public decimal? AccountAnalysis { get; private set; }

    /// <summary>
    /// علم إغلاق الحساب
    /// </summary>
    public decimal? AccountCloseFlag { get; private set; }

    /// <summary>
    /// مدين
    /// </summary>
    public decimal? Dr { get; private set; }

    /// <summary>
    /// كود فرق العملة
    /// </summary>
    public string CurdifCode { get; private set; }

    /// <summary>
    /// استخدام مركز التكلفة
    /// </summary>
    public decimal? UseCostCenter { get; private set; }

    /// <summary>
    /// استخدام المشروع
    /// </summary>
    public decimal? UseProject { get; private set; }

    /// <summary>
    /// فترة الربط
    /// </summary>
    public decimal? ConnectionPeriod { get; private set; }

    /// <summary>
    /// علم الحساب المفضل
    /// </summary>
    public decimal? FavoriteAccountFlag { get; private set; }

    /// <summary>
    /// نوع التدفق
    /// </summary>
    public decimal? FlowType { get; private set; }

    /// <summary>
    /// سبب التعطيل
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// تاريخ التعطيل
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// تاريخ آخر إعداد
    /// </summary>
    public DateTime? ConfigLastDate { get; private set; }

    /// <summary>
    /// رقم عملية الحساب
    /// </summary>
    public decimal? AccountOperationNumber { get; private set; }

    /// <summary>
    /// نوع مصروف الحساب
    /// </summary>
    public decimal? AccountExpenseType { get; private set; }

    /// <summary>
    /// استخدام تصدير الفرع
    /// </summary>
    public decimal? UseExportBranch { get; private set; }

    /// <summary>
    /// علم استيراد من إكسل
    /// </summary>
    public decimal? ImportExcelFlag { get; private set; }

    /// <summary>
    /// نوع تفاصيل الحساب
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// استخدام نشط
    /// </summary>
    public decimal? UseActive { get; private set; }

    /// <summary>
    /// علم استخدام TDS
    /// </summary>
    public decimal? UseTdsFlag { get; private set; }

    /// <summary>
    /// علم المصروف/الإيراد المقدم
    /// </summary>
    public decimal? AdvanceExpenseRevenueFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// علاقة مرجعية مع تصنيف الحساب (متعدد إلى واحد)
    /// </summary>
    public AccountClass AccountClass { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع مجموعة الحساب (متعدد إلى واحد)
    /// </summary>
    public AccountGroup AccountGroup { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع نوع تقرير الحساب (متعدد إلى واحد)
    /// </summary>
    public AccountReportType AccountReportType { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع نوع الحساب (متعدد إلى واحد)
    /// </summary>
    public AccountType AccountType { get; private set; }
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}

