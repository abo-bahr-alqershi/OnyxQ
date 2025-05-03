using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a period branch close record in the ERP system
/// يمثل سجل إغلاق فترة الفرع في نظام تخطيط موارد المؤسسات
/// Table name: S_PRD_BRN_CLS
/// </summary>
public class PeriodBranchClose : AuditableEntity
{
    /// <summary>
    /// Gets or sets the period type
    /// نوع الفترة
    /// </summary>
    public int PeriodType { get; private set; }

    /// <summary>
    /// Gets or sets the period number (Primary Key)
    /// رقم الفترة (مفتاح رئيسي)
    /// </summary>
    public int PeriodNumber { get; private set; }

    /// <summary>
    /// Gets or sets the branch number (Primary Key)
    /// رقم الفرع (مفتاح رئيسي)
    /// </summary>
    public int BranchNumber { get; private set; }

    /// <summary>
    /// Gets or sets the from date
    /// من تاريخ
    /// </summary>
    public DateTime FromDate { get; private set; }

    /// <summary>
    /// Gets or sets the to date
    /// إلى تاريخ
    /// </summary>
    public DateTime ToDate { get; private set; }

    /// <summary>
    /// Gets or sets the year number
    /// رقم السنة
    /// </summary>
    public int YearNumber { get; private set; }

    /// <summary>
    /// Gets or sets whether the period is inactive
    /// حالة تعطيل الفترة
    /// </summary>
    public bool IsInactive { get; private set; }

    /// <summary>
    /// Gets or sets whether the period is closed
    /// حالة إغلاق الفترة
    /// </summary>
    public bool IsPeriodClosed { get; private set; }

    /// <summary>
    /// Gets or sets the period close user ID
    /// معرف مستخدم إغلاق الفترة
    /// </summary>
    public int PeriodCloseUserId { get; private set; }

    /// <summary>
    /// Gets or sets the period close date
    /// تاريخ إغلاق الفترة
    /// </summary>
    public DateTime? PeriodCloseDate { get; private set; }

    /// <summary>
    /// Gets or sets the period unclose user ID
    /// معرف مستخدم إلغاء إغلاق الفترة
    /// </summary>
    public int PeriodUncloseUserId { get; private set; }

    /// <summary>
    /// Gets or sets the period unclose date
    /// تاريخ إلغاء إغلاق الفترة
    /// </summary>
    public DateTime? PeriodUncloseDate { get; private set; }

    /// <summary>
    /// Gets or sets the period close count
    /// عدد مرات إغلاق الفترة
    /// </summary>
    public int PeriodCloseCount { get; private set; }

    /// <summary>
    /// Gets or sets whether profit/loss is closed
    /// حالة إغلاق الأرباح والخسائر
    /// </summary>
    public bool IsProfitLossClosed { get; private set; }

    /// <summary>
    /// Gets or sets the profit/loss close count
    /// عدد مرات إغلاق الأرباح والخسائر
    /// </summary>
    public int ProfitLossCloseCount { get; private set; }

    /// <summary>
    /// Gets or sets the profit/loss close user ID
    /// معرف مستخدم إغلاق الأرباح والخسائر
    /// </summary>
    public int ProfitLossCloseUserId { get; private set; }

    /// <summary>
    /// Gets or sets the profit/loss close date
    /// تاريخ إغلاق الأرباح والخسائر
    /// </summary>
    public DateTime? ProfitLossCloseDate { get; private set; }

    /// <summary>
    /// Gets or sets the profit/loss unclose user ID
    /// معرف مستخدم إلغاء إغلاق الأرباح والخسائر
    /// </summary>
    public int ProfitLossUncloseUserId { get; private set; }

    /// <summary>
    /// Gets or sets the profit/loss unclose date
    /// تاريخ إلغاء إغلاق الأرباح والخسائر
    /// </summary>
    public DateTime? ProfitLossUncloseDate { get; private set; }

    /// <summary>
    /// Gets or sets whether inventory is closed
    /// حالة إغلاق المخزون
    /// </summary>
    public bool IsInventoryClosed { get; private set; }

