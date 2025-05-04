using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CalculateCommissionDetail Entity
/// </summary>
public class CalculateCommissionDetail : Entity<CalculateCommissionDetailId>
{
    private CalculateCommissionDetail() { }

    /// <summary>
    /// The unique identifier for the CalculateCommissionDetail
    /// المعرف الفريد لـ CalculateCommissionDetail
    /// </summary>
    public CalculateCommissionDetailId Id { get; private set; }

    /// <summary>
    /// CommissionNumber of the CalculateCommissionDetail
    /// CommissionNumber الخاص بـ CalculateCommissionDetail
    /// </summary>
    public decimal? CommissionNumber { get; private set; }

    /// <summary>
    /// CCode of the CalculateCommissionDetail
    /// CCode الخاص بـ CalculateCommissionDetail
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// ItemCode of the CalculateCommissionDetail
    /// ItemCode الخاص بـ CalculateCommissionDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the CalculateCommissionDetail
    /// ItemUnit الخاص بـ CalculateCommissionDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the CalculateCommissionDetail
    /// PSize الخاص بـ CalculateCommissionDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// NetSalesAmount of the CalculateCommissionDetail
    /// NetSalesAmount الخاص بـ CalculateCommissionDetail
    /// </summary>
    public decimal? NetSalesAmount { get; private set; }

    /// <summary>
    /// PaymentAmount of the CalculateCommissionDetail
    /// PaymentAmount الخاص بـ CalculateCommissionDetail
    /// </summary>
    public decimal? PaymentAmount { get; private set; }

    /// <summary>
    /// PaymentPercent of the CalculateCommissionDetail
    /// PaymentPercent الخاص بـ CalculateCommissionDetail
    /// </summary>
    public decimal? PaymentPercent { get; private set; }

    /// <summary>
    /// CommissionPercent of the CalculateCommissionDetail
    /// CommissionPercent الخاص بـ CalculateCommissionDetail
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// DueAmt of the CalculateCommissionDetail
    /// DueAmt الخاص بـ CalculateCommissionDetail
    /// </summary>
    public decimal? DueAmt { get; private set; }

    /// <summary>
    /// CClass of the CalculateCommissionDetail
    /// CClass الخاص بـ CalculateCommissionDetail
    /// </summary>
    public string CClass { get; private set; }

    /// <summary>
    /// CommissionSerial of the CalculateCommissionDetail
    /// CommissionSerial الخاص بـ CalculateCommissionDetail
    /// </summary>
    public decimal? CommissionSerial { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CalculateCommissionDetail
    /// CompanyNumberShort الخاص بـ CalculateCommissionDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CalculateCommissionDetail
    /// BranchNumber الخاص بـ CalculateCommissionDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CalculateCommissionDetail
    /// BranchYear الخاص بـ CalculateCommissionDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CalculateCommissionDetail
    /// BranchUser الخاص بـ CalculateCommissionDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemDetail
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CalculateCommissionMaster
    /// </summary>
    public CalculateCommissionMaster CalculateCommissionMaster { get; private set; }
    #endregion
}
}
