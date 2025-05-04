using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// BankAdjustmentMaster Entity
/// </summary>
public class BankAdjustmentMaster : Entity<BankAdjustmentMasterId>
{

    private BankAdjustmentMaster() { }

    public BankAdjustmentMaster(BankAdjustmentMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the BankAdjustmentMaster
    /// المعرف الفريد لـ BankAdjustmentMaster
    /// </summary>
    public BankAdjustmentMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the BankAdjustmentMaster
    /// DocNo الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the BankAdjustmentMaster
    /// DocSer الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the BankAdjustmentMaster
    /// DocDate الخاص بـ BankAdjustmentMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// BranchBankNumber of the BankAdjustmentMaster
    /// BranchBankNumber الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? BranchBankNumber { get; private set; }

    /// <summary>
    /// BankBalanceInBank of the BankAdjustmentMaster
    /// BankBalanceInBank الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? BankBalanceInBank { get; private set; }

    /// <summary>
    /// BankBalanceInCompany of the BankAdjustmentMaster
    /// BankBalanceInCompany الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? BankBalanceInCompany { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the BankAdjustmentMaster
    /// ProcessedFlagFull الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// JournalVoucherDocument of the BankAdjustmentMaster
    /// JournalVoucherDocument الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? JournalVoucherDocument { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BankAdjustmentMaster
    /// CompanyNumberShort الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BankAdjustmentMaster
    /// BranchNumber الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BankAdjustmentMaster
    /// BranchYear الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BankAdjustmentMaster
    /// BranchUser الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// TypeNumberShort of the BankAdjustmentMaster
    /// TypeNumberShort الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// ReferenceNumber of the BankAdjustmentMaster
    /// ReferenceNumber الخاص بـ BankAdjustmentMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// ExchangeRate of the BankAdjustmentMaster
    /// ExchangeRate الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? ExchangeRate { get; private set; }

    /// <summary>
    /// StandByFlag of the BankAdjustmentMaster
    /// StandByFlag الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// AttachmentNumber of the BankAdjustmentMaster
    /// AttachmentNumber الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? AttachmentNumber { get; private set; }

    /// <summary>
    /// DocSq of the BankAdjustmentMaster
    /// DocSq الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? DocSq { get; private set; }

    /// <summary>
    /// DocTypRef of the BankAdjustmentMaster
    /// DocTypRef الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? DocTypRef { get; private set; }

    /// <summary>
    /// DocJvTypRef of the BankAdjustmentMaster
    /// DocJvTypRef الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? DocJvTypRef { get; private set; }

    /// <summary>
    /// DocNoRef of the BankAdjustmentMaster
    /// DocNoRef الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSrlRef of the BankAdjustmentMaster
    /// DocSrlRef الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? DocSrlRef { get; private set; }

    /// <summary>
    /// DocSqRef of the BankAdjustmentMaster
    /// DocSqRef الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? DocSqRef { get; private set; }

    /// <summary>
    /// DocDsc of the BankAdjustmentMaster
    /// DocDsc الخاص بـ BankAdjustmentMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// DocPost of the BankAdjustmentMaster
    /// DocPost الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? DocPost { get; private set; }

    /// <summary>
    /// PostUserId of the BankAdjustmentMaster
    /// PostUserId الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the BankAdjustmentMaster
    /// PostDate الخاص بـ BankAdjustmentMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the BankAdjustmentMaster
    /// UnpostUserId الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the BankAdjustmentMaster
    /// UnpostDate الخاص بـ BankAdjustmentMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// AuditReference of the BankAdjustmentMaster
    /// AuditReference الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the BankAdjustmentMaster
    /// AuditReferenceDescription الخاص بـ BankAdjustmentMaster
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the BankAdjustmentMaster
    /// AuditReferenceUserId الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the BankAdjustmentMaster
    /// AuditReferenceDate الخاص بـ BankAdjustmentMaster
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BankAdjustmentMaster
    /// ExternalPostFlag الخاص بـ BankAdjustmentMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CostCenterCode of the BankAdjustmentMaster
    /// CostCenterCode الخاص بـ BankAdjustmentMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BankAdjustmentMaster
    /// ProjectNumber الخاص بـ BankAdjustmentMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the BankAdjustmentMaster
    /// ActivityNumber الخاص بـ BankAdjustmentMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CashAtBankDetail CashAtBankDetail { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
