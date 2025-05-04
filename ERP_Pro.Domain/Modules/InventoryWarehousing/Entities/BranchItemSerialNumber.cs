using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// BranchItemSerialNumber Entity
/// </summary>
public class BranchItemSerialNumber : Entity<BranchItemSerialNumberId>
{

    private BranchItemSerialNumber() { }

    public BranchItemSerialNumber(BranchItemSerialNumberId id, decimal? docSer, string serialNumber)
    {
        Id = id;
        DocSer = docSer;
        SerialNumber = serialNumber;
    }

    /// <summary>
    /// The unique identifier for the BranchItemSerialNumber
    /// المعرف الفريد لـ BranchItemSerialNumber
    /// </summary>
    public BranchItemSerialNumberId Id { get; private set; }

    /// <summary>
    /// DocType of the BranchItemSerialNumber
    /// DocType الخاص بـ BranchItemSerialNumber
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the BranchItemSerialNumber
    /// BillDocumentTypeFull الخاص بـ BranchItemSerialNumber
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// DocNo of the BranchItemSerialNumber
    /// DocNo الخاص بـ BranchItemSerialNumber
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the BranchItemSerialNumber
    /// DocSer الخاص بـ BranchItemSerialNumber
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the BranchItemSerialNumber
    /// DocDate الخاص بـ BranchItemSerialNumber
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// ItemUnit of the BranchItemSerialNumber
    /// ItemUnit الخاص بـ BranchItemSerialNumber
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the BranchItemSerialNumber
    /// PSize الخاص بـ BranchItemSerialNumber
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// SerialNumber of the BranchItemSerialNumber
    /// SerialNumber الخاص بـ BranchItemSerialNumber
    /// </summary>
    public string SerialNumber { get; private set; }

    /// <summary>
    /// DescNo of the BranchItemSerialNumber
    /// DescNo الخاص بـ BranchItemSerialNumber
    /// </summary>
    public decimal? DescNo { get; private set; }

    /// <summary>
    /// WarehouseCode of the BranchItemSerialNumber
    /// WarehouseCode الخاص بـ BranchItemSerialNumber
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the BranchItemSerialNumber
    /// CostCenterCode الخاص بـ BranchItemSerialNumber
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BranchItemSerialNumber
    /// ProjectNumber الخاص بـ BranchItemSerialNumber
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ExpireDate of the BranchItemSerialNumber
    /// ExpireDate الخاص بـ BranchItemSerialNumber
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the BranchItemSerialNumber
    /// BatchNumber الخاص بـ BranchItemSerialNumber
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// FreeFlag of the BranchItemSerialNumber
    /// FreeFlag الخاص بـ BranchItemSerialNumber
    /// </summary>
    public decimal? FreeFlag { get; private set; }

    /// <summary>
    /// BillCost of the BranchItemSerialNumber
    /// BillCost الخاص بـ BranchItemSerialNumber
    /// </summary>
    public decimal? BillCost { get; private set; }

    /// <summary>
    /// OutgoingNumber of the BranchItemSerialNumber
    /// OutgoingNumber الخاص بـ BranchItemSerialNumber
    /// </summary>
    public decimal? OutgoingNumber { get; private set; }

    /// <summary>
    /// OutgoingGroupSerial of the BranchItemSerialNumber
    /// OutgoingGroupSerial الخاص بـ BranchItemSerialNumber
    /// </summary>
    public decimal? OutgoingGroupSerial { get; private set; }

    /// <summary>
    /// InOutFlag of the BranchItemSerialNumber
    /// InOutFlag الخاص بـ BranchItemSerialNumber
    /// </summary>
    public decimal? InOutFlag { get; private set; }

    /// <summary>
    /// RecordNumber of the BranchItemSerialNumber
    /// RecordNumber الخاص بـ BranchItemSerialNumber
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// RecordNumberDocument of the BranchItemSerialNumber
    /// RecordNumberDocument الخاص بـ BranchItemSerialNumber
    /// </summary>
    public decimal? RecordNumberDocument { get; private set; }

    /// <summary>
    /// ActiveFlag of the BranchItemSerialNumber
    /// ActiveFlag الخاص بـ BranchItemSerialNumber
    /// </summary>
    public decimal? ActiveFlag { get; private set; }

    /// <summary>
    /// ActiveUserId of the BranchItemSerialNumber
    /// ActiveUserId الخاص بـ BranchItemSerialNumber
    /// </summary>
    public decimal? ActiveUserId { get; private set; }

    /// <summary>
    /// ActiveDate of the BranchItemSerialNumber
    /// ActiveDate الخاص بـ BranchItemSerialNumber
    /// </summary>
    public DateTime? ActiveDate { get; private set; }

    /// <summary>
    /// ActiveNote of the BranchItemSerialNumber
    /// ActiveNote الخاص بـ BranchItemSerialNumber
    /// </summary>
    public string ActiveNote { get; private set; }

    /// <summary>
    /// QrCode of the BranchItemSerialNumber
    /// QrCode الخاص بـ BranchItemSerialNumber
    /// </summary>
    public string QrCode { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchItemSerialNumber
    /// ExternalPostFlag الخاص بـ BranchItemSerialNumber
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchItemSerialNumber
    /// CompanyNumberShort الخاص بـ BranchItemSerialNumber
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchItemSerialNumber
    /// BranchNumber الخاص بـ BranchItemSerialNumber
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchItemSerialNumber
    /// BranchYear الخاص بـ BranchItemSerialNumber
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchItemSerialNumber
    /// BranchUser الخاص بـ BranchItemSerialNumber
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// SerialSequence of the BranchItemSerialNumber
    /// SerialSequence الخاص بـ BranchItemSerialNumber
    /// </summary>
    public decimal? SerialSequence { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
