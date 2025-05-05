using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// CheckDocumentInOutQuantityMaster Entity
/// </summary>
public class CheckDocumentInOutQuantityMaster : AggregateRoot<CheckDocumentInOutQuantityMasterId>
{

    private CheckDocumentInOutQuantityMaster() { }

    public CheckDocumentInOutQuantityMaster(CheckDocumentInOutQuantityMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the CheckDocumentInOutQuantityMaster
    /// المعرف الفريد لـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public CheckDocumentInOutQuantityMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the CheckDocumentInOutQuantityMaster
    /// DocNo الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the CheckDocumentInOutQuantityMaster
    /// DocSer الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the CheckDocumentInOutQuantityMaster
    /// DocDate الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AccountCode of the CheckDocumentInOutQuantityMaster
    /// AccountCode الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the CheckDocumentInOutQuantityMaster
    /// AccountDetailCode الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountNameShort of the CheckDocumentInOutQuantityMaster
    /// AccountNameShort الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public string AccountNameShort { get; private set; }

    /// <summary>
    /// DocDsc of the CheckDocumentInOutQuantityMaster
    /// DocDsc الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the CheckDocumentInOutQuantityMaster
    /// ReferenceNumber الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DocTypeRef of the CheckDocumentInOutQuantityMaster
    /// DocTypeRef الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocJvTypeRef of the CheckDocumentInOutQuantityMaster
    /// DocJvTypeRef الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public decimal? DocJvTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the CheckDocumentInOutQuantityMaster
    /// DocNoRef الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the CheckDocumentInOutQuantityMaster
    /// DocSerRef الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the CheckDocumentInOutQuantityMaster
    /// ExternalPostFlag الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// Field1 of the CheckDocumentInOutQuantityMaster
    /// Field1 الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the CheckDocumentInOutQuantityMaster
    /// Field2 الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the CheckDocumentInOutQuantityMaster
    /// Field3 الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the CheckDocumentInOutQuantityMaster
    /// Field4 الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the CheckDocumentInOutQuantityMaster
    /// Field5 الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the CheckDocumentInOutQuantityMaster
    /// Field6 الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the CheckDocumentInOutQuantityMaster
    /// Field7 الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the CheckDocumentInOutQuantityMaster
    /// Field8 الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the CheckDocumentInOutQuantityMaster
    /// Field9 الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the CheckDocumentInOutQuantityMaster
    /// Field10 الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// ProcessedFlag of the CheckDocumentInOutQuantityMaster
    /// ProcessedFlag الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public decimal? ProcessedFlag { get; private set; }

    /// <summary>
    /// ApprovedFlag of the CheckDocumentInOutQuantityMaster
    /// ApprovedFlag الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalDate of the CheckDocumentInOutQuantityMaster
    /// ApprovalDate الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the CheckDocumentInOutQuantityMaster
    /// ApprovalDescription الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// ApprovalUserId of the CheckDocumentInOutQuantityMaster
    /// ApprovalUserId الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CheckDocumentInOutQuantityMaster
    /// CompanyNumberShort الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CheckDocumentInOutQuantityMaster
    /// BranchNumber الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CheckDocumentInOutQuantityMaster
    /// BranchYear الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CheckDocumentInOutQuantityMaster
    /// BranchUser الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// AccountDetailType of the CheckDocumentInOutQuantityMaster
    /// AccountDetailType الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// PriceTypeFull of the CheckDocumentInOutQuantityMaster
    /// PriceTypeFull الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public decimal? PriceTypeFull { get; private set; }

    /// <summary>
    /// TypeNumberShort of the CheckDocumentInOutQuantityMaster
    /// TypeNumberShort الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// CheckQuantityFlag of the CheckDocumentInOutQuantityMaster
    /// CheckQuantityFlag الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public decimal? CheckQuantityFlag { get; private set; }

    /// <summary>
    /// UsedDocumentNumber of the CheckDocumentInOutQuantityMaster
    /// UsedDocumentNumber الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public decimal? UsedDocumentNumber { get; private set; }

    /// <summary>
    /// UsedDocumentSerial of the CheckDocumentInOutQuantityMaster
    /// UsedDocumentSerial الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public decimal? UsedDocumentSerial { get; private set; }

    /// <summary>
    /// UsedDocumentType of the CheckDocumentInOutQuantityMaster
    /// UsedDocumentType الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public decimal? UsedDocumentType { get; private set; }

    /// <summary>
    /// WarehouseCode of the CheckDocumentInOutQuantityMaster
    /// WarehouseCode الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// DocNoPrptnRef of the CheckDocumentInOutQuantityMaster
    /// DocNoPrptnRef الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public decimal? DocNoPrptnRef { get; private set; }

    /// <summary>
    /// DocSerPrptnRef of the CheckDocumentInOutQuantityMaster
    /// DocSerPrptnRef الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public decimal? DocSerPrptnRef { get; private set; }

    /// <summary>
    /// BillType of the CheckDocumentInOutQuantityMaster
    /// BillType الخاص بـ CheckDocumentInOutQuantityMaster
    /// </summary>
    public decimal? BillType { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

