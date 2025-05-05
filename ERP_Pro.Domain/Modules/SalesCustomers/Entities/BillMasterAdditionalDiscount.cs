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
/// BillMasterAdditionalDiscount Entity
/// </summary>
public class BillMasterAdditionalDiscount : Entity<BillMasterAdditionalDiscountId>
{

    private BillMasterAdditionalDiscount() { }

    public BillMasterAdditionalDiscount(BillMasterAdditionalDiscountId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the BillMasterAdditionalDiscount
    /// المعرف الفريد لـ BillMasterAdditionalDiscount
    /// </summary>
    public BillMasterAdditionalDiscountId Id { get; private set; }

    /// <summary>
    /// AdditionalDiscountType of the BillMasterAdditionalDiscount
    /// AdditionalDiscountType الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? AdditionalDiscountType { get; private set; }

    /// <summary>
    /// DocNo of the BillMasterAdditionalDiscount
    /// DocNo الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the BillMasterAdditionalDiscount
    /// DocSer الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the BillMasterAdditionalDiscount
    /// DocDate الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocRate of the BillMasterAdditionalDiscount
    /// DocRate الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? DocRate { get; private set; }

    /// <summary>
    /// ReferenceNumber of the BillMasterAdditionalDiscount
    /// ReferenceNumber الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// BillNumber of the BillMasterAdditionalDiscount
    /// BillNumber الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the BillMasterAdditionalDiscount
    /// BillSerial الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// BillDate of the BillMasterAdditionalDiscount
    /// BillDate الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public DateTime? BillDate { get; private set; }

    /// <summary>
    /// CashNumber of the BillMasterAdditionalDiscount
    /// CashNumber الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the BillMasterAdditionalDiscount
    /// ColumnNumberShort الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BillMasterAdditionalDiscount
    /// ExternalPostFlag الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// RepCode of the BillMasterAdditionalDiscount
    /// RepCode الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountDetail of the BillMasterAdditionalDiscount
    /// AdditionalDiscountAmountDetail الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? AdditionalDiscountAmountDetail { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountMaster of the BillMasterAdditionalDiscount
    /// AdditionalDiscountAmountMaster الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? AdditionalDiscountAmountMaster { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountMasterPrevious of the BillMasterAdditionalDiscount
    /// AdditionalDiscountAmountMasterPrevious الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? AdditionalDiscountAmountMasterPrevious { get; private set; }

    /// <summary>
    /// AdditionalDiscount of the BillMasterAdditionalDiscount
    /// AdditionalDiscount الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? AdditionalDiscount { get; private set; }

    /// <summary>
    /// AdditionalVatAmount of the BillMasterAdditionalDiscount
    /// AdditionalVatAmount الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? AdditionalVatAmount { get; private set; }

    /// <summary>
    /// ReturnAmount of the BillMasterAdditionalDiscount
    /// ReturnAmount الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? ReturnAmount { get; private set; }

    /// <summary>
    /// DocDesc of the BillMasterAdditionalDiscount
    /// DocDesc الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// DocPost of the BillMasterAdditionalDiscount
    /// DocPost الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? DocPost { get; private set; }

    /// <summary>
    /// DocBrnNo of the BillMasterAdditionalDiscount
    /// DocBrnNo الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// RegionCode of the BillMasterAdditionalDiscount
    /// RegionCode الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// StandByFlag of the BillMasterAdditionalDiscount
    /// StandByFlag الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// AuditReference of the BillMasterAdditionalDiscount
    /// AuditReference الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the BillMasterAdditionalDiscount
    /// AuditReferenceDescription الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the BillMasterAdditionalDiscount
    /// AuditReferenceUserId الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the BillMasterAdditionalDiscount
    /// AuditReferenceDate الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// Field1 of the BillMasterAdditionalDiscount
    /// Field1 الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the BillMasterAdditionalDiscount
    /// Field2 الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the BillMasterAdditionalDiscount
    /// Field3 الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the BillMasterAdditionalDiscount
    /// Field4 الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the BillMasterAdditionalDiscount
    /// Field5 الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the BillMasterAdditionalDiscount
    /// Field6 الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the BillMasterAdditionalDiscount
    /// Field7 الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the BillMasterAdditionalDiscount
    /// Field8 الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the BillMasterAdditionalDiscount
    /// Field9 الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the BillMasterAdditionalDiscount
    /// Field10 الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// SalesInvoiceAdditionalDiscountType of the BillMasterAdditionalDiscount
    /// SalesInvoiceAdditionalDiscountType الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? SalesInvoiceAdditionalDiscountType { get; private set; }

    /// <summary>
    /// RequestSerialShortAlt of the BillMasterAdditionalDiscount
    /// RequestSerialShortAlt الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? RequestSerialShortAlt { get; private set; }

    /// <summary>
    /// DocTypeRef of the BillMasterAdditionalDiscount
    /// DocTypeRef الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the BillMasterAdditionalDiscount
    /// DocNoRef الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the BillMasterAdditionalDiscount
    /// DocSerRef الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the BillMasterAdditionalDiscount
    /// BillDocumentTypeFull الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// PostUserId of the BillMasterAdditionalDiscount
    /// PostUserId الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the BillMasterAdditionalDiscount
    /// PostDate الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the BillMasterAdditionalDiscount
    /// UnpostUserId الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the BillMasterAdditionalDiscount
    /// UnpostDate الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BillMasterAdditionalDiscount
    /// CompanyNumberShort الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BillMasterAdditionalDiscount
    /// BranchNumber الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchUser of the BillMasterAdditionalDiscount
    /// BranchUser الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// BranchYear of the BillMasterAdditionalDiscount
    /// BranchYear الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// RecordNumberReference of the BillMasterAdditionalDiscount
    /// RecordNumberReference الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? RecordNumberReference { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the BillMasterAdditionalDiscount
    /// CalcTypeNumberTax الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// CalcVatPriceType of the BillMasterAdditionalDiscount
    /// CalcVatPriceType الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? CalcVatPriceType { get; private set; }

    /// <summary>
    /// PatientNumber of the BillMasterAdditionalDiscount
    /// PatientNumber الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public string PatientNumber { get; private set; }

    /// <summary>
    /// CalcTaxFreeQuantityFlag of the BillMasterAdditionalDiscount
    /// CalcTaxFreeQuantityFlag الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? CalcTaxFreeQuantityFlag { get; private set; }

    /// <summary>
    /// CreatedDateClock of the BillMasterAdditionalDiscount
    /// CreatedDateClock الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public DateTime? CreatedDateClock { get; private set; }

    /// <summary>
    /// WebServiceTransferDataFlag of the BillMasterAdditionalDiscount
    /// WebServiceTransferDataFlag الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public decimal? WebServiceTransferDataFlag { get; private set; }

    /// <summary>
    /// WebServiceUuid of the BillMasterAdditionalDiscount
    /// WebServiceUuid الخاص بـ BillMasterAdditionalDiscount
    /// </summary>
    public string WebServiceUuid { get; private set; }

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

