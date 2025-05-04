using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerCurrencyRequest Entity
/// </summary>
public class CustomerCurrencyRequest : Entity<CustomerCurrencyRequestId>
{
    private CustomerCurrencyRequest() { }

    /// <summary>
    /// The unique identifier for the CustomerCurrencyRequest
    /// المعرف الفريد لـ CustomerCurrencyRequest
    /// </summary>
    public CustomerCurrencyRequestId Id { get; private set; }

    /// <summary>
    /// CCode of the CustomerCurrencyRequest
    /// CCode الخاص بـ CustomerCurrencyRequest
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the CustomerCurrencyRequest
    /// AccountCurrency الخاص بـ CustomerCurrencyRequest
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// CreditLimit of the CustomerCurrencyRequest
    /// CreditLimit الخاص بـ CustomerCurrencyRequest
    /// </summary>
    public decimal? CreditLimit { get; private set; }

    /// <summary>
    /// InvoiceLimit of the CustomerCurrencyRequest
    /// InvoiceLimit الخاص بـ CustomerCurrencyRequest
    /// </summary>
    public decimal? InvoiceLimit { get; private set; }

    /// <summary>
    /// LevelNumber of the CustomerCurrencyRequest
    /// LevelNumber الخاص بـ CustomerCurrencyRequest
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// ConfirmLastDate of the CustomerCurrencyRequest
    /// ConfirmLastDate الخاص بـ CustomerCurrencyRequest
    /// </summary>
    public DateTime? ConfirmLastDate { get; private set; }

    /// <summary>
    /// InactiveFlag of the CustomerCurrencyRequest
    /// InactiveFlag الخاص بـ CustomerCurrencyRequest
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// CustomerLimitType of the CustomerCurrencyRequest
    /// CustomerLimitType الخاص بـ CustomerCurrencyRequest
    /// </summary>
    public decimal? CustomerLimitType { get; private set; }

    /// <summary>
    /// CustomerLimitPercent of the CustomerCurrencyRequest
    /// CustomerLimitPercent الخاص بـ CustomerCurrencyRequest
    /// </summary>
    public decimal? CustomerLimitPercent { get; private set; }
}
}
