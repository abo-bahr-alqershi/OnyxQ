using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// PurchaseRequestBillDetail Entity
/// </summary>
public class PurchaseRequestBillDetail : Entity<PurchaseRequestBillDetailId>
{

    private PurchaseRequestBillDetail() { }

    public PurchaseRequestBillDetail(PurchaseRequestBillDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PurchaseRequestBillDetail
    /// المعرف الفريد لـ PurchaseRequestBillDetail
    /// </summary>
    public PurchaseRequestBillDetailId Id { get; private set; }

    /// <summary>
    /// ReturnRequestDocumentType of the PurchaseRequestBillDetail
    /// ReturnRequestDocumentType الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? ReturnRequestDocumentType { get; private set; }

    /// <summary>
    /// ReturnRequestNumber of the PurchaseRequestBillDetail
    /// ReturnRequestNumber الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? ReturnRequestNumber { get; private set; }

    /// <summary>
    /// BillNumber of the PurchaseRequestBillDetail
    /// BillNumber الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the PurchaseRequestBillDetail
    /// BillDocumentTypeFull الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillSerial of the PurchaseRequestBillDetail
    /// BillSerial الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// ItemCode of the PurchaseRequestBillDetail
    /// ItemCode الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemQuantity of the PurchaseRequestBillDetail
    /// ItemQuantity الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PSize of the PurchaseRequestBillDetail
    /// PSize الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the PurchaseRequestBillDetail
    /// PQuantity الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the PurchaseRequestBillDetail
    /// ItemPriceShort الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// WarehouseCode of the PurchaseRequestBillDetail
    /// WarehouseCode الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the PurchaseRequestBillDetail
    /// CostCenterCode الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the PurchaseRequestBillDetail
    /// ProjectNumber الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the PurchaseRequestBillDetail
    /// ActivityNumber الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ExpireDate of the PurchaseRequestBillDetail
    /// ExpireDate الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the PurchaseRequestBillDetail
    /// BatchNumber الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// FreeQuantity of the PurchaseRequestBillDetail
    /// FreeQuantity الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// DisPer of the PurchaseRequestBillDetail
    /// DisPer الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// DisAmtDtl of the PurchaseRequestBillDetail
    /// DisAmtDtl الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? DisAmtDtl { get; private set; }

    /// <summary>
    /// DisPer2 of the PurchaseRequestBillDetail
    /// DisPer2 الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? DisPer2 { get; private set; }

    /// <summary>
    /// DisAmtDtl2 of the PurchaseRequestBillDetail
    /// DisAmtDtl2 الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? DisAmtDtl2 { get; private set; }

    /// <summary>
    /// DisPer3 of the PurchaseRequestBillDetail
    /// DisPer3 الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? DisPer3 { get; private set; }

    /// <summary>
    /// DisAmtDtl3 of the PurchaseRequestBillDetail
    /// DisAmtDtl3 الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? DisAmtDtl3 { get; private set; }

    /// <summary>
    /// DisAmtMst of the PurchaseRequestBillDetail
    /// DisAmtMst الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? DisAmtMst { get; private set; }

    /// <summary>
    /// DisAmt of the PurchaseRequestBillDetail
    /// DisAmt الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// VatPercent of the PurchaseRequestBillDetail
    /// VatPercent الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// VatAmount of the PurchaseRequestBillDetail
    /// VatAmount الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// UseSerialNumber of the PurchaseRequestBillDetail
    /// UseSerialNumber الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// SalesInvoiceRecordNumber of the PurchaseRequestBillDetail
    /// SalesInvoiceRecordNumber الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? SalesInvoiceRecordNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the PurchaseRequestBillDetail
    /// RecordNumber الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the PurchaseRequestBillDetail
    /// DocSequence الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// DocSequencePi of the PurchaseRequestBillDetail
    /// DocSequencePi الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? DocSequencePi { get; private set; }

    /// <summary>
    /// ItemDescription of the PurchaseRequestBillDetail
    /// ItemDescription الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// UseAttachment of the PurchaseRequestBillDetail
    /// UseAttachment الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the PurchaseRequestBillDetail
    /// ReceiveAttachment الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// DisAmtNotEffect of the PurchaseRequestBillDetail
    /// DisAmtNotEffect الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? DisAmtNotEffect { get; private set; }

    /// <summary>
    /// ItemLength of the PurchaseRequestBillDetail
    /// ItemLength الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the PurchaseRequestBillDetail
    /// ItemWidth الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the PurchaseRequestBillDetail
    /// ItemHeightShort الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the PurchaseRequestBillDetail
    /// ItemNumberShort الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// ServiceItemShort of the PurchaseRequestBillDetail
    /// ServiceItemShort الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? ServiceItemShort { get; private set; }

    /// <summary>
    /// ItemPriceVat of the PurchaseRequestBillDetail
    /// ItemPriceVat الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? ItemPriceVat { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PurchaseRequestBillDetail
    /// CompanyNumberShort الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PurchaseRequestBillDetail
    /// BranchNumber الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PurchaseRequestBillDetail
    /// BranchYear الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the PurchaseRequestBillDetail
    /// BranchUser الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ItemUnit of the PurchaseRequestBillDetail
    /// ItemUnit الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// WeightedQuantity of the PurchaseRequestBillDetail
    /// WeightedQuantity الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the PurchaseRequestBillDetail
    /// WeightedUnit الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// ArgumentNumber of the PurchaseRequestBillDetail
    /// ArgumentNumber الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// ReserveDate of the PurchaseRequestBillDetail
    /// ReserveDate الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public DateTime? ReserveDate { get; private set; }

    /// <summary>
    /// ReserveQuantityShort of the PurchaseRequestBillDetail
    /// ReserveQuantityShort الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? ReserveQuantityShort { get; private set; }

    /// <summary>
    /// ReservedFlag of the PurchaseRequestBillDetail
    /// ReservedFlag الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? ReservedFlag { get; private set; }

    /// <summary>
    /// DocTypeRef of the PurchaseRequestBillDetail
    /// DocTypeRef الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the PurchaseRequestBillDetail
    /// DocNoRef الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the PurchaseRequestBillDetail
    /// DocSerRef الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocSequenceRef of the PurchaseRequestBillDetail
    /// DocSequenceRef الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// FieldDetail1 of the PurchaseRequestBillDetail
    /// FieldDetail1 الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public string FieldDetail1 { get; private set; }

    /// <summary>
    /// FieldDetail2 of the PurchaseRequestBillDetail
    /// FieldDetail2 الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public string FieldDetail2 { get; private set; }

    /// <summary>
    /// FieldDetail3 of the PurchaseRequestBillDetail
    /// FieldDetail3 الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public string FieldDetail3 { get; private set; }

    /// <summary>
    /// FieldDetail4 of the PurchaseRequestBillDetail
    /// FieldDetail4 الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public string FieldDetail4 { get; private set; }

    /// <summary>
    /// FieldDetail5 of the PurchaseRequestBillDetail
    /// FieldDetail5 الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public string FieldDetail5 { get; private set; }

    /// <summary>
    /// FieldDetail6 of the PurchaseRequestBillDetail
    /// FieldDetail6 الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public string FieldDetail6 { get; private set; }

    /// <summary>
    /// FieldDetail7 of the PurchaseRequestBillDetail
    /// FieldDetail7 الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public string FieldDetail7 { get; private set; }

    /// <summary>
    /// FieldDetail8 of the PurchaseRequestBillDetail
    /// FieldDetail8 الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public string FieldDetail8 { get; private set; }

    /// <summary>
    /// FieldDetail9 of the PurchaseRequestBillDetail
    /// FieldDetail9 الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public string FieldDetail9 { get; private set; }

    /// <summary>
    /// FieldDetail10 of the PurchaseRequestBillDetail
    /// FieldDetail10 الخاص بـ PurchaseRequestBillDetail
    /// </summary>
    public string FieldDetail10 { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public PurchaseRequestBillMaster PurchaseRequestBillMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
