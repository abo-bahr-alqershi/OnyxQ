using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesDiscountHistory Entity
/// </summary>
public class SalesDiscountHistory : Entity<SalesDiscountHistoryId>
{

    private SalesDiscountHistory() { }

    public SalesDiscountHistory(SalesDiscountHistoryId id, decimal? auditNumber)
    {
        Id = id;
        AuditNumber = auditNumber;
    }

    /// <summary>
    /// The unique identifier for the SalesDiscountHistory
    /// المعرف الفريد لـ SalesDiscountHistory
    /// </summary>
    public SalesDiscountHistoryId Id { get; private set; }

    /// <summary>
    /// AuditNumber of the SalesDiscountHistory
    /// AuditNumber الخاص بـ SalesDiscountHistory
    /// </summary>
    public decimal? AuditNumber { get; private set; }

    /// <summary>
    /// AuditType of the SalesDiscountHistory
    /// AuditType الخاص بـ SalesDiscountHistory
    /// </summary>
    public decimal? AuditType { get; private set; }

    /// <summary>
    /// GuarantorCode of the SalesDiscountHistory
    /// GuarantorCode الخاص بـ SalesDiscountHistory
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// CCode of the SalesDiscountHistory
    /// CCode الخاص بـ SalesDiscountHistory
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CClass of the SalesDiscountHistory
    /// CClass الخاص بـ SalesDiscountHistory
    /// </summary>
    public decimal? CClass { get; private set; }

    /// <summary>
    /// ItemCode of the SalesDiscountHistory
    /// ItemCode الخاص بـ SalesDiscountHistory
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the SalesDiscountHistory
    /// ItemUnit الخاص بـ SalesDiscountHistory
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the SalesDiscountHistory
    /// PSize الخاص بـ SalesDiscountHistory
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// AmountType of the SalesDiscountHistory
    /// AmountType الخاص بـ SalesDiscountHistory
    /// </summary>
    public decimal? AmountType { get; private set; }

    /// <summary>
    /// Amount of the SalesDiscountHistory
    /// Amount الخاص بـ SalesDiscountHistory
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// AccountCurrency of the SalesDiscountHistory
    /// AccountCurrency الخاص بـ SalesDiscountHistory
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the SalesDiscountHistory
    /// AccountRate الخاص بـ SalesDiscountHistory
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// WarehouseCode of the SalesDiscountHistory
    /// WarehouseCode الخاص بـ SalesDiscountHistory
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// WarehouseGroupCode of the SalesDiscountHistory
    /// WarehouseGroupCode الخاص بـ SalesDiscountHistory
    /// </summary>
    public decimal? WarehouseGroupCode { get; private set; }

    /// <summary>
    /// FDate of the SalesDiscountHistory
    /// FDate الخاص بـ SalesDiscountHistory
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the SalesDiscountHistory
    /// TDate الخاص بـ SalesDiscountHistory
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// LevelNumber of the SalesDiscountHistory
    /// LevelNumber الخاص بـ SalesDiscountHistory
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// DocNo of the SalesDiscountHistory
    /// DocNo الخاص بـ SalesDiscountHistory
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocDate of the SalesDiscountHistory
    /// DocDate الخاص بـ SalesDiscountHistory
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// FQuantity of the SalesDiscountHistory
    /// FQuantity الخاص بـ SalesDiscountHistory
    /// </summary>
    public decimal? FQuantity { get; private set; }

    /// <summary>
    /// TQuantity of the SalesDiscountHistory
    /// TQuantity الخاص بـ SalesDiscountHistory
    /// </summary>
    public decimal? TQuantity { get; private set; }

    /// <summary>
    /// DocDesc of the SalesDiscountHistory
    /// DocDesc الخاص بـ SalesDiscountHistory
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the SalesDiscountHistory
    /// BillDocumentTypeFull الخاص بـ SalesDiscountHistory
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BatchNumber of the SalesDiscountHistory
    /// BatchNumber الخاص بـ SalesDiscountHistory
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// AuditUserId of the SalesDiscountHistory
    /// AuditUserId الخاص بـ SalesDiscountHistory
    /// </summary>
    public decimal? AuditUserId { get; private set; }

    /// <summary>
    /// AuditDate of the SalesDiscountHistory
    /// AuditDate الخاص بـ SalesDiscountHistory
    /// </summary>
    public DateTime? AuditDate { get; private set; }

    /// <summary>
    /// BranchNumber of the SalesDiscountHistory
    /// BranchNumber الخاص بـ SalesDiscountHistory
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// CustomerGroupCode of the SalesDiscountHistory
    /// CustomerGroupCode الخاص بـ SalesDiscountHistory
    /// </summary>
    public decimal? CustomerGroupCode { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
