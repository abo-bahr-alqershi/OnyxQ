using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesCommission Entity
/// </summary>
public class SalesCommission : Entity<SalesCommissionId>
{
    private SalesCommission() { }

    /// <summary>
    /// The unique identifier for the SalesCommission
    /// المعرف الفريد لـ SalesCommission
    /// </summary>
    public SalesCommissionId Id { get; private set; }

    /// <summary>
    /// CCode of the SalesCommission
    /// CCode الخاص بـ SalesCommission
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CClass of the SalesCommission
    /// CClass الخاص بـ SalesCommission
    /// </summary>
    public decimal? CClass { get; private set; }

    /// <summary>
    /// ItemCode of the SalesCommission
    /// ItemCode الخاص بـ SalesCommission
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the SalesCommission
    /// ItemUnit الخاص بـ SalesCommission
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the SalesCommission
    /// PSize الخاص بـ SalesCommission
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// FPayPercent of the SalesCommission
    /// FPayPercent الخاص بـ SalesCommission
    /// </summary>
    public decimal? FPayPercent { get; private set; }

    /// <summary>
    /// TPayPercent of the SalesCommission
    /// TPayPercent الخاص بـ SalesCommission
    /// </summary>
    public decimal? TPayPercent { get; private set; }

    /// <summary>
    /// CommissionPercent of the SalesCommission
    /// CommissionPercent الخاص بـ SalesCommission
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
