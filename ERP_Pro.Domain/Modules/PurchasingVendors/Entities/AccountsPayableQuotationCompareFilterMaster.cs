using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// AccountsPayableQuotationCompareFilterMaster Entity
/// </summary>
public class AccountsPayableQuotationCompareFilterMaster : Entity<AccountsPayableQuotationCompareFilterMasterId>
{

    private AccountsPayableQuotationCompareFilterMaster() { }

    public AccountsPayableQuotationCompareFilterMaster(AccountsPayableQuotationCompareFilterMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the AccountsPayableQuotationCompareFilterMaster
    /// المعرف الفريد لـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public AccountsPayableQuotationCompareFilterMasterId Id { get; private set; }

    /// <summary>
    /// TypeNumberShort of the AccountsPayableQuotationCompareFilterMaster
    /// TypeNumberShort الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// DocNo of the AccountsPayableQuotationCompareFilterMaster
    /// DocNo الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the AccountsPayableQuotationCompareFilterMaster
    /// DocSer الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the AccountsPayableQuotationCompareFilterMaster
    /// DocDate الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocDsc of the AccountsPayableQuotationCompareFilterMaster
    /// DocDsc الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the AccountsPayableQuotationCompareFilterMaster
    /// ReferenceNumber الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CurCode of the AccountsPayableQuotationCompareFilterMaster
    /// CurCode الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// 7 of the AccountsPayableQuotationCompareFilterMaster
    /// 7 الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public string 7 { get; private set; }

    /// <summary>
    /// CurRate of the AccountsPayableQuotationCompareFilterMaster
    /// CurRate الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// CostCenterCode of the AccountsPayableQuotationCompareFilterMaster
    /// CostCenterCode الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the AccountsPayableQuotationCompareFilterMaster
    /// ProjectNumber الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the AccountsPayableQuotationCompareFilterMaster
    /// ActivityNumber الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// Field1 of the AccountsPayableQuotationCompareFilterMaster
    /// Field1 الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the AccountsPayableQuotationCompareFilterMaster
    /// Field2 الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the AccountsPayableQuotationCompareFilterMaster
    /// Field3 الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the AccountsPayableQuotationCompareFilterMaster
    /// Field4 الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the AccountsPayableQuotationCompareFilterMaster
    /// Field5 الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the AccountsPayableQuotationCompareFilterMaster
    /// Field6 الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the AccountsPayableQuotationCompareFilterMaster
    /// Field7 الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the AccountsPayableQuotationCompareFilterMaster
    /// Field8 الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the AccountsPayableQuotationCompareFilterMaster
    /// Field9 الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the AccountsPayableQuotationCompareFilterMaster
    /// Field10 الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// InactiveFlag of the AccountsPayableQuotationCompareFilterMaster
    /// InactiveFlag الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the AccountsPayableQuotationCompareFilterMaster
    /// InactivatedByUserId الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the AccountsPayableQuotationCompareFilterMaster
    /// InactiveDate الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the AccountsPayableQuotationCompareFilterMaster
    /// InactiveReason الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// ApprovedFlag of the AccountsPayableQuotationCompareFilterMaster
    /// ApprovedFlag الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the AccountsPayableQuotationCompareFilterMaster
    /// ApprovalUserId الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the AccountsPayableQuotationCompareFilterMaster
    /// ApprovalDate الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the AccountsPayableQuotationCompareFilterMaster
    /// ApprovalDescription الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// ProcessedFlag of the AccountsPayableQuotationCompareFilterMaster
    /// ProcessedFlag الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public decimal? ProcessedFlag { get; private set; }

    /// <summary>
    /// FilterType of the AccountsPayableQuotationCompareFilterMaster
    /// FilterType الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public decimal? FilterType { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AccountsPayableQuotationCompareFilterMaster
    /// CompanyNumberShort الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AccountsPayableQuotationCompareFilterMaster
    /// BranchNumber الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AccountsPayableQuotationCompareFilterMaster
    /// BranchYear الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AccountsPayableQuotationCompareFilterMaster
    /// BranchUser الخاص بـ AccountsPayableQuotationCompareFilterMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
