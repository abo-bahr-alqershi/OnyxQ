using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// ExchangeCurrencyMaster Entity
/// </summary>
public class ExchangeCurrencyMaster : Entity<ExchangeCurrencyMasterId>
{

    private ExchangeCurrencyMaster() { }

    public ExchangeCurrencyMaster(ExchangeCurrencyMasterId id, decimal? docSrl)
    {
        Id = id;
        DocSrl = docSrl;
    }

    /// <summary>
    /// The unique identifier for the ExchangeCurrencyMaster
    /// المعرف الفريد لـ ExchangeCurrencyMaster
    /// </summary>
    public ExchangeCurrencyMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the ExchangeCurrencyMaster
    /// DocNo الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSrl of the ExchangeCurrencyMaster
    /// DocSrl الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// AccountCode of the ExchangeCurrencyMaster
    /// AccountCode الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// CurCode of the ExchangeCurrencyMaster
    /// CurCode الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// DocDate of the ExchangeCurrencyMaster
    /// DocDate الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocDsc of the ExchangeCurrencyMaster
    /// DocDsc الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the ExchangeCurrencyMaster
    /// ReferenceNumber الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DocAmtL of the ExchangeCurrencyMaster
    /// DocAmtL الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public decimal? DocAmtL { get; private set; }

    /// <summary>
    /// DocAmtF of the ExchangeCurrencyMaster
    /// DocAmtF الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public decimal? DocAmtF { get; private set; }

    /// <summary>
    /// CurRate of the ExchangeCurrencyMaster
    /// CurRate الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// DocPost of the ExchangeCurrencyMaster
    /// DocPost الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public decimal? DocPost { get; private set; }

    /// <summary>
    /// AccountDetailType of the ExchangeCurrencyMaster
    /// AccountDetailType الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// TypeNumberShort of the ExchangeCurrencyMaster
    /// TypeNumberShort الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// Field1 of the ExchangeCurrencyMaster
    /// Field1 الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the ExchangeCurrencyMaster
    /// Field2 الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the ExchangeCurrencyMaster
    /// Field3 الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the ExchangeCurrencyMaster
    /// Field4 الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the ExchangeCurrencyMaster
    /// Field5 الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the ExchangeCurrencyMaster
    /// Field6 الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the ExchangeCurrencyMaster
    /// Field7 الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the ExchangeCurrencyMaster
    /// Field8 الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the ExchangeCurrencyMaster
    /// Field9 الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the ExchangeCurrencyMaster
    /// Field10 الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// ProductFlag of the ExchangeCurrencyMaster
    /// ProductFlag الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public decimal? ProductFlag { get; private set; }

    /// <summary>
    /// CashBankSerial of the ExchangeCurrencyMaster
    /// CashBankSerial الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public decimal? CashBankSerial { get; private set; }

    /// <summary>
    /// StandbyFlag of the ExchangeCurrencyMaster
    /// StandbyFlag الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public decimal? StandbyFlag { get; private set; }

    /// <summary>
    /// AuditReference of the ExchangeCurrencyMaster
    /// AuditReference الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the ExchangeCurrencyMaster
    /// AuditReferenceDescription الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the ExchangeCurrencyMaster
    /// AuditReferenceUserId الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the ExchangeCurrencyMaster
    /// AuditReferenceDate الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// PostUserId of the ExchangeCurrencyMaster
    /// PostUserId الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the ExchangeCurrencyMaster
    /// PostDate الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the ExchangeCurrencyMaster
    /// UnpostUserId الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the ExchangeCurrencyMaster
    /// UnpostDate الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the ExchangeCurrencyMaster
    /// ExternalPostFlag الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// DocSq of the ExchangeCurrencyMaster
    /// DocSq الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public decimal? DocSq { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ExchangeCurrencyMaster
    /// CompanyNumberShort الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ExchangeCurrencyMaster
    /// BranchNumber الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ExchangeCurrencyMaster
    /// BranchYear الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ExchangeCurrencyMaster
    /// BranchUser الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// StandByFlag of the ExchangeCurrencyMaster
    /// StandByFlag الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// AttachmentNumber of the ExchangeCurrencyMaster
    /// AttachmentNumber الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public decimal? AttachmentNumber { get; private set; }

    /// <summary>
    /// DocBrnNo of the ExchangeCurrencyMaster
    /// DocBrnNo الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// AccountDetailCode of the ExchangeCurrencyMaster
    /// AccountDetailCode الخاص بـ ExchangeCurrencyMaster
    /// </summary>
    public string AccountDetailCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

