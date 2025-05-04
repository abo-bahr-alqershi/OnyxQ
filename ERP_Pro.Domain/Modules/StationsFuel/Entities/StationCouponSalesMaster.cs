using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.StationsFuel.Entities
{
/// <summary>
/// StationCouponSalesMaster Entity
/// </summary>
public class StationCouponSalesMaster : Entity<StationCouponSalesMasterId>
{

    private StationCouponSalesMaster() { }

    public StationCouponSalesMaster(StationCouponSalesMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the StationCouponSalesMaster
    /// المعرف الفريد لـ StationCouponSalesMaster
    /// </summary>
    public StationCouponSalesMasterId Id { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the StationCouponSalesMaster
    /// BillDocumentTypeFull الخاص بـ StationCouponSalesMaster
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// DocNo of the StationCouponSalesMaster
    /// DocNo الخاص بـ StationCouponSalesMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the StationCouponSalesMaster
    /// DocSer الخاص بـ StationCouponSalesMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the StationCouponSalesMaster
    /// DocDate الخاص بـ StationCouponSalesMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AccountCurrency of the StationCouponSalesMaster
    /// AccountCurrency الخاص بـ StationCouponSalesMaster
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// CurRate of the StationCouponSalesMaster
    /// CurRate الخاص بـ StationCouponSalesMaster
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// CCode of the StationCouponSalesMaster
    /// CCode الخاص بـ StationCouponSalesMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CName of the StationCouponSalesMaster
    /// CName الخاص بـ StationCouponSalesMaster
    /// </summary>
    public string CName { get; private set; }

    /// <summary>
    /// ReceiptName of the StationCouponSalesMaster
    /// ReceiptName الخاص بـ StationCouponSalesMaster
    /// </summary>
    public string ReceiptName { get; private set; }

    /// <summary>
    /// AccountCode of the StationCouponSalesMaster
    /// AccountCode الخاص بـ StationCouponSalesMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// DocPst of the StationCouponSalesMaster
    /// DocPst الخاص بـ StationCouponSalesMaster
    /// </summary>
    public decimal? DocPst { get; private set; }

    /// <summary>
    /// DocAmt of the StationCouponSalesMaster
    /// DocAmt الخاص بـ StationCouponSalesMaster
    /// </summary>
    public decimal? DocAmt { get; private set; }

    /// <summary>
    /// ReferenceNumber of the StationCouponSalesMaster
    /// ReferenceNumber الخاص بـ StationCouponSalesMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CashNumber of the StationCouponSalesMaster
    /// CashNumber الخاص بـ StationCouponSalesMaster
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the StationCouponSalesMaster
    /// CostCenterCode الخاص بـ StationCouponSalesMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the StationCouponSalesMaster
    /// ProjectNumber الخاص بـ StationCouponSalesMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the StationCouponSalesMaster
    /// ActivityNumber الخاص بـ StationCouponSalesMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// StandByFlag of the StationCouponSalesMaster
    /// StandByFlag الخاص بـ StationCouponSalesMaster
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the StationCouponSalesMaster
    /// ExternalPostFlag الخاص بـ StationCouponSalesMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// VatAmount of the StationCouponSalesMaster
    /// VatAmount الخاص بـ StationCouponSalesMaster
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// PostUserId of the StationCouponSalesMaster
    /// PostUserId الخاص بـ StationCouponSalesMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the StationCouponSalesMaster
    /// PostDate الخاص بـ StationCouponSalesMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the StationCouponSalesMaster
    /// UnpostUserId الخاص بـ StationCouponSalesMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the StationCouponSalesMaster
    /// UnpostDate الخاص بـ StationCouponSalesMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the StationCouponSalesMaster
    /// CompanyNumberShort الخاص بـ StationCouponSalesMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the StationCouponSalesMaster
    /// BranchNumber الخاص بـ StationCouponSalesMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the StationCouponSalesMaster
    /// BranchYear الخاص بـ StationCouponSalesMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the StationCouponSalesMaster
    /// BranchUser الخاص بـ StationCouponSalesMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// FuelTypeNumber of the StationCouponSalesMaster
    /// FuelTypeNumber الخاص بـ StationCouponSalesMaster
    /// </summary>
    public decimal? FuelTypeNumber { get; private set; }

    /// <summary>
    /// IssueDate of the StationCouponSalesMaster
    /// IssueDate الخاص بـ StationCouponSalesMaster
    /// </summary>
    public DateTime? IssueDate { get; private set; }

    /// <summary>
    /// ExpireDate of the StationCouponSalesMaster
    /// ExpireDate الخاص بـ StationCouponSalesMaster
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// ChequeDueDate of the StationCouponSalesMaster
    /// ChequeDueDate الخاص بـ StationCouponSalesMaster
    /// </summary>
    public DateTime? ChequeDueDate { get; private set; }

    /// <summary>
    /// ChequeAmount of the StationCouponSalesMaster
    /// ChequeAmount الخاص بـ StationCouponSalesMaster
    /// </summary>
    public decimal? ChequeAmount { get; private set; }

    /// <summary>
    /// ChequeNumber of the StationCouponSalesMaster
    /// ChequeNumber الخاص بـ StationCouponSalesMaster
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// BillDueDate of the StationCouponSalesMaster
    /// BillDueDate الخاص بـ StationCouponSalesMaster
    /// </summary>
    public DateTime? BillDueDate { get; private set; }

    /// <summary>
    /// AuditReference of the StationCouponSalesMaster
    /// AuditReference الخاص بـ StationCouponSalesMaster
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the StationCouponSalesMaster
    /// AuditReferenceDescription الخاص بـ StationCouponSalesMaster
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the StationCouponSalesMaster
    /// AuditReferenceUserId الخاص بـ StationCouponSalesMaster
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the StationCouponSalesMaster
    /// AuditReferenceDate الخاص بـ StationCouponSalesMaster
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// DocDsc of the StationCouponSalesMaster
    /// DocDsc الخاص بـ StationCouponSalesMaster
    /// </summary>
    public string DocDsc { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
