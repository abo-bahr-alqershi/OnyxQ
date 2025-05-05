using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// AccountsPayableContractMaster Entity
/// </summary>
public class AccountsPayableContractMaster : AggregateRoot<AccountsPayableContractMasterId>
{

    private AccountsPayableContractMaster() { }

    public AccountsPayableContractMaster(AccountsPayableContractMasterId id, string contractSerial)
    {
        Id = id;
        ContractSerial = contractSerial;
    }

    /// <summary>
    /// The unique identifier for the AccountsPayableContractMaster
    /// المعرف الفريد لـ AccountsPayableContractMaster
    /// </summary>
    public AccountsPayableContractMasterId Id { get; private set; }

    /// <summary>
    /// ContractNumber of the AccountsPayableContractMaster
    /// ContractNumber الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public string ContractNumber { get; private set; }

    /// <summary>
    /// ContractSerial of the AccountsPayableContractMaster
    /// ContractSerial الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public string ContractSerial { get; private set; }

    /// <summary>
    /// ContractDate of the AccountsPayableContractMaster
    /// ContractDate الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public DateTime? ContractDate { get; private set; }

    /// <summary>
    /// ContractFromDate of the AccountsPayableContractMaster
    /// ContractFromDate الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public DateTime? ContractFromDate { get; private set; }

    /// <summary>
    /// ContractTransactionDate of the AccountsPayableContractMaster
    /// ContractTransactionDate الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public DateTime? ContractTransactionDate { get; private set; }

    /// <summary>
    /// VendorCode of the AccountsPayableContractMaster
    /// VendorCode الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// VendorName of the AccountsPayableContractMaster
    /// VendorName الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public string VendorName { get; private set; }

    /// <summary>
    /// ContractAmount of the AccountsPayableContractMaster
    /// ContractAmount الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public decimal? ContractAmount { get; private set; }

    /// <summary>
    /// ContractAccountCurrency of the AccountsPayableContractMaster
    /// ContractAccountCurrency الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public string ContractAccountCurrency { get; private set; }

    /// <summary>
    /// ContractRate of the AccountsPayableContractMaster
    /// ContractRate الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public decimal? ContractRate { get; private set; }

    /// <summary>
    /// ContractType of the AccountsPayableContractMaster
    /// ContractType الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public decimal? ContractType { get; private set; }

    /// <summary>
    /// ContractDescription of the AccountsPayableContractMaster
    /// ContractDescription الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public string ContractDescription { get; private set; }

    /// <summary>
    /// ContractNote of the AccountsPayableContractMaster
    /// ContractNote الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public string ContractNote { get; private set; }

    /// <summary>
    /// ContractRenewAmount of the AccountsPayableContractMaster
    /// ContractRenewAmount الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public decimal? ContractRenewAmount { get; private set; }

    /// <summary>
    /// AmountRemainderNotify of the AccountsPayableContractMaster
    /// AmountRemainderNotify الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public decimal? AmountRemainderNotify { get; private set; }

    /// <summary>
    /// DayExpirNotify of the AccountsPayableContractMaster
    /// DayExpirNotify الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public decimal? DayExpirNotify { get; private set; }

    /// <summary>
    /// AllowExceedAmount of the AccountsPayableContractMaster
    /// AllowExceedAmount الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public decimal? AllowExceedAmount { get; private set; }

    /// <summary>
    /// PeriodExceed of the AccountsPayableContractMaster
    /// PeriodExceed الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public decimal? PeriodExceed { get; private set; }

    /// <summary>
    /// ReferenceNumber of the AccountsPayableContractMaster
    /// ReferenceNumber الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DiscAmt of the AccountsPayableContractMaster
    /// DiscAmt الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public decimal? DiscAmt { get; private set; }

    /// <summary>
    /// DiscAmtMst of the AccountsPayableContractMaster
    /// DiscAmtMst الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public decimal? DiscAmtMst { get; private set; }

    /// <summary>
    /// DiscAmtDtl of the AccountsPayableContractMaster
    /// DiscAmtDtl الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public decimal? DiscAmtDtl { get; private set; }

    /// <summary>
    /// CostCenterCode of the AccountsPayableContractMaster
    /// CostCenterCode الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the AccountsPayableContractMaster
    /// ProjectNumber الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the AccountsPayableContractMaster
    /// ActivityNumber الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the AccountsPayableContractMaster
    /// ProcessedFlagFull الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// InactiveFlag of the AccountsPayableContractMaster
    /// InactiveFlag الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the AccountsPayableContractMaster
    /// InactivatedByUserId الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the AccountsPayableContractMaster
    /// InactiveDate الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the AccountsPayableContractMaster
    /// InactiveReason الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// ApprovedFlag of the AccountsPayableContractMaster
    /// ApprovedFlag الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the AccountsPayableContractMaster
    /// ApprovalUserId الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the AccountsPayableContractMaster
    /// ApprovalDate الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the AccountsPayableContractMaster
    /// ApprovalDescription الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// ContractNoRenew of the AccountsPayableContractMaster
    /// ContractNoRenew الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public string ContractNoRenew { get; private set; }

    /// <summary>
    /// ContractSerialRenew of the AccountsPayableContractMaster
    /// ContractSerialRenew الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public string ContractSerialRenew { get; private set; }

    /// <summary>
    /// VatAmount of the AccountsPayableContractMaster
    /// VatAmount الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// UseVat of the AccountsPayableContractMaster
    /// UseVat الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public decimal? UseVat { get; private set; }

    /// <summary>
    /// CalcVatPriceType of the AccountsPayableContractMaster
    /// CalcVatPriceType الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public decimal? CalcVatPriceType { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the AccountsPayableContractMaster
    /// CalcTypeNumberTax الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AccountsPayableContractMaster
    /// CompanyNumberShort الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AccountsPayableContractMaster
    /// BranchNumber الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AccountsPayableContractMaster
    /// BranchYear الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AccountsPayableContractMaster
    /// BranchUser الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CalcTaxFreeQuantityFlag of the AccountsPayableContractMaster
    /// CalcTaxFreeQuantityFlag الخاص بـ AccountsPayableContractMaster
    /// </summary>
    public decimal? CalcTaxFreeQuantityFlag { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

