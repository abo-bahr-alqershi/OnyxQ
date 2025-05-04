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
    /// ItemCode of the SalesmanSalesCommission
    /// ItemCode الخاص بـ SalesmanSalesCommission
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the SalesmanSalesCommission
    /// ItemUnit الخاص بـ SalesmanSalesCommission
    /// </summary>
    public string ItemUnit { get; private set; }

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
    /// ManyToOne relationship to ItemDetail
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    #endregion
}
}
