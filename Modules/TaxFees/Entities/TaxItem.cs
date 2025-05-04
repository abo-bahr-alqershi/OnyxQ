using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.TaxFees.Entities
{
/// <summary>
/// TaxItem Entity
/// </summary>
public class TaxItem : Entity<TaxItemId>
{
    private TaxItem() { }

    /// <summary>
    /// The unique identifier for the TaxItem
    /// المعرف الفريد لـ TaxItem
    /// </summary>
    public TaxItemId Id { get; private set; }

    /// <summary>
    /// ItemCode of the TaxItem
    /// ItemCode الخاص بـ TaxItem
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// TaxNumber of the TaxItem
    /// TaxNumber الخاص بـ TaxItem
    /// </summary>
    public decimal? TaxNumber { get; private set; }

    /// <summary>
    /// AgencyNumber of the TaxItem
    /// AgencyNumber الخاص بـ TaxItem
    /// </summary>
    public decimal? AgencyNumber { get; private set; }

    /// <summary>
    /// TaxPercent of the TaxItem
    /// TaxPercent الخاص بـ TaxItem
    /// </summary>
    public decimal? TaxPercent { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemMaster
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    #endregion
}
}
