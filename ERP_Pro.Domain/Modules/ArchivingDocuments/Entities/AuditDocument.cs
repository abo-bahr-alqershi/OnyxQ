using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Entities
{
/// <summary>
/// AuditDocument Entity
/// </summary>
public class AuditDocument : Entity<AuditDocumentId>
{

    private AuditDocument() { }

    public AuditDocument(AuditDocumentId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AuditDocument
    /// المعرف الفريد لـ AuditDocument
    /// </summary>
    public AuditDocumentId Id { get; private set; }

    /// <summary>
    /// DocType of the AuditDocument
    /// DocType الخاص بـ AuditDocument
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// JournalVoucherTypeFull of the AuditDocument
    /// JournalVoucherTypeFull الخاص بـ AuditDocument
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// DocNo of the AuditDocument
    /// DocNo الخاص بـ AuditDocument
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the AuditDocument
    /// DocSer الخاص بـ AuditDocument
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the AuditDocument
    /// DocDate الخاص بـ AuditDocument
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AccountCode of the AuditDocument
    /// AccountCode الخاص بـ AuditDocument
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the AuditDocument
    /// AccountDetailCode الخاص بـ AuditDocument
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the AuditDocument
    /// AccountDetailType الخاص بـ AuditDocument
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCurrency of the AuditDocument
    /// AccountCurrency الخاص بـ AuditDocument
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// Amount of the AuditDocument
    /// Amount الخاص بـ AuditDocument
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// AmountForeign of the AuditDocument
    /// AmountForeign الخاص بـ AuditDocument
    /// </summary>
    public decimal? AmountForeign { get; private set; }

    /// <summary>
    /// AuditSequence of the AuditDocument
    /// AuditSequence الخاص بـ AuditDocument
    /// </summary>
    public decimal? AuditSequence { get; private set; }

    /// <summary>
    /// FromUserId of the AuditDocument
    /// FromUserId الخاص بـ AuditDocument
    /// </summary>
    public decimal? FromUserId { get; private set; }

    /// <summary>
    /// ToUserId of the AuditDocument
    /// ToUserId الخاص بـ AuditDocument
    /// </summary>
    public decimal? ToUserId { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the AuditDocument
    /// ProcessedFlagFull الخاص بـ AuditDocument
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// CostCenterCode of the AuditDocument
    /// CostCenterCode الخاص بـ AuditDocument
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the AuditDocument
    /// ProjectNumber الخاص بـ AuditDocument
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the AuditDocument
    /// ActivityNumber الخاص بـ AuditDocument
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// DocDesc of the AuditDocument
    /// DocDesc الخاص بـ AuditDocument
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the AuditDocument
    /// ReferenceNumber الخاص بـ AuditDocument
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CCode of the AuditDocument
    /// CCode الخاص بـ AuditDocument
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// VendorCode of the AuditDocument
    /// VendorCode الخاص بـ AuditDocument
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// DocTypeNo of the AuditDocument
    /// DocTypeNo الخاص بـ AuditDocument
    /// </summary>
    public decimal? DocTypeNo { get; private set; }

    /// <summary>
    /// DocPost of the AuditDocument
    /// DocPost الخاص بـ AuditDocument
    /// </summary>
    public decimal? DocPost { get; private set; }

    /// <summary>
    /// TerminalName of the AuditDocument
    /// TerminalName الخاص بـ AuditDocument
    /// </summary>
    public string TerminalName { get; private set; }

    /// <summary>
    /// AuditReferenceOld of the AuditDocument
    /// AuditReferenceOld الخاص بـ AuditDocument
    /// </summary>
    public decimal? AuditReferenceOld { get; private set; }

    /// <summary>
    /// AuditReference of the AuditDocument
    /// AuditReference الخاص بـ AuditDocument
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the AuditDocument
    /// AuditReferenceDescription الخاص بـ AuditDocument
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the AuditDocument
    /// AuditReferenceUserId الخاص بـ AuditDocument
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the AuditDocument
    /// AuditReferenceDate الخاص بـ AuditDocument
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// WarehouseCode of the AuditDocument
    /// WarehouseCode الخاص بـ AuditDocument
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CashNumber of the AuditDocument
    /// CashNumber الخاص بـ AuditDocument
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// AuditUserId of the AuditDocument
    /// AuditUserId الخاص بـ AuditDocument
    /// </summary>
    public decimal? AuditUserId { get; private set; }

    /// <summary>
    /// AuditDate of the AuditDocument
    /// AuditDate الخاص بـ AuditDocument
    /// </summary>
    public DateTime? AuditDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AuditDocument
    /// CompanyNumberShort الخاص بـ AuditDocument
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AuditDocument
    /// BranchNumber الخاص بـ AuditDocument
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AuditDocument
    /// BranchYear الخاص بـ AuditDocument
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AuditDocument
    /// BranchUser الخاص بـ AuditDocument
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
