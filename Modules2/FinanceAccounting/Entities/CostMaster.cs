using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// CostMaster Entity
/// </summary>
public class CostMaster : Entity<CostMasterId>
{

    private CostMaster() { }

    public CostMaster(CostMasterId id, decimal? guarantorSerial)
    {
        Id = id;
        GuarantorSerial = guarantorSerial;
    }

    /// <summary>
    /// The unique identifier for the CostMaster
    /// المعرف الفريد لـ CostMaster
    /// </summary>
    public CostMasterId Id { get; private set; }

    /// <summary>
    /// PurchaseInvoiceNumber of the CostMaster
    /// PurchaseInvoiceNumber الخاص بـ CostMaster
    /// </summary>
    public decimal? PurchaseInvoiceNumber { get; private set; }

    /// <summary>
    /// GroupNumberFull of the CostMaster
    /// GroupNumberFull الخاص بـ CostMaster
    /// </summary>
    public decimal? GroupNumberFull { get; private set; }

    /// <summary>
    /// GuarantorSerial of the CostMaster
    /// GuarantorSerial الخاص بـ CostMaster
    /// </summary>
    public decimal? GuarantorSerial { get; private set; }

    /// <summary>
    /// DocSer of the CostMaster
    /// DocSer الخاص بـ CostMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// PurchaseInvoiceCostTypeNumber of the CostMaster
    /// PurchaseInvoiceCostTypeNumber الخاص بـ CostMaster
    /// </summary>
    public decimal? PurchaseInvoiceCostTypeNumber { get; private set; }

    /// <summary>
    /// LetterCreditNumber of the CostMaster
    /// LetterCreditNumber الخاص بـ CostMaster
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// LetterCreditDate of the CostMaster
    /// LetterCreditDate الخاص بـ CostMaster
    /// </summary>
    public DateTime? LetterCreditDate { get; private set; }

    /// <summary>
    /// LetterCreditDescription of the CostMaster
    /// LetterCreditDescription الخاص بـ CostMaster
    /// </summary>
    public string LetterCreditDescription { get; private set; }

    /// <summary>
    /// LetterCreditPostFlag of the CostMaster
    /// LetterCreditPostFlag الخاص بـ CostMaster
    /// </summary>
    public decimal? LetterCreditPostFlag { get; private set; }

    /// <summary>
    /// BankNumber of the CostMaster
    /// BankNumber الخاص بـ CostMaster
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// WarehouseCode of the CostMaster
    /// WarehouseCode الخاص بـ CostMaster
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the CostMaster
    /// CostCenterCode الخاص بـ CostMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ActivityNumber of the CostMaster
    /// ActivityNumber الخاص بـ CostMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ProjectNumber of the CostMaster
    /// ProjectNumber الخاص بـ CostMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the CostMaster
    /// BillDocumentTypeFull الخاص بـ CostMaster
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// HungFlag of the CostMaster
    /// HungFlag الخاص بـ CostMaster
    /// </summary>
    public decimal? HungFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CostMaster
    /// CompanyNumberShort الخاص بـ CostMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CostMaster
    /// BranchNumber الخاص بـ CostMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CostMaster
    /// BranchYear الخاص بـ CostMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CostMaster
    /// BranchUser الخاص بـ CostMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ApprovedExchangeRate of the CostMaster
    /// ApprovedExchangeRate الخاص بـ CostMaster
    /// </summary>
    public decimal? ApprovedExchangeRate { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

