using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.SettingsParameters.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesChargeItem Entity
/// </summary>
public class SalesChargeItem : Entity<SalesChargeItemId>
{
    private SalesChargeItem() { }

    /// <summary>
    /// The unique identifier for the SalesChargeItem
    /// المعرف الفريد لـ SalesChargeItem
    /// </summary>
    public SalesChargeItemId Id { get; private set; }

    /// <summary>
    /// ServiceNumber of the SalesChargeItem
    /// ServiceNumber الخاص بـ SalesChargeItem
    /// </summary>
    public decimal? ServiceNumber { get; private set; }

    /// <summary>
    /// CClass of the SalesChargeItem
    /// CClass الخاص بـ SalesChargeItem
    /// </summary>
    public decimal? CClass { get; private set; }

    /// <summary>
    /// CCode of the SalesChargeItem
    /// CCode الخاص بـ SalesChargeItem
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// ItemCode of the SalesChargeItem
    /// ItemCode الخاص بـ SalesChargeItem
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the SalesChargeItem
    /// ItemUnit الخاص بـ SalesChargeItem
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the SalesChargeItem
    /// PSize الخاص بـ SalesChargeItem
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// GuarantorCode of the SalesChargeItem
    /// GuarantorCode الخاص بـ SalesChargeItem
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// Amount of the SalesChargeItem
    /// Amount الخاص بـ SalesChargeItem
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// PeriodAmount of the SalesChargeItem
    /// PeriodAmount الخاص بـ SalesChargeItem
    /// </summary>
    public decimal? PeriodAmount { get; private set; }

    /// <summary>
    /// WarehouseCode of the SalesChargeItem
    /// WarehouseCode الخاص بـ SalesChargeItem
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// SalesInvoiceType of the SalesChargeItem
    /// SalesInvoiceType الخاص بـ SalesChargeItem
    /// </summary>
    public decimal? SalesInvoiceType { get; private set; }

    /// <summary>
    /// FDate of the SalesChargeItem
    /// FDate الخاص بـ SalesChargeItem
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the SalesChargeItem
    /// TDate الخاص بـ SalesChargeItem
    /// </summary>
    public DateTime? TDate { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemDetail
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to SalesCharge
    /// </summary>
    public SalesCharge SalesCharge { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Customer
    /// </summary>
    public Customer Customer { get; private set; }
    /// <summary>
    /// ManyToOne relationship to GroupDetail
    /// </summary>
    public GroupDetail GroupDetail { get; private set; }
    #endregion
}
}
