using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل نوع الدخل ويحتوي على جميع خصائص أنواع الدخل
/// </summary>
public class IncomeType : Entity<IncomeTypeId>
{

    private IncomeType() { }

    public IncomeType(IncomeTypeId id, decimal? incomeType)
    {
        Id = id;
        IncomeType = incomeType;
    }

    /// <summary>
    /// معرف فريد لنوع الدخل
    /// </summary>
    public IncomeTypeId Id { get; private set; }

    /// <summary>
    /// نوع الدخل
    /// </summary>
    public decimal? IncomeType { get; private set; }

    /// <summary>
    /// اسم الدخل
    /// </summary>
    public string IncomeName { get; private set; }

    /// <summary>
    /// اسم الدخل بالإنجليزية
    /// </summary>
    public string IncomeNameEnglish { get; private set; }

    /// <summary>
    /// سبب الدخل
    /// </summary>
    public decimal? IncomeReason { get; private set; }

    /// <summary>
    /// الربط مع فاتورة الشراء
    /// </summary>
    public decimal? ConnectionWithPurchaseInvoice { get; private set; }

    /// <summary>
    /// التسلسل للدخل
    /// </summary>
    public decimal? IncomeSerial { get; private set; }

    /// <summary>
    /// نوع حساب الضريبة
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}