    /// <summary>
    /// Gets or sets the inventory close user ID
    /// معرف مستخدم إغلاق المخزون
    /// </summary>
    public int InventoryCloseUserId { get; private set; }

    /// <summary>
    /// Gets or sets the inventory close date
    /// تاريخ إغلاق المخزون
    /// </summary>
    public DateTime? InventoryCloseDate { get; private set; }

    /// <summary>
    /// Gets or sets the inventory close count
    /// عدد مرات إغلاق المخزون
    /// </summary>
    public int InventoryCloseCount { get; private set; }

    /// <summary>
    /// Gets or sets the inventory unclose user ID
    /// معرف مستخدم إلغاء إغلاق المخزون
    /// </summary>
    public int InventoryUncloseUserId { get; private set; }

    /// <summary>
    /// Gets or sets the inventory unclose date
    /// تاريخ إلغاء إغلاق المخزون
    /// </summary>
    public DateTime? InventoryUncloseDate { get; private set; }

    /// <summary>
    /// Gets or sets whether depreciation is closed
    /// حالة إغلاق الإهلاك
    /// </summary>
    public bool IsDepreciationClosed { get; private set; }

    /// <summary>
    /// Gets or sets the depreciation close user ID
    /// معرف مستخدم إغلاق الإهلاك
    /// </summary>
    public int DepreciationCloseUserId { get; private set; }

    /// <summary>
    /// Gets or sets the depreciation close date
    /// تاريخ إغلاق الإهلاك
    /// </summary>
    public DateTime? DepreciationCloseDate { get; private set; }

    /// <summary>
    /// Gets or sets the depreciation close count
    /// عدد مرات إغلاق الإهلاك
    /// </summary>
    public int DepreciationCloseCount { get; private set; }

    /// <summary>
    /// Gets or sets the depreciation unclose user ID
    /// معرف مستخدم إلغاء إغلاق الإهلاك
    /// </summary>
    public int DepreciationUncloseUserId { get; private set; }

    /// <summary>
    /// Gets or sets the depreciation unclose date
    /// تاريخ إلغاء إغلاق الإهلاك
    /// </summary>
    public DateTime? DepreciationUncloseDate { get; private set; }

    /// <summary>
    /// Gets or sets whether MRP is closed
    /// حالة إغلاق تخطيط موارد التصنيع
    /// </summary>
    public bool IsMrpClosed { get; private set; }

    /// <summary>
    /// Gets or sets the MRP close count
    /// عدد مرات إغلاق تخطيط موارد التصنيع
    /// </summary>
    public int MrpCloseCount { get; private set; }

    /// <summary>
    /// Gets or sets the MRP close user ID
    /// معرف مستخدم إغلاق تخطيط موارد التصنيع
    /// </summary>
    public int MrpCloseUserId { get; private set; }

    /// <summary>
    /// Gets or sets the MRP close date
    /// تاريخ إغلاق تخطيط موارد التصنيع
    /// </summary>
    public DateTime? MrpCloseDate { get; private set; }

    /// <summary>
    /// Gets or sets the MRP unclose user ID
    /// معرف مستخدم إلغاء إغلاق تخطيط موارد التصنيع
    /// </summary>
    public int MrpUncloseUserId { get; private set; }

    /// <summary>
    /// Gets or sets the MRP unclose date
    /// تاريخ إلغاء إغلاق تخطيط موارد التصنيع
    /// </summary>
    public DateTime? MrpUncloseDate { get; private set; }

    /// <summary>
    /// Gets or sets the fixed assets period
    /// فترة الأصول الثابتة
    /// </summary>
    public int FixedAssetsPeriod { get; private set; }

    /// <summary>
    /// Gets or sets the update user ID
    /// معرف مستخدم التحديث
    /// </summary>
    public int UpdateUserId { get; private set; }

    /// <summary>
    /// Gets or sets the update date
    /// تاريخ التحديث
    /// </summary>
    public DateTime UpdateDate { get; private set; }

    /// <summary>
    /// Gets or sets the update count
    /// عدد مرات التحديث
    /// </summary>
    public int UpdateCount { get; private set; }

