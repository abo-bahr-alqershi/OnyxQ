using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;
using ERP_Pro.Domain.ERP.GeneralLedger.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.PurchasingVendors.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.ProductionManufacturing.Entities;
using ERP_Pro.Domain.ERP.GuaranteesWarranties.Entities;
using ERP_Pro.Domain.ERP.ArchivingDocuments.Entities;
using ERP_Pro.Domain.ERP.FormsSurveys.Entities;
using ERP_Pro.Domain.ERP.SettingsParameters.Entities;
using ERP_Pro.Domain.ERP.JudicialLegal.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// AccountCurrency Entity
/// الكلاس يمثل عملة الحساب ويحتوي على جميع خصائص عملات الحسابات
/// </summary>
public class AccountCurrency : Entity<AccountCurrencyId>
{

    private AccountCurrency() { }

    public AccountCurrency(AccountCurrencyId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AccountCurrency
    /// المعرف الفريد لـ AccountCurrency
    /// معرف فريد لعملة الحساب
    /// </summary>
    public AccountCurrencyId Id { get; private set; }

    /// <summary>
    /// InactiveFlag of the AccountCurrency
    /// InactiveFlag الخاص بـ AccountCurrency
    /// علم التعطيل
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// UsedFlag of the AccountCurrency
    /// UsedFlag الخاص بـ AccountCurrency
    /// علم الاستخدام
    /// </summary>
    public decimal? UsedFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// علاقة مرجعية مع الحساب (متعدد إلى واحد)
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// علاقة مرجعية مع سعر الصرف (متعدد إلى واحد)
    /// </summary>
    public ExchangeRate ExchangeRate { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    // توضع هنا دوال منطق الدومين
    #endregion
}
}
