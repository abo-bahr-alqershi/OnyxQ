using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.GeneralLedger.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.PurchasingVendors.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.ProductionManufacturing.Entities;
using ERP_Pro.Domain.ERP.HumanResources.Entities;
using ERP_Pro.Domain.ERP.GuaranteesWarranties.Entities;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// ExchangeRate Entity
/// </summary>
public class ExchangeRate : Entity<ExchangeRateId>
{

    private ExchangeRate() { }

    public ExchangeRate(ExchangeRateId id, string curCode)
    {
        Id = id;
        CurCode = curCode;
    }

    /// <summary>
    /// The unique identifier for the ExchangeRate
    /// المعرف الفريد لـ ExchangeRate
    /// </summary>
    public ExchangeRateId Id { get; private set; }

    /// <summary>
    /// CurNo of the ExchangeRate
    /// CurNo الخاص بـ ExchangeRate
    /// </summary>
    public decimal? CurNo { get; private set; }

    /// <summary>
    /// CurCode of the ExchangeRate
    /// CurCode الخاص بـ ExchangeRate
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// CurName of the ExchangeRate
    /// CurName الخاص بـ ExchangeRate
    /// </summary>
    public string CurName { get; private set; }

    /// <summary>
    /// CurEName of the ExchangeRate
    /// CurEName الخاص بـ ExchangeRate
    /// </summary>
    public string CurEName { get; private set; }

    /// <summary>
    /// CurRate of the ExchangeRate
    /// CurRate الخاص بـ ExchangeRate
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// CurRatePos of the ExchangeRate
    /// CurRatePos الخاص بـ ExchangeRate
    /// </summary>
    public decimal? CurRatePos { get; private set; }

    /// <summary>
    /// CurFraction of the ExchangeRate
    /// CurFraction الخاص بـ ExchangeRate
    /// </summary>
    public string CurFraction { get; private set; }

    /// <summary>
    /// CurEFraction of the ExchangeRate
    /// CurEFraction الخاص بـ ExchangeRate
    /// </summary>
    public string CurEFraction { get; private set; }

    /// <summary>
    /// LFField of the ExchangeRate
    /// LFField الخاص بـ ExchangeRate
    /// </summary>
    public decimal? LFField { get; private set; }

    /// <summary>
    /// StockCurrency of the ExchangeRate
    /// StockCurrency الخاص بـ ExchangeRate
    /// </summary>
    public decimal? StockCurrency { get; private set; }

    /// <summary>
    /// MaxCurrencyRate of the ExchangeRate
    /// MaxCurrencyRate الخاص بـ ExchangeRate
    /// </summary>
    public decimal? MaxCurrencyRate { get; private set; }

    /// <summary>
    /// MinCurrencyRate of the ExchangeRate
    /// MinCurrencyRate الخاص بـ ExchangeRate
    /// </summary>
    public decimal? MinCurrencyRate { get; private set; }

    /// <summary>
    /// CurFrcNo of the ExchangeRate
    /// CurFrcNo الخاص بـ ExchangeRate
    /// </summary>
    public decimal? CurFrcNo { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

