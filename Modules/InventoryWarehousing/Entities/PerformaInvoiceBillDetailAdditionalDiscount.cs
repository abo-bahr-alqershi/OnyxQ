using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// PerformaInvoiceBillDetailAdditionalDiscount Entity
/// </summary>
public class PerformaInvoiceBillDetailAdditionalDiscount : Entity<PerformaInvoiceBillDetailAdditionalDiscountId>
{
    private PerformaInvoiceBillDetailAdditionalDiscount() { }

    /// <summary>
    /// The unique identifier for the PerformaInvoiceBillDetailAdditionalDiscount
    /// المعرف الفريد لـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public PerformaInvoiceBillDetailAdditionalDiscountId Id { get; private set; }

    /// <summary>
    /// DocNo of the PerformaInvoiceBillDetailAdditionalDiscount
    /// DocNo الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// BillNumber of the PerformaInvoiceBillDetailAdditionalDiscount
    /// BillNumber الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the PerformaInvoiceBillDetailAdditionalDiscount
    /// BillSerial الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// ItemCode of the PerformaInvoiceBillDetailAdditionalDiscount
    /// ItemCode الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// WarehouseCode of the PerformaInvoiceBillDetailAdditionalDiscount
    /// WarehouseCode الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the PerformaInvoiceBillDetailAdditionalDiscount
    /// CostCenterCode الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the PerformaInvoiceBillDetailAdditionalDiscount
    /// ProjectNumber الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the PerformaInvoiceBillDetailAdditionalDiscount
    /// ActivityNumber الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ItemQuantity of the PerformaInvoiceBillDetailAdditionalDiscount
    /// ItemQuantity الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the PerformaInvoiceBillDetailAdditionalDiscount
    /// ItemPriceShort الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// NetQuantity of the PerformaInvoiceBillDetailAdditionalDiscount
    /// NetQuantity الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? NetQuantity { get; private set; }

    /// <summary>
    /// AdditionalDiscountPercent of the PerformaInvoiceBillDetailAdditionalDiscount
    /// AdditionalDiscountPercent الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? AdditionalDiscountPercent { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountDetailShort of the PerformaInvoiceBillDetailAdditionalDiscount
    /// AdditionalDiscountAmountDetailShort الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? AdditionalDiscountAmountDetailShort { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountDetailPrevious of the PerformaInvoiceBillDetailAdditionalDiscount
    /// AdditionalDiscountAmountDetailPrevious الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? AdditionalDiscountAmountDetailPrevious { get; private set; }

    /// <summary>
    /// AdditionalDiscountQuantity of the PerformaInvoiceBillDetailAdditionalDiscount
    /// AdditionalDiscountQuantity الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? AdditionalDiscountQuantity { get; private set; }

    /// <summary>
    /// ReturnAmount of the PerformaInvoiceBillDetailAdditionalDiscount
    /// ReturnAmount الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? ReturnAmount { get; private set; }

    /// <summary>
    /// RemainderQuantity of the PerformaInvoiceBillDetailAdditionalDiscount
    /// RemainderQuantity الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? RemainderQuantity { get; private set; }

    /// <summary>
    /// AvailableQuantity of the PerformaInvoiceBillDetailAdditionalDiscount
    /// AvailableQuantity الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? AvailableQuantity { get; private set; }

    /// <summary>
    /// RecordNumber of the PerformaInvoiceBillDetailAdditionalDiscount
    /// RecordNumber الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the PerformaInvoiceBillDetailAdditionalDiscount
    /// DocSequence الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the PerformaInvoiceBillDetailAdditionalDiscount
    /// ExternalPostFlag الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// ItemDescription of the PerformaInvoiceBillDetailAdditionalDiscount
    /// ItemDescription الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// PostCode of the PerformaInvoiceBillDetailAdditionalDiscount
    /// PostCode الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// ItemUnit of the PerformaInvoiceBillDetailAdditionalDiscount
    /// ItemUnit الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the PerformaInvoiceBillDetailAdditionalDiscount
    /// PSize الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the PerformaInvoiceBillDetailAdditionalDiscount
    /// PQuantity الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceVat of the PerformaInvoiceBillDetailAdditionalDiscount
    /// ItemPriceVat الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? ItemPriceVat { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountMasterShort of the PerformaInvoiceBillDetailAdditionalDiscount
    /// AdditionalDiscountAmountMasterShort الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? AdditionalDiscountAmountMasterShort { get; private set; }

    /// <summary>
    /// DocSer of the PerformaInvoiceBillDetailAdditionalDiscount
    /// DocSer الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocRate of the PerformaInvoiceBillDetailAdditionalDiscount
    /// DocRate الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? DocRate { get; private set; }

    /// <summary>
    /// AdditionalDiscountPercentPrevious of the PerformaInvoiceBillDetailAdditionalDiscount
    /// AdditionalDiscountPercentPrevious الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? AdditionalDiscountPercentPrevious { get; private set; }

    /// <summary>
    /// AdditionalVatAmount of the PerformaInvoiceBillDetailAdditionalDiscount
    /// AdditionalVatAmount الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? AdditionalVatAmount { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PerformaInvoiceBillDetailAdditionalDiscount
    /// CompanyNumberShort الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PerformaInvoiceBillDetailAdditionalDiscount
    /// BranchNumber الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchUser of the PerformaInvoiceBillDetailAdditionalDiscount
    /// BranchUser الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// BranchYear of the PerformaInvoiceBillDetailAdditionalDiscount
    /// BranchYear الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// VatPercent of the PerformaInvoiceBillDetailAdditionalDiscount
    /// VatPercent الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// VatAmount of the PerformaInvoiceBillDetailAdditionalDiscount
    /// VatAmount الخاص بـ PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public decimal? VatAmount { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemMaster
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public PerformaInvoiceBillMasterAdditionalDiscount PerformaInvoiceBillMasterAdditionalDiscount { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Warehouse
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion
}
}
