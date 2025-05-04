using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// PerformaInvoiceBillMasterAdditionalDiscount Entity
/// </summary>
public class PerformaInvoiceBillMasterAdditionalDiscount : Entity<PerformaInvoiceBillMasterAdditionalDiscountId>
{

    private PerformaInvoiceBillMasterAdditionalDiscount() { }

    public PerformaInvoiceBillMasterAdditionalDiscount(PerformaInvoiceBillMasterAdditionalDiscountId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the PerformaInvoiceBillMasterAdditionalDiscount
    /// المعرف الفريد لـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public PerformaInvoiceBillMasterAdditionalDiscountId Id { get; private set; }

    /// <summary>
    /// AdditionalDiscountType of the PerformaInvoiceBillMasterAdditionalDiscount
    /// AdditionalDiscountType الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? AdditionalDiscountType { get; private set; }

    /// <summary>
    /// DocNo of the PerformaInvoiceBillMasterAdditionalDiscount
    /// DocNo الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocDate of the PerformaInvoiceBillMasterAdditionalDiscount
    /// DocDate الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// ReferenceNumber of the PerformaInvoiceBillMasterAdditionalDiscount
    /// ReferenceNumber الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// BillNumber of the PerformaInvoiceBillMasterAdditionalDiscount
    /// BillNumber الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the PerformaInvoiceBillMasterAdditionalDiscount
    /// BillSerial الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// BillDate of the PerformaInvoiceBillMasterAdditionalDiscount
    /// BillDate الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public DateTime? BillDate { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountMaster of the PerformaInvoiceBillMasterAdditionalDiscount
    /// AdditionalDiscountAmountMaster الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? AdditionalDiscountAmountMaster { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountMasterPrevious of the PerformaInvoiceBillMasterAdditionalDiscount
    /// AdditionalDiscountAmountMasterPrevious الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? AdditionalDiscountAmountMasterPrevious { get; private set; }

    /// <summary>
    /// ReturnAmount of the PerformaInvoiceBillMasterAdditionalDiscount
    /// ReturnAmount الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? ReturnAmount { get; private set; }

    /// <summary>
    /// DocDesc of the PerformaInvoiceBillMasterAdditionalDiscount
    /// DocDesc الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// DocPost of the PerformaInvoiceBillMasterAdditionalDiscount
    /// DocPost الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? DocPost { get; private set; }

    /// <summary>
    /// AccountDetailCode of the PerformaInvoiceBillMasterAdditionalDiscount
    /// AccountDetailCode الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the PerformaInvoiceBillMasterAdditionalDiscount
    /// AccountDetailType الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// HungFlag of the PerformaInvoiceBillMasterAdditionalDiscount
    /// HungFlag الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? HungFlag { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the PerformaInvoiceBillMasterAdditionalDiscount
    /// ProcessedFlagFull الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// DocDiscType of the PerformaInvoiceBillMasterAdditionalDiscount
    /// DocDiscType الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? DocDiscType { get; private set; }

    /// <summary>
    /// NotEffectByVendorTransaction of the PerformaInvoiceBillMasterAdditionalDiscount
    /// NotEffectByVendorTransaction الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? NotEffectByVendorTransaction { get; private set; }

    /// <summary>
    /// AccountCodeInterimDiscountPurchaseInvoice of the PerformaInvoiceBillMasterAdditionalDiscount
    /// AccountCodeInterimDiscountPurchaseInvoice الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public string AccountCodeInterimDiscountPurchaseInvoice { get; private set; }

    /// <summary>
    /// PriceType of the PerformaInvoiceBillMasterAdditionalDiscount
    /// PriceType الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? PriceType { get; private set; }

    /// <summary>
    /// DocNoRef of the PerformaInvoiceBillMasterAdditionalDiscount
    /// DocNoRef الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the PerformaInvoiceBillMasterAdditionalDiscount
    /// DocSerRef الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocTypeRef of the PerformaInvoiceBillMasterAdditionalDiscount
    /// DocTypeRef الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountDetail of the PerformaInvoiceBillMasterAdditionalDiscount
    /// AdditionalDiscountAmountDetail الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? AdditionalDiscountAmountDetail { get; private set; }

    /// <summary>
    /// AdditionalVatAmount of the PerformaInvoiceBillMasterAdditionalDiscount
    /// AdditionalVatAmount الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? AdditionalVatAmount { get; private set; }

    /// <summary>
    /// VatAmount of the PerformaInvoiceBillMasterAdditionalDiscount
    /// VatAmount الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// UseVat of the PerformaInvoiceBillMasterAdditionalDiscount
    /// UseVat الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? UseVat { get; private set; }

    /// <summary>
    /// PostUserId of the PerformaInvoiceBillMasterAdditionalDiscount
    /// PostUserId الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the PerformaInvoiceBillMasterAdditionalDiscount
    /// PostDate الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the PerformaInvoiceBillMasterAdditionalDiscount
    /// UnpostUserId الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the PerformaInvoiceBillMasterAdditionalDiscount
    /// UnpostDate الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PerformaInvoiceBillMasterAdditionalDiscount
    /// CompanyNumberShort الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PerformaInvoiceBillMasterAdditionalDiscount
    /// BranchNumber الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchUser of the PerformaInvoiceBillMasterAdditionalDiscount
    /// BranchUser الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// BranchYear of the PerformaInvoiceBillMasterAdditionalDiscount
    /// BranchYear الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// DocSer of the PerformaInvoiceBillMasterAdditionalDiscount
    /// DocSer الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// AuditReference of the PerformaInvoiceBillMasterAdditionalDiscount
    /// AuditReference الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the PerformaInvoiceBillMasterAdditionalDiscount
    /// AuditReferenceDescription الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the PerformaInvoiceBillMasterAdditionalDiscount
    /// AuditReferenceUserId الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the PerformaInvoiceBillMasterAdditionalDiscount
    /// AuditReferenceDate الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// DocRate of the PerformaInvoiceBillMasterAdditionalDiscount
    /// DocRate الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? DocRate { get; private set; }

    /// <summary>
    /// RepCode of the PerformaInvoiceBillMasterAdditionalDiscount
    /// RepCode الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// DocBrnNo of the PerformaInvoiceBillMasterAdditionalDiscount
    /// DocBrnNo الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the PerformaInvoiceBillMasterAdditionalDiscount
    /// CalcTypeNumberTax الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the PerformaInvoiceBillMasterAdditionalDiscount
    /// ExternalPostFlag الخاص بـ PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

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
    public AccountCurrency AccountCurrencyACode { get; private set; }
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
    public VoucherDetails VoucherDetails { get; private set; }
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
