using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesFreeQuantityHistory Entity
/// </summary>
public class SalesFreeQuantityHistory : Entity<SalesFreeQuantityHistoryId>
{

    private SalesFreeQuantityHistory() { }

    public SalesFreeQuantityHistory(SalesFreeQuantityHistoryId id, decimal? auditNumber)
    {
        Id = id;
        AuditNumber = auditNumber;
    }

    /// <summary>
    /// The unique identifier for the SalesFreeQuantityHistory
    /// المعرف الفريد لـ SalesFreeQuantityHistory
    /// </summary>
    public SalesFreeQuantityHistoryId Id { get; private set; }

    /// <summary>
    /// AuditNumber of the SalesFreeQuantityHistory
    /// AuditNumber الخاص بـ SalesFreeQuantityHistory
    /// </summary>
    public decimal? AuditNumber { get; private set; }

    /// <summary>
    /// AuditType of the SalesFreeQuantityHistory
    /// AuditType الخاص بـ SalesFreeQuantityHistory
    /// </summary>
    public decimal? AuditType { get; private set; }

    /// <summary>
    /// AuditUserId of the SalesFreeQuantityHistory
    /// AuditUserId الخاص بـ SalesFreeQuantityHistory
    /// </summary>
    public decimal? AuditUserId { get; private set; }

    /// <summary>
    /// AuditDate of the SalesFreeQuantityHistory
    /// AuditDate الخاص بـ SalesFreeQuantityHistory
    /// </summary>
    public DateTime? AuditDate { get; private set; }

    /// <summary>
    /// DocNo of the SalesFreeQuantityHistory
    /// DocNo الخاص بـ SalesFreeQuantityHistory
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocDate of the SalesFreeQuantityHistory
    /// DocDate الخاص بـ SalesFreeQuantityHistory
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// GuarantorCode of the SalesFreeQuantityHistory
    /// GuarantorCode الخاص بـ SalesFreeQuantityHistory
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// CCode of the SalesFreeQuantityHistory
    /// CCode الخاص بـ SalesFreeQuantityHistory
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CClass of the SalesFreeQuantityHistory
    /// CClass الخاص بـ SalesFreeQuantityHistory
    /// </summary>
    public decimal? CClass { get; private set; }

    /// <summary>
    /// ItemCode of the SalesFreeQuantityHistory
    /// ItemCode الخاص بـ SalesFreeQuantityHistory
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the SalesFreeQuantityHistory
    /// ItemUnit الخاص بـ SalesFreeQuantityHistory
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the SalesFreeQuantityHistory
    /// PSize الخاص بـ SalesFreeQuantityHistory
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PaymentType of the SalesFreeQuantityHistory
    /// PaymentType الخاص بـ SalesFreeQuantityHistory
    /// </summary>
    public decimal? PaymentType { get; private set; }

    /// <summary>
    /// LowQuantity of the SalesFreeQuantityHistory
    /// LowQuantity الخاص بـ SalesFreeQuantityHistory
    /// </summary>
    public decimal? LowQuantity { get; private set; }

    /// <summary>
    /// PeriodQuantity of the SalesFreeQuantityHistory
    /// PeriodQuantity الخاص بـ SalesFreeQuantityHistory
    /// </summary>
    public decimal? PeriodQuantity { get; private set; }

    /// <summary>
    /// WarehouseCode of the SalesFreeQuantityHistory
    /// WarehouseCode الخاص بـ SalesFreeQuantityHistory
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// WarehouseGroupCode of the SalesFreeQuantityHistory
    /// WarehouseGroupCode الخاص بـ SalesFreeQuantityHistory
    /// </summary>
    public decimal? WarehouseGroupCode { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the SalesFreeQuantityHistory
    /// BillDocumentTypeFull الخاص بـ SalesFreeQuantityHistory
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// FQuantity of the SalesFreeQuantityHistory
    /// FQuantity الخاص بـ SalesFreeQuantityHistory
    /// </summary>
    public decimal? FQuantity { get; private set; }

    /// <summary>
    /// TQuantity of the SalesFreeQuantityHistory
    /// TQuantity الخاص بـ SalesFreeQuantityHistory
    /// </summary>
    public decimal? TQuantity { get; private set; }

    /// <summary>
    /// FDate of the SalesFreeQuantityHistory
    /// FDate الخاص بـ SalesFreeQuantityHistory
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the SalesFreeQuantityHistory
    /// TDate الخاص بـ SalesFreeQuantityHistory
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// BranchNumber of the SalesFreeQuantityHistory
    /// BranchNumber الخاص بـ SalesFreeQuantityHistory
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

