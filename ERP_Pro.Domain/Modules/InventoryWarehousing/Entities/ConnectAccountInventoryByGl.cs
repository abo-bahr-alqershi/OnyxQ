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

    public ConnectAccountInventoryByGl(ConnectAccountInventoryByGlId id, decimal? postType, string postCode)
    {
        Id = id;
        PostType = postType;
        PostCode = postCode;
    }

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
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account AccountSiACode { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account AccountSrACode { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account AccountDscSiACode { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account AccountDscPiACode { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account AccountCstSiACode { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account AccountCstSrACode { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account AccountPySrACode { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account AccountPyCstSrACode { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account AccountCstFreeSiACode { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account AccountCstFreePiACode { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account AccountCstFreeSrACode { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account AccountPurchaseACode { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account AccountPreRevACode { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
