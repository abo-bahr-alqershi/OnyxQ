using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// BranchOutgoingDetail Entity
/// </summary>
public class BranchOutgoingDetail : Entity<BranchOutgoingDetailId>
{

    private BranchOutgoingDetail() { }

    public BranchOutgoingDetail(BranchOutgoingDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the BranchOutgoingDetail
    /// المعرف الفريد لـ BranchOutgoingDetail
    /// </summary>
    public BranchOutgoingDetailId Id { get; private set; }

    /// <summary>
    /// OutgoingNumber of the BranchOutgoingDetail
    /// OutgoingNumber الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? OutgoingNumber { get; private set; }

    /// <summary>
    /// OutgoingTypeFull of the BranchOutgoingDetail
    /// OutgoingTypeFull الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? OutgoingTypeFull { get; private set; }

    /// <summary>
    /// ItemCode of the BranchOutgoingDetail
    /// ItemCode الخاص بـ BranchOutgoingDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemQuantity of the BranchOutgoingDetail
    /// ItemQuantity الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// ItemUnit of the BranchOutgoingDetail
    /// ItemUnit الخاص بـ BranchOutgoingDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the BranchOutgoingDetail
    /// PSize الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the BranchOutgoingDetail
    /// PQuantity الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the BranchOutgoingDetail
    /// ItemPriceShort الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// StockCost of the BranchOutgoingDetail
    /// StockCost الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// WarehouseCode of the BranchOutgoingDetail
    /// WarehouseCode الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the BranchOutgoingDetail
    /// CostCenterCode الخاص بـ BranchOutgoingDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BranchOutgoingDetail
    /// ProjectNumber الخاص بـ BranchOutgoingDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the BranchOutgoingDetail
    /// ActivityNumber الخاص بـ BranchOutgoingDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ExpireDate of the BranchOutgoingDetail
    /// ExpireDate الخاص بـ BranchOutgoingDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the BranchOutgoingDetail
    /// BatchNumber الخاص بـ BranchOutgoingDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// ExpenseAmount of the BranchOutgoingDetail
    /// ExpenseAmount الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? ExpenseAmount { get; private set; }

    /// <summary>
    /// UseSerialNumber of the BranchOutgoingDetail
    /// UseSerialNumber الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// VatAmount of the BranchOutgoingDetail
    /// VatAmount الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// VatPercent of the BranchOutgoingDetail
    /// VatPercent الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// RecordNumber of the BranchOutgoingDetail
    /// RecordNumber الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the BranchOutgoingDetail
    /// DocSequence الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// DocTypeRef of the BranchOutgoingDetail
    /// DocTypeRef الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocJvTypeRef of the BranchOutgoingDetail
    /// DocJvTypeRef الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? DocJvTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the BranchOutgoingDetail
    /// DocNoRef الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the BranchOutgoingDetail
    /// DocSerRef الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocSequenceRef of the BranchOutgoingDetail
    /// DocSequenceRef الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// GroupNumberFull of the BranchOutgoingDetail
    /// GroupNumberFull الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? GroupNumberFull { get; private set; }

    /// <summary>
    /// GuarantorSerial of the BranchOutgoingDetail
    /// GuarantorSerial الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? GuarantorSerial { get; private set; }

    /// <summary>
    /// UseAttachment of the BranchOutgoingDetail
    /// UseAttachment الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the BranchOutgoingDetail
    /// ReceiveAttachment الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// ItemDescription of the BranchOutgoingDetail
    /// ItemDescription الخاص بـ BranchOutgoingDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// Barcode of the BranchOutgoingDetail
    /// Barcode الخاص بـ BranchOutgoingDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// ItemLength of the BranchOutgoingDetail
    /// ItemLength الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the BranchOutgoingDetail
    /// ItemWidth الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the BranchOutgoingDetail
    /// ItemHeightShort الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the BranchOutgoingDetail
    /// ItemNumberShort الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// PostCode of the BranchOutgoingDetail
    /// PostCode الخاص بـ BranchOutgoingDetail
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// WeightedQuantity of the BranchOutgoingDetail
    /// WeightedQuantity الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the BranchOutgoingDetail
    /// WeightedUnit الخاص بـ BranchOutgoingDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchOutgoingDetail
    /// ExternalPostFlag الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// WebServiceTransferDataDescription of the BranchOutgoingDetail
    /// WebServiceTransferDataDescription الخاص بـ BranchOutgoingDetail
    /// </summary>
    public string WebServiceTransferDataDescription { get; private set; }

    /// <summary>
    /// WebServiceTransferDataFlag of the BranchOutgoingDetail
    /// WebServiceTransferDataFlag الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? WebServiceTransferDataFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchOutgoingDetail
    /// CompanyNumberShort الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchOutgoingDetail
    /// BranchNumber الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchOutgoingDetail
    /// BranchYear الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchOutgoingDetail
    /// BranchUser الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ArgumentNumber of the BranchOutgoingDetail
    /// ArgumentNumber الخاص بـ BranchOutgoingDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public BranchOutgoingMaster BranchOutgoingMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
