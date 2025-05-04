using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// BillDetailAdditionalDiscount Entity
/// </summary>
public class BillDetailAdditionalDiscount : Entity<BillDetailAdditionalDiscountId>
{
    private BillDetailAdditionalDiscount() { }

    /// <summary>
    /// The unique identifier for the BillDetailAdditionalDiscount
    /// المعرف الفريد لـ BillDetailAdditionalDiscount
    /// </summary>
    public BillDetailAdditionalDiscountId Id { get; private set; }

    /// <summary>
    /// DocNo of the BillDetailAdditionalDiscount
    /// DocNo الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the BillDetailAdditionalDiscount
    /// DocSer الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// BillNumber of the BillDetailAdditionalDiscount
    /// BillNumber الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the BillDetailAdditionalDiscount
    /// BillSerial الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// ItemCode of the BillDetailAdditionalDiscount
    /// ItemCode الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the BillDetailAdditionalDiscount
    /// ItemUnit الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the BillDetailAdditionalDiscount
    /// PSize الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// WarehouseCode of the BillDetailAdditionalDiscount
    /// WarehouseCode الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the BillDetailAdditionalDiscount
    /// CostCenterCode الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BillDetailAdditionalDiscount
    /// ProjectNumber الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the BillDetailAdditionalDiscount
    /// ActivityNumber الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// NetQuantity of the BillDetailAdditionalDiscount
    /// NetQuantity الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? NetQuantity { get; private set; }

    /// <summary>
    /// AdditionalDiscountPercent of the BillDetailAdditionalDiscount
    /// AdditionalDiscountPercent الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? AdditionalDiscountPercent { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountDetailShort of the BillDetailAdditionalDiscount
    /// AdditionalDiscountAmountDetailShort الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? AdditionalDiscountAmountDetailShort { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountDetailPrevious of the BillDetailAdditionalDiscount
    /// AdditionalDiscountAmountDetailPrevious الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? AdditionalDiscountAmountDetailPrevious { get; private set; }

    /// <summary>
    /// AdditionalDiscountQuantity of the BillDetailAdditionalDiscount
    /// AdditionalDiscountQuantity الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? AdditionalDiscountQuantity { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountMasterShort of the BillDetailAdditionalDiscount
    /// AdditionalDiscountAmountMasterShort الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? AdditionalDiscountAmountMasterShort { get; private set; }

    /// <summary>
    /// VatPercent of the BillDetailAdditionalDiscount
    /// VatPercent الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// VatAmount of the BillDetailAdditionalDiscount
    /// VatAmount الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// AdditionalVatAmount of the BillDetailAdditionalDiscount
    /// AdditionalVatAmount الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? AdditionalVatAmount { get; private set; }

    /// <summary>
    /// ReturnAmount of the BillDetailAdditionalDiscount
    /// ReturnAmount الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? ReturnAmount { get; private set; }

    /// <summary>
    /// RecordNumber of the BillDetailAdditionalDiscount
    /// RecordNumber الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the BillDetailAdditionalDiscount
    /// DocSequence الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BillDetailAdditionalDiscount
    /// ExternalPostFlag الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// ItemDescription of the BillDetailAdditionalDiscount
    /// ItemDescription الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// PriceAfterDiscount of the BillDetailAdditionalDiscount
    /// PriceAfterDiscount الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? PriceAfterDiscount { get; private set; }

    /// <summary>
    /// PostCode of the BillDetailAdditionalDiscount
    /// PostCode الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BillDetailAdditionalDiscount
    /// CompanyNumberShort الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BillDetailAdditionalDiscount
    /// BranchNumber الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchUser of the BillDetailAdditionalDiscount
    /// BranchUser الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// BranchYear of the BillDetailAdditionalDiscount
    /// BranchYear الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// DocTypeRef of the BillDetailAdditionalDiscount
    /// DocTypeRef الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the BillDetailAdditionalDiscount
    /// DocNoRef الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the BillDetailAdditionalDiscount
    /// DocSerRef الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// RecordNumberReference of the BillDetailAdditionalDiscount
    /// RecordNumberReference الخاص بـ BillDetailAdditionalDiscount
    /// </summary>
    public decimal? RecordNumberReference { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to BillMasterAdditionalDiscount
    /// </summary>
    public BillMasterAdditionalDiscount BillMasterAdditionalDiscount { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Project
    /// </summary>
    public Project Project { get; private set; }
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
