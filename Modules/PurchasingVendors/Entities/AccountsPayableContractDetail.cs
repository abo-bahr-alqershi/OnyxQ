using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// AccountsPayableContractDetail Entity
/// </summary>
public class AccountsPayableContractDetail : Entity<AccountsPayableContractDetailId>
{
    private AccountsPayableContractDetail() { }

    /// <summary>
    /// The unique identifier for the AccountsPayableContractDetail
    /// المعرف الفريد لـ AccountsPayableContractDetail
    /// </summary>
    public AccountsPayableContractDetailId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the AccountsPayableContractDetail
    /// RecordNumber الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ItemCode of the AccountsPayableContractDetail
    /// ItemCode الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemNameFull of the AccountsPayableContractDetail
    /// ItemNameFull الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public string ItemNameFull { get; private set; }

    /// <summary>
    /// ItemQuantity of the AccountsPayableContractDetail
    /// ItemQuantity الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// ItemUnit of the AccountsPayableContractDetail
    /// ItemUnit الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the AccountsPayableContractDetail
    /// PSize الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the AccountsPayableContractDetail
    /// PQuantity الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the AccountsPayableContractDetail
    /// ItemPriceShort الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// ItemDescription of the AccountsPayableContractDetail
    /// ItemDescription الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// ContractNumber of the AccountsPayableContractDetail
    /// ContractNumber الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public string ContractNumber { get; private set; }

    /// <summary>
    /// ContractSerial of the AccountsPayableContractDetail
    /// ContractSerial الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public string ContractSerial { get; private set; }

    /// <summary>
    /// DisAmtMst of the AccountsPayableContractDetail
    /// DisAmtMst الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public decimal? DisAmtMst { get; private set; }

    /// <summary>
    /// DisAmtDtl of the AccountsPayableContractDetail
    /// DisAmtDtl الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public decimal? DisAmtDtl { get; private set; }

    /// <summary>
    /// DisAmt of the AccountsPayableContractDetail
    /// DisAmt الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// DisPer of the AccountsPayableContractDetail
    /// DisPer الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// FreeQuantity of the AccountsPayableContractDetail
    /// FreeQuantity الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// AccountCode of the AccountsPayableContractDetail
    /// AccountCode الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the AccountsPayableContractDetail
    /// CostCenterCode الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// VatPercent of the AccountsPayableContractDetail
    /// VatPercent الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// VatAmount of the AccountsPayableContractDetail
    /// VatAmount الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// ItemPriceVat of the AccountsPayableContractDetail
    /// ItemPriceVat الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public decimal? ItemPriceVat { get; private set; }

    /// <summary>
    /// InactiveFlag of the AccountsPayableContractDetail
    /// InactiveFlag الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AccountsPayableContractDetail
    /// CompanyNumberShort الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AccountsPayableContractDetail
    /// BranchNumber الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AccountsPayableContractDetail
    /// BranchYear الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AccountsPayableContractDetail
    /// BranchUser الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ProjectNumber of the AccountsPayableContractDetail
    /// ProjectNumber الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the AccountsPayableContractDetail
    /// ActivityNumber الخاص بـ AccountsPayableContractDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to AccountsPayableContractMaster
    /// </summary>
    public AccountsPayableContractMaster AccountsPayableContractMaster { get; private set; }
    #endregion
}
}
