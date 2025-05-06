using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// AccountsPayableQuotationCompareMaster Entity
/// </summary>
public class AccountsPayableQuotationCompareMaster : Entity<AccountsPayableQuotationCompareMasterId>
{

    private AccountsPayableQuotationCompareMaster() { }

    public AccountsPayableQuotationCompareMaster(AccountsPayableQuotationCompareMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the AccountsPayableQuotationCompareMaster
    /// المعرف الفريد لـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public AccountsPayableQuotationCompareMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the AccountsPayableQuotationCompareMaster
    /// DocNo الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the AccountsPayableQuotationCompareMaster
    /// DocSer الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the AccountsPayableQuotationCompareMaster
    /// DocDate الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocDsc of the AccountsPayableQuotationCompareMaster
    /// DocDsc الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the AccountsPayableQuotationCompareMaster
    /// ReferenceNumber الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CurCode of the AccountsPayableQuotationCompareMaster
    /// CurCode الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// CurRate of the AccountsPayableQuotationCompareMaster
    /// CurRate الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// CostCenterCode of the AccountsPayableQuotationCompareMaster
    /// CostCenterCode الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the AccountsPayableQuotationCompareMaster
    /// ProjectNumber الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the AccountsPayableQuotationCompareMaster
    /// ActivityNumber الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// Field1 of the AccountsPayableQuotationCompareMaster
    /// Field1 الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the AccountsPayableQuotationCompareMaster
    /// Field2 الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the AccountsPayableQuotationCompareMaster
    /// Field3 الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the AccountsPayableQuotationCompareMaster
    /// Field4 الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the AccountsPayableQuotationCompareMaster
    /// Field5 الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the AccountsPayableQuotationCompareMaster
    /// Field6 الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the AccountsPayableQuotationCompareMaster
    /// Field7 الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the AccountsPayableQuotationCompareMaster
    /// Field8 الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the AccountsPayableQuotationCompareMaster
    /// Field9 الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the AccountsPayableQuotationCompareMaster
    /// Field10 الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// InactiveFlag of the AccountsPayableQuotationCompareMaster
    /// InactiveFlag الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the AccountsPayableQuotationCompareMaster
    /// InactivatedByUserId الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the AccountsPayableQuotationCompareMaster
    /// InactiveDate الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the AccountsPayableQuotationCompareMaster
    /// InactiveReason الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// ApprovedFlag of the AccountsPayableQuotationCompareMaster
    /// ApprovedFlag الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the AccountsPayableQuotationCompareMaster
    /// ApprovalUserId الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the AccountsPayableQuotationCompareMaster
    /// ApprovalDate الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the AccountsPayableQuotationCompareMaster
    /// ApprovalDescription الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// ProcessedFlag of the AccountsPayableQuotationCompareMaster
    /// ProcessedFlag الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public decimal? ProcessedFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AccountsPayableQuotationCompareMaster
    /// CompanyNumberShort الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AccountsPayableQuotationCompareMaster
    /// BranchNumber الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AccountsPayableQuotationCompareMaster
    /// BranchYear الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AccountsPayableQuotationCompareMaster
    /// BranchUser الخاص بـ AccountsPayableQuotationCompareMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