    /// <summary>
    /// Gets or sets the profit/loss account code close
    /// رمز حساب إغلاق الأرباح والخسائر
    /// </summary>
    public string ProfitLossAccountCodeClose { get; private set; }

    /// <summary>
    /// Gets or sets the profit/loss amount close
    /// مبلغ إغلاق الأرباح والخسائر
    /// </summary>
    public decimal ProfitLossAmountClose { get; private set; }

    /// <summary>
    /// Gets or sets whether reverse is closed
    /// حالة إغلاق العكس
    /// </summary>
    public bool IsReverseClosed { get; private set; }

    /// <summary>
    /// Gets or sets the reverse from date close
    /// تاريخ بداية إغلاق العكس
    /// </summary>
    public DateTime? ReverseFromDateClose { get; private set; }

    /// <summary>
    /// Gets or sets the reverse to date close
    /// تاريخ نهاية إغلاق العكس
    /// </summary>
    public DateTime? ReverseToDateClose { get; private set; }

    /// <summary>
    /// Gets or sets whether currency difference is closed
    /// حالة إغلاق فرق العملة
    /// </summary>
    public bool IsCurrencyDifferenceClosed { get; private set; }

    /// <summary>
    /// Gets or sets whether currency difference with cost center is closed
    /// حالة إغلاق فرق العملة مع مركز التكلفة
    /// </summary>
    public bool IsCurrencyDifferenceWithCostCenterClosed { get; private set; }

    /// <summary>
    /// Gets or sets whether currency difference with project is closed
    /// حالة إغلاق فرق العملة مع المشروع
    /// </summary>
    public bool IsCurrencyDifferenceWithProjectClosed { get; private set; }

    /// <summary>
    /// Gets or sets whether currency difference with activity is closed
    /// حالة إغلاق فرق العملة مع النشاط
    /// </summary>
    public bool IsCurrencyDifferenceWithActivityClosed { get; private set; }

    /// <summary>
    /// Gets or sets the currency rate flag close
    /// علم سعر العملة للإغلاق
    /// </summary>
    public int CurrencyRateFlagClose { get; private set; }

    /// <summary>
    /// Gets or sets the currency rate type flag close
    /// علم نوع سعر العملة للإغلاق
    /// </summary>
    public int CurrencyRateTypeFlagClose { get; private set; }

    /// <summary>
    /// Gets or sets the period master reference
    /// مرجع رئيسي الفترة
    /// </summary>
    public virtual 
     PeriodMaster { get; private set; }

    #region Constructors

    private PeriodBranchClose() { }

    public PeriodBranchClose(
        int periodType,
        int periodNumber,
        int branchNumber,
        DateTime fromDate,
        DateTime toDate,
        int yearNumber)
    {
        PeriodType = periodType;
        PeriodNumber = periodNumber;
        BranchNumber = branchNumber;
        FromDate = fromDate;
        ToDate = toDate;
        YearNumber = yearNumber;

        AddDomainEvent(new PeriodBranchCloseCreatedEvent(this));
    }

    #endregion

    #region Methods

    public void ClosePeriod(int userId)
    {
        if (IsPeriodClosed)
            throw new InvalidOperationException("Period is already closed");

        IsPeriodClosed = true;
        PeriodCloseUserId = userId;
        PeriodCloseDate = DateTime.Now;
        PeriodCloseCount++;

        AddDomainEvent(new PeriodBranchClosedEvent(this));
    }

    public void UnclosePeriod(int userId)
    {
        if (!IsPeriodClosed)
            throw new InvalidOperationException("Period is not closed");

        IsPeriodClosed = false;
        PeriodUncloseUserId = userId;
        PeriodUncloseDate = DateTime.Now;

        AddDomainEvent(new PeriodBranchUnclosedEvent(this));
    }

