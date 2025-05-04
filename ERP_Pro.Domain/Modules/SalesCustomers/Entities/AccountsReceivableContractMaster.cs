using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// AccountsReceivableContractMaster Entity
/// </summary>
public class AccountsReceivableContractMaster : Entity<AccountsReceivableContractMasterId>
{

    private AccountsReceivableContractMaster() { }

    public AccountsReceivableContractMaster(AccountsReceivableContractMasterId id, decimal? docSrl)
    {
        Id = id;
        DocSrl = docSrl;
    }

    /// <summary>
    /// The unique identifier for the AccountsReceivableContractMaster
    /// المعرف الفريد لـ AccountsReceivableContractMaster
    /// </summary>
    public AccountsReceivableContractMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the AccountsReceivableContractMaster
    /// DocNo الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSrl of the AccountsReceivableContractMaster
    /// DocSrl الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// ContractNumber of the AccountsReceivableContractMaster
    /// ContractNumber الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public string ContractNumber { get; private set; }

    /// <summary>
    /// ContractDate of the AccountsReceivableContractMaster
    /// ContractDate الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public DateTime? ContractDate { get; private set; }

    /// <summary>
    /// ContractFromDate of the AccountsReceivableContractMaster
    /// ContractFromDate الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public DateTime? ContractFromDate { get; private set; }

    /// <summary>
    /// ContractTransactionDate of the AccountsReceivableContractMaster
    /// ContractTransactionDate الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public DateTime? ContractTransactionDate { get; private set; }

    /// <summary>
    /// CCode of the AccountsReceivableContractMaster
    /// CCode الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CustomerName of the AccountsReceivableContractMaster
    /// CustomerName الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public string CustomerName { get; private set; }

    /// <summary>
    /// ContractAmount of the AccountsReceivableContractMaster
    /// ContractAmount الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? ContractAmount { get; private set; }

    /// <summary>
    /// ContractAccountCurrency of the AccountsReceivableContractMaster
    /// ContractAccountCurrency الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public string ContractAccountCurrency { get; private set; }

    /// <summary>
    /// ContractRate of the AccountsReceivableContractMaster
    /// ContractRate الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? ContractRate { get; private set; }

    /// <summary>
    /// ContractType of the AccountsReceivableContractMaster
    /// ContractType الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? ContractType { get; private set; }

    /// <summary>
    /// ContractDescription of the AccountsReceivableContractMaster
    /// ContractDescription الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public string ContractDescription { get; private set; }

    /// <summary>
    /// ContractNote of the AccountsReceivableContractMaster
    /// ContractNote الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public string ContractNote { get; private set; }

    /// <summary>
    /// ContractRenewAmount of the AccountsReceivableContractMaster
    /// ContractRenewAmount الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? ContractRenewAmount { get; private set; }

    /// <summary>
    /// DiscAmt of the AccountsReceivableContractMaster
    /// DiscAmt الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? DiscAmt { get; private set; }

    /// <summary>
    /// DiscAmtMst of the AccountsReceivableContractMaster
    /// DiscAmtMst الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? DiscAmtMst { get; private set; }

    /// <summary>
    /// DiscAmtDtl of the AccountsReceivableContractMaster
    /// DiscAmtDtl الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? DiscAmtDtl { get; private set; }

    /// <summary>
    /// ContractNoRenew of the AccountsReceivableContractMaster
    /// ContractNoRenew الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public string ContractNoRenew { get; private set; }

    /// <summary>
    /// ContractSerialRenew of the AccountsReceivableContractMaster
    /// ContractSerialRenew الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public string ContractSerialRenew { get; private set; }

    /// <summary>
    /// VatAmount of the AccountsReceivableContractMaster
    /// VatAmount الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// ExportFlag of the AccountsReceivableContractMaster
    /// ExportFlag الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? ExportFlag { get; private set; }

    /// <summary>
    /// ContractStatus of the AccountsReceivableContractMaster
    /// ContractStatus الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? ContractStatus { get; private set; }

    /// <summary>
    /// AmountRemainderNotify of the AccountsReceivableContractMaster
    /// AmountRemainderNotify الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? AmountRemainderNotify { get; private set; }

    /// <summary>
    /// DayExpirNotify of the AccountsReceivableContractMaster
    /// DayExpirNotify الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? DayExpirNotify { get; private set; }

    /// <summary>
    /// AllowExceedAmount of the AccountsReceivableContractMaster
    /// AllowExceedAmount الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? AllowExceedAmount { get; private set; }

    /// <summary>
    /// PeriodExceed of the AccountsReceivableContractMaster
    /// PeriodExceed الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? PeriodExceed { get; private set; }

    /// <summary>
    /// ReferenceNumber of the AccountsReceivableContractMaster
    /// ReferenceNumber الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the AccountsReceivableContractMaster
    /// CostCenterCode الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the AccountsReceivableContractMaster
    /// ProjectNumber الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the AccountsReceivableContractMaster
    /// ActivityNumber الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the AccountsReceivableContractMaster
    /// ProcessedFlagFull الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// InactiveFlag of the AccountsReceivableContractMaster
    /// InactiveFlag الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the AccountsReceivableContractMaster
    /// InactivatedByUserId الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the AccountsReceivableContractMaster
    /// InactiveDate الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the AccountsReceivableContractMaster
    /// InactiveReason الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// ApprovedFlag of the AccountsReceivableContractMaster
    /// ApprovedFlag الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the AccountsReceivableContractMaster
    /// ApprovalUserId الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the AccountsReceivableContractMaster
    /// ApprovalDate الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the AccountsReceivableContractMaster
    /// ApprovalDescription الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AccountsReceivableContractMaster
    /// CompanyNumberShort الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AccountsReceivableContractMaster
    /// BranchNumber الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AccountsReceivableContractMaster
    /// BranchYear الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AccountsReceivableContractMaster
    /// BranchUser الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the AccountsReceivableContractMaster
    /// CalcTypeNumberTax الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// CalcTaxFreeQuantityFlag of the AccountsReceivableContractMaster
    /// CalcTaxFreeQuantityFlag الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? CalcTaxFreeQuantityFlag { get; private set; }

    /// <summary>
    /// AdvancePaymentPercentContract of the AccountsReceivableContractMaster
    /// AdvancePaymentPercentContract الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? AdvancePaymentPercentContract { get; private set; }

    /// <summary>
    /// CreatedDateClock of the AccountsReceivableContractMaster
    /// CreatedDateClock الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public DateTime? CreatedDateClock { get; private set; }

    /// <summary>
    /// CalcVatPriceType of the AccountsReceivableContractMaster
    /// CalcVatPriceType الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? CalcVatPriceType { get; private set; }

    /// <summary>
    /// DiscAmtMstVat of the AccountsReceivableContractMaster
    /// DiscAmtMstVat الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? DiscAmtMstVat { get; private set; }

    /// <summary>
    /// ContractTypeShort of the AccountsReceivableContractMaster
    /// ContractTypeShort الخاص بـ AccountsReceivableContractMaster
    /// </summary>
    public decimal? ContractTypeShort { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
