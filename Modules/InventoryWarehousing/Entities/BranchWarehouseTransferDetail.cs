using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// BranchWarehouseTransferDetail Entity
/// </summary>
public class BranchWarehouseTransferDetail : Entity<BranchWarehouseTransferDetailId>
{
    private BranchWarehouseTransferDetail() { }

    /// <summary>
    /// The unique identifier for the BranchWarehouseTransferDetail
    /// المعرف الفريد لـ BranchWarehouseTransferDetail
    /// </summary>
    public BranchWarehouseTransferDetailId Id { get; private set; }

    /// <summary>
    /// TransactionInOutType of the BranchWarehouseTransferDetail
    /// TransactionInOutType الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? TransactionInOutType { get; private set; }

    /// <summary>
    /// TransactionTypeFull of the BranchWarehouseTransferDetail
    /// TransactionTypeFull الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? TransactionTypeFull { get; private set; }

    /// <summary>
    /// TransactionNumberShort of the BranchWarehouseTransferDetail
    /// TransactionNumberShort الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? TransactionNumberShort { get; private set; }

    /// <summary>
    /// TransactionSerial of the BranchWarehouseTransferDetail
    /// TransactionSerial الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? TransactionSerial { get; private set; }

    /// <summary>
    /// ItemCode of the BranchWarehouseTransferDetail
    /// ItemCode الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemQuantity of the BranchWarehouseTransferDetail
    /// ItemQuantity الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// ItemUnit of the BranchWarehouseTransferDetail
    /// ItemUnit الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the BranchWarehouseTransferDetail
    /// PSize الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the BranchWarehouseTransferDetail
    /// PQuantity الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// WarehouseCode of the BranchWarehouseTransferDetail
    /// WarehouseCode الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// TWarehouseCode of the BranchWarehouseTransferDetail
    /// TWarehouseCode الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? TWarehouseCode { get; private set; }

    /// <summary>
    /// FWarehouseCode of the BranchWarehouseTransferDetail
    /// FWarehouseCode الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? FWarehouseCode { get; private set; }

    /// <summary>
    /// TransactionQuantity of the BranchWarehouseTransferDetail
    /// TransactionQuantity الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? TransactionQuantity { get; private set; }

    /// <summary>
    /// CostCenterCode of the BranchWarehouseTransferDetail
    /// CostCenterCode الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BranchWarehouseTransferDetail
    /// ProjectNumber الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the BranchWarehouseTransferDetail
    /// ActivityNumber الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// StockCost of the BranchWarehouseTransferDetail
    /// StockCost الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// ExpireDate of the BranchWarehouseTransferDetail
    /// ExpireDate الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the BranchWarehouseTransferDetail
    /// BatchNumber الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// UseSerialNumber of the BranchWarehouseTransferDetail
    /// UseSerialNumber الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// ExpenseAmount of the BranchWarehouseTransferDetail
    /// ExpenseAmount الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? ExpenseAmount { get; private set; }

    /// <summary>
    /// OutgoingRequestType of the BranchWarehouseTransferDetail
    /// OutgoingRequestType الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? OutgoingRequestType { get; private set; }

    /// <summary>
    /// OutgoingRequestNumber of the BranchWarehouseTransferDetail
    /// OutgoingRequestNumber الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? OutgoingRequestNumber { get; private set; }

    /// <summary>
    /// OutgoingRequestSerial of the BranchWarehouseTransferDetail
    /// OutgoingRequestSerial الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? OutgoingRequestSerial { get; private set; }

    /// <summary>
    /// RecordNumber of the BranchWarehouseTransferDetail
    /// RecordNumber الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the BranchWarehouseTransferDetail
    /// DocSequence الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// DocSequenceTr of the BranchWarehouseTransferDetail
    /// DocSequenceTr الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? DocSequenceTr { get; private set; }

    /// <summary>
    /// BillOfExchangeNumber of the BranchWarehouseTransferDetail
    /// BillOfExchangeNumber الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public string BillOfExchangeNumber { get; private set; }

    /// <summary>
    /// FTransactionNumber of the BranchWarehouseTransferDetail
    /// FTransactionNumber الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? FTransactionNumber { get; private set; }

    /// <summary>
    /// FTransactionSerial of the BranchWarehouseTransferDetail
    /// FTransactionSerial الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? FTransactionSerial { get; private set; }

    /// <summary>
    /// UseAttachment of the BranchWarehouseTransferDetail
    /// UseAttachment الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the BranchWarehouseTransferDetail
    /// ReceiveAttachment الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// ItemPriceShort of the BranchWarehouseTransferDetail
    /// ItemPriceShort الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// ItemDescription of the BranchWarehouseTransferDetail
    /// ItemDescription الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// Barcode of the BranchWarehouseTransferDetail
    /// Barcode الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// DocTypeRef of the BranchWarehouseTransferDetail
    /// DocTypeRef الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocJvTypeRef of the BranchWarehouseTransferDetail
    /// DocJvTypeRef الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? DocJvTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the BranchWarehouseTransferDetail
    /// DocNoRef الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the BranchWarehouseTransferDetail
    /// DocSerRef الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// VendorCode of the BranchWarehouseTransferDetail
    /// VendorCode الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchWarehouseTransferDetail
    /// ExternalPostFlag الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// FAvailableQuantity of the BranchWarehouseTransferDetail
    /// FAvailableQuantity الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? FAvailableQuantity { get; private set; }

    /// <summary>
    /// TAvailableQuantity of the BranchWarehouseTransferDetail
    /// TAvailableQuantity الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? TAvailableQuantity { get; private set; }

    /// <summary>
    /// ItemLength of the BranchWarehouseTransferDetail
    /// ItemLength الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the BranchWarehouseTransferDetail
    /// ItemWidth الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the BranchWarehouseTransferDetail
    /// ItemHeightShort الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the BranchWarehouseTransferDetail
    /// ItemNumberShort الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// PostCode of the BranchWarehouseTransferDetail
    /// PostCode الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// WeightedQuantity of the BranchWarehouseTransferDetail
    /// WeightedQuantity الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the BranchWarehouseTransferDetail
    /// WeightedUnit الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// DocSequenceRef of the BranchWarehouseTransferDetail
    /// DocSequenceRef الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// WebServiceTransferDataDescription of the BranchWarehouseTransferDetail
    /// WebServiceTransferDataDescription الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public string WebServiceTransferDataDescription { get; private set; }

    /// <summary>
    /// WebServiceTransferDataFlag of the BranchWarehouseTransferDetail
    /// WebServiceTransferDataFlag الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? WebServiceTransferDataFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchWarehouseTransferDetail
    /// CompanyNumberShort الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// ArgumentNumber of the BranchWarehouseTransferDetail
    /// ArgumentNumber الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchWarehouseTransferDetail
    /// BranchNumber الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchWarehouseTransferDetail
    /// BranchYear الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchWarehouseTransferDetail
    /// BranchUser الخاص بـ BranchWarehouseTransferDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Project
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// ManyToOne relationship to BranchWarehouseTransferMaster
    /// </summary>
    public BranchWarehouseTransferMaster BranchWarehouseTransferMaster { get; private set; }
    #endregion
}
}
