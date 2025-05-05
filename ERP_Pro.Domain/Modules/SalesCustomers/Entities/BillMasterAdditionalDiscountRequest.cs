using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// BillMasterAdditionalDiscountRequest Entity
/// </summary>
public class BillMasterAdditionalDiscountRequest : Entity<BillMasterAdditionalDiscountRequestId>
{

    private BillMasterAdditionalDiscountRequest() { }

    public BillMasterAdditionalDiscountRequest(BillMasterAdditionalDiscountRequestId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the BillMasterAdditionalDiscountRequest
    /// المعرف الفريد لـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public BillMasterAdditionalDiscountRequestId Id { get; private set; }

    /// <summary>
    /// AdditionalDiscountType of the BillMasterAdditionalDiscountRequest
    /// AdditionalDiscountType الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? AdditionalDiscountType { get; private set; }

    /// <summary>
    /// SalesInvoiceAdditionalDiscountType of the BillMasterAdditionalDiscountRequest
    /// SalesInvoiceAdditionalDiscountType الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? SalesInvoiceAdditionalDiscountType { get; private set; }

    /// <summary>
    /// DocNo of the BillMasterAdditionalDiscountRequest
    /// DocNo الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the BillMasterAdditionalDiscountRequest
    /// DocSer الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the BillMasterAdditionalDiscountRequest
    /// DocDate الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocRate of the BillMasterAdditionalDiscountRequest
    /// DocRate الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? DocRate { get; private set; }

    /// <summary>
    /// ReferenceNumber of the BillMasterAdditionalDiscountRequest
    /// ReferenceNumber الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// BillNumber of the BillMasterAdditionalDiscountRequest
    /// BillNumber الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the BillMasterAdditionalDiscountRequest
    /// BillSerial الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// BillDate of the BillMasterAdditionalDiscountRequest
    /// BillDate الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public DateTime? BillDate { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the BillMasterAdditionalDiscountRequest
    /// BillDocumentTypeFull الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// CashNumber of the BillMasterAdditionalDiscountRequest
    /// CashNumber الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the BillMasterAdditionalDiscountRequest
    /// ColumnNumberShort الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// RepCode of the BillMasterAdditionalDiscountRequest
    /// RepCode الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// ProcessedFlagAlt of the BillMasterAdditionalDiscountRequest
    /// ProcessedFlagAlt الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? ProcessedFlagAlt { get; private set; }

    /// <summary>
    /// InactiveFlag of the BillMasterAdditionalDiscountRequest
    /// InactiveFlag الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountDetail of the BillMasterAdditionalDiscountRequest
    /// AdditionalDiscountAmountDetail الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? AdditionalDiscountAmountDetail { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountMasterPrevious of the BillMasterAdditionalDiscountRequest
    /// AdditionalDiscountAmountMasterPrevious الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? AdditionalDiscountAmountMasterPrevious { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountMaster of the BillMasterAdditionalDiscountRequest
    /// AdditionalDiscountAmountMaster الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? AdditionalDiscountAmountMaster { get; private set; }

    /// <summary>
    /// ReturnAmount of the BillMasterAdditionalDiscountRequest
    /// ReturnAmount الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? ReturnAmount { get; private set; }

    /// <summary>
    /// DocDesc of the BillMasterAdditionalDiscountRequest
    /// DocDesc الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// RegionCode of the BillMasterAdditionalDiscountRequest
    /// RegionCode الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BillMasterAdditionalDiscountRequest
    /// ExternalPostFlag الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// ApprovedFlag of the BillMasterAdditionalDiscountRequest
    /// ApprovedFlag الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the BillMasterAdditionalDiscountRequest
    /// ApprovalUserId الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the BillMasterAdditionalDiscountRequest
    /// ApprovalDate الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the BillMasterAdditionalDiscountRequest
    /// ApprovalDescription الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// Field1 of the BillMasterAdditionalDiscountRequest
    /// Field1 الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the BillMasterAdditionalDiscountRequest
    /// Field2 الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the BillMasterAdditionalDiscountRequest
    /// Field3 الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the BillMasterAdditionalDiscountRequest
    /// Field4 الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the BillMasterAdditionalDiscountRequest
    /// Field5 الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the BillMasterAdditionalDiscountRequest
    /// Field6 الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the BillMasterAdditionalDiscountRequest
    /// Field7 الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the BillMasterAdditionalDiscountRequest
    /// Field8 الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the BillMasterAdditionalDiscountRequest
    /// Field9 الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the BillMasterAdditionalDiscountRequest
    /// Field10 الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// DocBrnNo of the BillMasterAdditionalDiscountRequest
    /// DocBrnNo الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// InactiveReason of the BillMasterAdditionalDiscountRequest
    /// InactiveReason الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the BillMasterAdditionalDiscountRequest
    /// InactiveDate الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the BillMasterAdditionalDiscountRequest
    /// InactivatedByUserId الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BillMasterAdditionalDiscountRequest
    /// CompanyNumberShort الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BillMasterAdditionalDiscountRequest
    /// BranchNumber الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchUser of the BillMasterAdditionalDiscountRequest
    /// BranchUser الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// BranchYear of the BillMasterAdditionalDiscountRequest
    /// BranchYear الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the BillMasterAdditionalDiscountRequest
    /// CalcTypeNumberTax الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// AdditionalVatAmount of the BillMasterAdditionalDiscountRequest
    /// AdditionalVatAmount الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? AdditionalVatAmount { get; private set; }

    /// <summary>
    /// CalcVatPriceType of the BillMasterAdditionalDiscountRequest
    /// CalcVatPriceType الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? CalcVatPriceType { get; private set; }

    /// <summary>
    /// PatientNumber of the BillMasterAdditionalDiscountRequest
    /// PatientNumber الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public string PatientNumber { get; private set; }

    /// <summary>
    /// CalcTaxFreeQuantityFlag of the BillMasterAdditionalDiscountRequest
    /// CalcTaxFreeQuantityFlag الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public decimal? CalcTaxFreeQuantityFlag { get; private set; }

    /// <summary>
    /// CreatedDateClock of the BillMasterAdditionalDiscountRequest
    /// CreatedDateClock الخاص بـ BillMasterAdditionalDiscountRequest
    /// </summary>
    public DateTime? CreatedDateClock { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountCurrency AccountCurrencyDiscACode { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Customer Customer { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

