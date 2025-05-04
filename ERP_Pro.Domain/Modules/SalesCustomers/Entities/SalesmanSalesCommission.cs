using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesmanSalesCommission Entity
/// </summary>
public class SalesmanSalesCommission : Entity<SalesmanSalesCommissionId>
{

    private SalesmanSalesCommission() { }

    public SalesmanSalesCommission(SalesmanSalesCommissionId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the SalesmanSalesCommission
    /// المعرف الفريد لـ SalesmanSalesCommission
    /// </summary>
    public SalesmanSalesCommissionId Id { get; private set; }

    /// <summary>
    /// RepCode of the SalesmanSalesCommission
    /// RepCode الخاص بـ SalesmanSalesCommission
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// PSize of the SalesmanSalesCommission
    /// PSize الخاص بـ SalesmanSalesCommission
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// CommissionPercent of the SalesmanSalesCommission
    /// CommissionPercent الخاص بـ SalesmanSalesCommission
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
