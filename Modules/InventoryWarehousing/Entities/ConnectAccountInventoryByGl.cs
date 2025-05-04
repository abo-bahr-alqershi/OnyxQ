using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ConnectAccountInventoryByGl Entity
/// </summary>
public class ConnectAccountInventoryByGl : Entity<ConnectAccountInventoryByGlId>
{
    private ConnectAccountInventoryByGl() { }

    /// <summary>
    /// The unique identifier for the ConnectAccountInventoryByGl
    /// المعرف الفريد لـ ConnectAccountInventoryByGl
    /// </summary>
    public ConnectAccountInventoryByGlId Id { get; private set; }

    /// <summary>
    /// PostType of the ConnectAccountInventoryByGl
    /// PostType الخاص بـ ConnectAccountInventoryByGl
    /// </summary>
    public decimal? PostType { get; private set; }

    /// <summary>
    /// PostCode of the ConnectAccountInventoryByGl
    /// PostCode الخاص بـ ConnectAccountInventoryByGl
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// InvoiceAccountCode of the ConnectAccountInventoryByGl
    /// InvoiceAccountCode الخاص بـ ConnectAccountInventoryByGl
    /// </summary>
    public string InvoiceAccountCode { get; private set; }

    /// <summary>
    /// SalesInvoiceAccountCode of the ConnectAccountInventoryByGl
    /// SalesInvoiceAccountCode الخاص بـ ConnectAccountInventoryByGl
    /// </summary>
    public string SalesInvoiceAccountCode { get; private set; }

    /// <summary>
    /// SalesReturnAccountCode of the ConnectAccountInventoryByGl
    /// SalesReturnAccountCode الخاص بـ ConnectAccountInventoryByGl
    /// </summary>
    public string SalesReturnAccountCode { get; private set; }

    /// <summary>
    /// DscSiACode of the ConnectAccountInventoryByGl
    /// DscSiACode الخاص بـ ConnectAccountInventoryByGl
    /// </summary>
    public string DscSiACode { get; private set; }

    /// <summary>
    /// DscPiACode of the ConnectAccountInventoryByGl
    /// DscPiACode الخاص بـ ConnectAccountInventoryByGl
    /// </summary>
    public string DscPiACode { get; private set; }

    /// <summary>
    /// CstSiACode of the ConnectAccountInventoryByGl
    /// CstSiACode الخاص بـ ConnectAccountInventoryByGl
    /// </summary>
    public string CstSiACode { get; private set; }

    /// <summary>
    /// CstSrACode of the ConnectAccountInventoryByGl
    /// CstSrACode الخاص بـ ConnectAccountInventoryByGl
    /// </summary>
    public string CstSrACode { get; private set; }

    /// <summary>
    /// PaymentSerialAccountCode of the ConnectAccountInventoryByGl
    /// PaymentSerialAccountCode الخاص بـ ConnectAccountInventoryByGl
    /// </summary>
    public string PaymentSerialAccountCode { get; private set; }

    /// <summary>
    /// PaymentCustomerSerialAccountCode of the ConnectAccountInventoryByGl
    /// PaymentCustomerSerialAccountCode الخاص بـ ConnectAccountInventoryByGl
    /// </summary>
    public string PaymentCustomerSerialAccountCode { get; private set; }

    /// <summary>
    /// CustomerFreeSalesInvoiceAccountCode of the ConnectAccountInventoryByGl
    /// CustomerFreeSalesInvoiceAccountCode الخاص بـ ConnectAccountInventoryByGl
    /// </summary>
    public string CustomerFreeSalesInvoiceAccountCode { get; private set; }

    /// <summary>
    /// CustomerFreePurchaseInvoiceAccountCode of the ConnectAccountInventoryByGl
    /// CustomerFreePurchaseInvoiceAccountCode الخاص بـ ConnectAccountInventoryByGl
    /// </summary>
    public string CustomerFreePurchaseInvoiceAccountCode { get; private set; }

    /// <summary>
    /// CustomerFreeSalesReturnAccountCode of the ConnectAccountInventoryByGl
    /// CustomerFreeSalesReturnAccountCode الخاص بـ ConnectAccountInventoryByGl
    /// </summary>
    public string CustomerFreeSalesReturnAccountCode { get; private set; }

    /// <summary>
    /// PurchaseAccountCode of the ConnectAccountInventoryByGl
    /// PurchaseAccountCode الخاص بـ ConnectAccountInventoryByGl
    /// </summary>
    public string PurchaseAccountCode { get; private set; }

    /// <summary>
    /// PreviousRevenueAccountCode of the ConnectAccountInventoryByGl
    /// PreviousRevenueAccountCode الخاص بـ ConnectAccountInventoryByGl
    /// </summary>
    public string PreviousRevenueAccountCode { get; private set; }

    /// <summary>
    /// PurchaseServiceAccountCode of the ConnectAccountInventoryByGl
    /// PurchaseServiceAccountCode الخاص بـ ConnectAccountInventoryByGl
    /// </summary>
    public string PurchaseServiceAccountCode { get; private set; }

    /// <summary>
    /// DlySiACode of the ConnectAccountInventoryByGl
    /// DlySiACode الخاص بـ ConnectAccountInventoryByGl
    /// </summary>
    public string DlySiACode { get; private set; }

    /// <summary>
    /// DlyCstSiACode of the ConnectAccountInventoryByGl
    /// DlyCstSiACode الخاص بـ ConnectAccountInventoryByGl
    /// </summary>
    public string DlyCstSiACode { get; private set; }

    /// <summary>
    /// AdvanceSiAccountCode of the ConnectAccountInventoryByGl
    /// AdvanceSiAccountCode الخاص بـ ConnectAccountInventoryByGl
    /// </summary>
    public string AdvanceSiAccountCode { get; private set; }

    /// <summary>
    /// AdvanceSrAccountCode of the ConnectAccountInventoryByGl
    /// AdvanceSrAccountCode الخاص بـ ConnectAccountInventoryByGl
    /// </summary>
    public string AdvanceSrAccountCode { get; private set; }

    /// <summary>
    /// CustomerCompensationSalesInvoiceAccountCode of the ConnectAccountInventoryByGl
    /// CustomerCompensationSalesInvoiceAccountCode الخاص بـ ConnectAccountInventoryByGl
    /// </summary>
    public string CustomerCompensationSalesInvoiceAccountCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Account
    /// </summary>
    public Account Account { get; private set; }
    #endregion
}
}
