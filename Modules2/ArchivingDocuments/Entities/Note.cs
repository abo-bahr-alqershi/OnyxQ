using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

using ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects;
namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Entities
{
/// <summary>
/// Note Entity
/// </summary>
public class Note : Entity<NoteId>
{

    private Note() { }

    public Note(NoteId id, decimal? noteSerial)
    {
        Id = id;
        NoteSerial = noteSerial;
    }

    /// <summary>
    /// The unique identifier for the Note
    /// المعرف الفريد لـ Note
    /// </summary>
    public NoteId Id { get; private set; }

    /// <summary>
    /// NoteType of the Note
    /// NoteType الخاص بـ Note
    /// </summary>
    public decimal? NoteType { get; private set; }

    /// <summary>
    /// NoteTypeNumber of the Note
    /// NoteTypeNumber الخاص بـ Note
    /// </summary>
    public decimal? NoteTypeNumber { get; private set; }

    /// <summary>
    /// NoteNumber of the Note
    /// NoteNumber الخاص بـ Note
    /// </summary>
    public decimal? NoteNumber { get; private set; }

    /// <summary>
    /// NoteSerial of the Note
    /// NoteSerial الخاص بـ Note
    /// </summary>
    public decimal? NoteSerial { get; private set; }

    /// <summary>
    /// NoteDate of the Note
    /// NoteDate الخاص بـ Note
    /// </summary>
    public DateTime? NoteDate { get; private set; }

    /// <summary>
    /// AccountDetailCode of the Note
    /// AccountDetailCode الخاص بـ Note
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the Note
    /// AccountDetailType الخاص بـ Note
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// VendorCode of the Note
    /// VendorCode الخاص بـ Note
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the Note
    /// ProcessedFlagFull الخاص بـ Note
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// ApprovedFlag of the Note
    /// ApprovedFlag الخاص بـ Note
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the Note
    /// ApprovalUserId الخاص بـ Note
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the Note
    /// ApprovalDate الخاص بـ Note
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the Note
    /// ApprovalDescription الخاص بـ Note
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// CostCenterCode of the Note
    /// CostCenterCode الخاص بـ Note
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the Note
    /// ProjectNumber الخاص بـ Note
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the Note
    /// ActivityNumber الخاص بـ Note
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// Field1 of the Note
    /// Field1 الخاص بـ Note
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the Note
    /// Field2 الخاص بـ Note
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the Note
    /// Field3 الخاص بـ Note
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the Note
    /// Field4 الخاص بـ Note
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the Note
    /// Field5 الخاص بـ Note
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the Note
    /// Field6 الخاص بـ Note
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the Note
    /// Field7 الخاص بـ Note
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the Note
    /// Field8 الخاص بـ Note
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the Note
    /// Field9 الخاص بـ Note
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the Note
    /// Field10 الخاص بـ Note
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the Note
    /// CompanyNumberShort الخاص بـ Note
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the Note
    /// BranchNumber الخاص بـ Note
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the Note
    /// BranchYear الخاص بـ Note
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the Note
    /// BranchUser الخاص بـ Note
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the Note
    /// ExternalPostFlag الخاص بـ Note
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Customer Customer { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

