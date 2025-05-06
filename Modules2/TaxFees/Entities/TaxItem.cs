using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

using ERP_Pro.Domain.ERP.TaxFees.ValueObjects;
namespace ERP_Pro.Domain.ERP.TaxFees.Entities
{
/// <summary>
/// TaxItem Entity
/// </summary>
public class TaxItem : Entity<TaxItemId>
{

    private TaxItem() { }

    public TaxItem(TaxItemId id, decimal? taxNumber, decimal? agencyNumber)
    {
        Id = id;
        TaxNumber = taxNumber;
        AgencyNumber = agencyNumber;
    }

    /// <summary>
    /// The unique identifier for the TaxItem
    /// المعرف الفريد لـ TaxItem
    /// </summary>
    public TaxItemId Id { get; private set; }

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
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

