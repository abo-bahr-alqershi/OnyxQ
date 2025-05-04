using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SaleCouponMaster Entity
/// </summary>
public class SaleCouponMaster : Entity<SaleCouponMasterId>
{
    private SaleCouponMaster() { }

    /// <summary>
    /// The unique identifier for the SaleCouponMaster
    /// المعرف الفريد لـ SaleCouponMaster
    /// </summary>
    public SaleCouponMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the SaleCouponMaster
    /// DocNo الخاص بـ SaleCouponMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the SaleCouponMaster
    /// DocSer الخاص بـ SaleCouponMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the SaleCouponMaster
    /// DocDate الخاص بـ SaleCouponMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the SaleCouponMaster
    /// BillDocumentTypeFull الخاص بـ SaleCouponMaster
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// AccountCurrency of the SaleCouponMaster
    /// AccountCurrency الخاص بـ SaleCouponMaster
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// CurRate of the SaleCouponMaster
    /// CurRate الخاص بـ SaleCouponMaster
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// CCode of the SaleCouponMaster
    /// CCode الخاص بـ SaleCouponMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CName of the SaleCouponMaster
    /// CName الخاص بـ SaleCouponMaster
    /// </summary>
    public string CName { get; private set; }

    /// <summary>
    /// ReceiptNameShort of the SaleCouponMaster
    /// ReceiptNameShort الخاص بـ SaleCouponMaster
    /// </summary>
    public string ReceiptNameShort { get; private set; }

    /// <summary>
    /// AccountCode of the SaleCouponMaster
    /// AccountCode الخاص بـ SaleCouponMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// DocPst of the SaleCouponMaster
    /// DocPst الخاص بـ SaleCouponMaster
    /// </summary>
    public decimal? DocPst { get; private set; }

    /// <summary>
    /// DocAmt of the SaleCouponMaster
    /// DocAmt الخاص بـ SaleCouponMaster
    /// </summary>
    public decimal? DocAmt { get; private set; }

    /// <summary>
    /// ReferenceNumber of the SaleCouponMaster
    /// ReferenceNumber الخاص بـ SaleCouponMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CashNumber of the SaleCouponMaster
    /// CashNumber الخاص بـ SaleCouponMaster
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the SaleCouponMaster
    /// CostCenterCode الخاص بـ SaleCouponMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the SaleCouponMaster
    /// ProjectNumber الخاص بـ SaleCouponMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the SaleCouponMaster
    /// ActivityNumber الخاص بـ SaleCouponMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ChequeDueDate of the SaleCouponMaster
    /// ChequeDueDate الخاص بـ SaleCouponMaster
    /// </summary>
    public DateTime? ChequeDueDate { get; private set; }

    /// <summary>
    /// ChequeAmount of the SaleCouponMaster
    /// ChequeAmount الخاص بـ SaleCouponMaster
    /// </summary>
    public decimal? ChequeAmount { get; private set; }

    /// <summary>
    /// ChequeNumber of the SaleCouponMaster
    /// ChequeNumber الخاص بـ SaleCouponMaster
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// BillDueDate of the SaleCouponMaster
    /// BillDueDate الخاص بـ SaleCouponMaster
    /// </summary>
    public DateTime? BillDueDate { get; private set; }

    /// <summary>
    /// DocDsc of the SaleCouponMaster
    /// DocDsc الخاص بـ SaleCouponMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// VatAmount of the SaleCouponMaster
    /// VatAmount الخاص بـ SaleCouponMaster
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// StandByFlag of the SaleCouponMaster
    /// StandByFlag الخاص بـ SaleCouponMaster
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the SaleCouponMaster
    /// ExternalPostFlag الخاص بـ SaleCouponMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// DiscPer of the SaleCouponMaster
    /// DiscPer الخاص بـ SaleCouponMaster
    /// </summary>
    public decimal? DiscPer { get; private set; }

    /// <summary>
    /// DiscAmtMst of the SaleCouponMaster
    /// DiscAmtMst الخاص بـ SaleCouponMaster
    /// </summary>
    public decimal? DiscAmtMst { get; private set; }

    /// <summary>
    /// AuditReference of the SaleCouponMaster
    /// AuditReference الخاص بـ SaleCouponMaster
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the SaleCouponMaster
    /// AuditReferenceDescription الخاص بـ SaleCouponMaster
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the SaleCouponMaster
    /// AuditReferenceUserId الخاص بـ SaleCouponMaster
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the SaleCouponMaster
    /// AuditReferenceDate الخاص بـ SaleCouponMaster
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// PostUserId of the SaleCouponMaster
    /// PostUserId الخاص بـ SaleCouponMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the SaleCouponMaster
    /// PostDate الخاص بـ SaleCouponMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the SaleCouponMaster
    /// UnpostUserId الخاص بـ SaleCouponMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the SaleCouponMaster
    /// UnpostDate الخاص بـ SaleCouponMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// Field1 of the SaleCouponMaster
    /// Field1 الخاص بـ SaleCouponMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the SaleCouponMaster
    /// Field2 الخاص بـ SaleCouponMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the SaleCouponMaster
    /// Field3 الخاص بـ SaleCouponMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the SaleCouponMaster
    /// Field4 الخاص بـ SaleCouponMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the SaleCouponMaster
    /// Field5 الخاص بـ SaleCouponMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the SaleCouponMaster
    /// Field6 الخاص بـ SaleCouponMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the SaleCouponMaster
    /// Field7 الخاص بـ SaleCouponMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the SaleCouponMaster
    /// Field8 الخاص بـ SaleCouponMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the SaleCouponMaster
    /// Field9 الخاص بـ SaleCouponMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the SaleCouponMaster
    /// Field10 الخاص بـ SaleCouponMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// CouponType of the SaleCouponMaster
    /// CouponType الخاص بـ SaleCouponMaster
    /// </summary>
    public decimal? CouponType { get; private set; }

    /// <summary>
    /// RepCode of the SaleCouponMaster
    /// RepCode الخاص بـ SaleCouponMaster
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the SaleCouponMaster
    /// CompanyNumberShort الخاص بـ SaleCouponMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the SaleCouponMaster
    /// BranchNumber الخاص بـ SaleCouponMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the SaleCouponMaster
    /// BranchYear الخاص بـ SaleCouponMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the SaleCouponMaster
    /// BranchUser الخاص بـ SaleCouponMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: SaleCouponMaster to SaleCouponDetail
    /// </summary>
    public IReadOnlyCollection<SaleCouponDetail> SaleCouponDetails { get; private set; }
    #endregion
}
}
