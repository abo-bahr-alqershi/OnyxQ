using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// AccountsReceivableContractDetail Entity
/// </summary>
public class AccountsReceivableContractDetail : Entity<AccountsReceivableContractDetailId>
{

    private AccountsReceivableContractDetail() { }

    public AccountsReceivableContractDetail(AccountsReceivableContractDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AccountsReceivableContractDetail
    /// المعرف الفريد لـ AccountsReceivableContractDetail
    /// </summary>
    public AccountsReceivableContractDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the AccountsReceivableContractDetail
    /// DocNo الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// ContractNumber of the AccountsReceivableContractDetail
    /// ContractNumber الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public string ContractNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the AccountsReceivableContractDetail
    /// RecordNumber الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ItemCode of the AccountsReceivableContractDetail
    /// ItemCode الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemNameFull of the AccountsReceivableContractDetail
    /// ItemNameFull الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public string ItemNameFull { get; private set; }

    /// <summary>
    /// ItemQuantity of the AccountsReceivableContractDetail
    /// ItemQuantity الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PSize of the AccountsReceivableContractDetail
    /// PSize الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the AccountsReceivableContractDetail
    /// PQuantity الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the AccountsReceivableContractDetail
    /// ItemPriceShort الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// ItemUnit of the AccountsReceivableContractDetail
    /// ItemUnit الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// DisAmtMst of the AccountsReceivableContractDetail
    /// DisAmtMst الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? DisAmtMst { get; private set; }

    /// <summary>
    /// DisPer of the AccountsReceivableContractDetail
    /// DisPer الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// DisAmtDtl of the AccountsReceivableContractDetail
    /// DisAmtDtl الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? DisAmtDtl { get; private set; }

    /// <summary>
    /// DisAmt of the AccountsReceivableContractDetail
    /// DisAmt الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// InactiveFlag of the AccountsReceivableContractDetail
    /// InactiveFlag الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// FreeQuantity of the AccountsReceivableContractDetail
    /// FreeQuantity الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// CostCenterCode of the AccountsReceivableContractDetail
    /// CostCenterCode الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// VatAmount of the AccountsReceivableContractDetail
    /// VatAmount الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// VatPercent of the AccountsReceivableContractDetail
    /// VatPercent الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// ItemPriceVat of the AccountsReceivableContractDetail
    /// ItemPriceVat الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? ItemPriceVat { get; private set; }

    /// <summary>
    /// ItemDescription of the AccountsReceivableContractDetail
    /// ItemDescription الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AccountsReceivableContractDetail
    /// CompanyNumberShort الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AccountsReceivableContractDetail
    /// BranchNumber الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AccountsReceivableContractDetail
    /// BranchYear الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AccountsReceivableContractDetail
    /// BranchUser الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ProjectNumber of the AccountsReceivableContractDetail
    /// ProjectNumber الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the AccountsReceivableContractDetail
    /// ActivityNumber الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// FieldDetail1 of the AccountsReceivableContractDetail
    /// FieldDetail1 الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public string FieldDetail1 { get; private set; }

    /// <summary>
    /// FieldDetail2 of the AccountsReceivableContractDetail
    /// FieldDetail2 الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public string FieldDetail2 { get; private set; }

    /// <summary>
    /// FieldDetail3 of the AccountsReceivableContractDetail
    /// FieldDetail3 الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public string FieldDetail3 { get; private set; }

    /// <summary>
    /// FieldDetail4 of the AccountsReceivableContractDetail
    /// FieldDetail4 الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public string FieldDetail4 { get; private set; }

    /// <summary>
    /// FieldDetail5 of the AccountsReceivableContractDetail
    /// FieldDetail5 الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public string FieldDetail5 { get; private set; }

    /// <summary>
    /// FieldDetail6 of the AccountsReceivableContractDetail
    /// FieldDetail6 الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public string FieldDetail6 { get; private set; }

    /// <summary>
    /// FieldDetail7 of the AccountsReceivableContractDetail
    /// FieldDetail7 الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public string FieldDetail7 { get; private set; }

    /// <summary>
    /// FieldDetail8 of the AccountsReceivableContractDetail
    /// FieldDetail8 الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public string FieldDetail8 { get; private set; }

    /// <summary>
    /// FieldDetail9 of the AccountsReceivableContractDetail
    /// FieldDetail9 الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public string FieldDetail9 { get; private set; }

    /// <summary>
    /// FieldDetail10 of the AccountsReceivableContractDetail
    /// FieldDetail10 الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public string FieldDetail10 { get; private set; }

    /// <summary>
    /// WarehouseCode of the AccountsReceivableContractDetail
    /// WarehouseCode الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// LevelNumber of the AccountsReceivableContractDetail
    /// LevelNumber الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// DisAmtDtlVat of the AccountsReceivableContractDetail
    /// DisAmtDtlVat الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? DisAmtDtlVat { get; private set; }

    /// <summary>
    /// ItemPriceLevelNumber of the AccountsReceivableContractDetail
    /// ItemPriceLevelNumber الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? ItemPriceLevelNumber { get; private set; }

    /// <summary>
    /// VatAmountDiscountDetailVat of the AccountsReceivableContractDetail
    /// VatAmountDiscountDetailVat الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? VatAmountDiscountDetailVat { get; private set; }

    /// <summary>
    /// DisAmtMstVat of the AccountsReceivableContractDetail
    /// DisAmtMstVat الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? DisAmtMstVat { get; private set; }

    /// <summary>
    /// VatAmountDiscountMasterVat of the AccountsReceivableContractDetail
    /// VatAmountDiscountMasterVat الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? VatAmountDiscountMasterVat { get; private set; }

    /// <summary>
    /// ArgumentNumber of the AccountsReceivableContractDetail
    /// ArgumentNumber الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// ItemHeightShort of the AccountsReceivableContractDetail
    /// ItemHeightShort الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemLength of the AccountsReceivableContractDetail
    /// ItemLength الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemNumberShort of the AccountsReceivableContractDetail
    /// ItemNumberShort الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// ItemWidth of the AccountsReceivableContractDetail
    /// ItemWidth الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// WeightedQuantity of the AccountsReceivableContractDetail
    /// WeightedQuantity الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the AccountsReceivableContractDetail
    /// WeightedUnit الخاص بـ AccountsReceivableContractDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountsReceivableContractMaster AccountsReceivableContractMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