    public void CloseProfitLoss(int userId, string accountCode, decimal amount)
    {
        if (IsProfitLossClosed)
            throw new InvalidOperationException("Profit/Loss is already closed");

        IsProfitLossClosed = true;
        ProfitLossCloseUserId = userId;
        ProfitLossCloseDate = DateTime.Now;
        ProfitLossCloseCount++;
        ProfitLossAccountCodeClose = accountCode;
        ProfitLossAmountClose = amount;

        AddDomainEvent(new PeriodBranchProfitLossClosedEvent(this));
    }

    public void UncloseProfitLoss(int userId)
    {
        if (!IsProfitLossClosed)
            throw new InvalidOperationException("Profit/Loss is not closed");

        IsProfitLossClosed = false;
        ProfitLossUncloseUserId = userId;
        ProfitLossUncloseDate = DateTime.Now;

        AddDomainEvent(new PeriodBranchProfitLossUnclosedEvent(this));
    }

    public void CloseInventory(int userId)
    {
        if (IsInventoryClosed)
            throw new InvalidOperationException("Inventory is already closed");

        IsInventoryClosed = true;
        InventoryCloseUserId = userId;
        InventoryCloseDate = DateTime.Now;
        InventoryCloseCount++;

        AddDomainEvent(new PeriodBranchInventoryClosedEvent(this));
    }

    public void UncloseInventory(int userId)
    {
        if (!IsInventoryClosed)
            throw new InvalidOperationException("Inventory is not closed");

        IsInventoryClosed = false;
        InventoryUncloseUserId = userId;
        InventoryUncloseDate = DateTime.Now;

        AddDomainEvent(new PeriodBranchInventoryUnclosedEvent(this));
    }

    public void CloseDepreciation(int userId)
    {
        if (IsDepreciationClosed)
            throw new InvalidOperationException("Depreciation is already closed");

        IsDepreciationClosed = true;
        DepreciationCloseUserId = userId;
        DepreciationCloseDate = DateTime.Now;
        DepreciationCloseCount++;

        AddDomainEvent(new PeriodBranchDepreciationClosedEvent(this));
    }

    public void UncloseDepreciation(int userId)
    {
        if (!IsDepreciationClosed)
            throw new InvalidOperationException("Depreciation is not closed");

        IsDepreciationClosed = false;
        DepreciationUncloseUserId = userId;
        DepreciationUncloseDate = DateTime.Now;

        AddDomainEvent(new PeriodBranchDepreciationUnclosedEvent(this));
    }

    public void CloseMrp(int userId)
    {
        if (IsMrpClosed)
            throw new InvalidOperationException("MRP is already closed");

        IsMrpClosed = true;
        MrpCloseUserId = userId;
        MrpCloseDate = DateTime.Now;
        MrpCloseCount++;

        AddDomainEvent(new PeriodBranchMrpClosedEvent(this));
    }

    public void UncloseMrp(int userId)
    {
        if (!IsMrpClosed)
            throw new InvalidOperationException("MRP is not closed");

        IsMrpClosed = false;
        MrpUncloseUserId = userId;
        MrpUncloseDate = DateTime.Now;

        AddDomainEvent(new PeriodBranchMrpUnclosedEvent(this));
    }

    public void UpdateCurrencySettings(
        bool isCurrencyDifferenceClosed,
        bool isCurrencyDifferenceWithCostCenterClosed,
        bool isCurrencyDifferenceWithProjectClosed,
        bool isCurrencyDifferenceWithActivityClosed,
        int currencyRateFlagClose,
        int currencyRateTypeFlagClose)
    {
        IsCurrencyDifferenceClosed = isCurrencyDifferenceClosed;
        IsCurrencyDifferenceWithCostCenterClosed = isCurrencyDifferenceWithCostCenterClosed;
        IsCurrencyDifferenceWithProjectClosed = isCurrencyDifferenceWithProjectClosed;
        IsCurrencyDifferenceWithActivityClosed = isCurrencyDifferenceWithActivityClosed;
        CurrencyRateFlagClose = currencyRateFlagClose;
        CurrencyRateTypeFlagClose = currencyRateTypeFlagClose;

        AddDomainEvent(new PeriodBranchCurrencySettingsUpdatedEvent(this));
    }

    #endregion
} 