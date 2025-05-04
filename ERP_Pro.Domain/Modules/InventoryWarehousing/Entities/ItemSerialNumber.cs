using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemSerialNumber Entity
/// </summary>
public class ItemSerialNumber : Entity<ItemSerialNumberId>
{

    private ItemSerialNumber() { }

    public ItemSerialNumber(ItemSerialNumberId id, decimal? docSer, string serialNumber)
    {
        Id = id;
        DocSer = docSer;
        SerialNumber = serialNumber;
    }

    /// <summary>
    /// The unique identifier for the ItemSerialNumber
    /// المعرف الفريد لـ ItemSerialNumber
    /// </summary>
    public ItemSerialNumberId Id { get; private set; }

    /// <summary>
    /// DocType of the ItemSerialNumber
    /// DocType الخاص بـ ItemSerialNumber
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the ItemSerialNumber
    /// BillDocumentTypeFull الخاص بـ ItemSerialNumber
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// DocNo of the ItemSerialNumber
    /// DocNo الخاص بـ ItemSerialNumber
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the ItemSerialNumber
    /// DocSer الخاص بـ ItemSerialNumber
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the ItemSerialNumber
    /// DocDate الخاص بـ ItemSerialNumber
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// PSize of the ItemSerialNumber
    /// PSize الخاص بـ ItemSerialNumber
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// SerialNumber of the ItemSerialNumber
    /// SerialNumber الخاص بـ ItemSerialNumber
    /// </summary>
    public string SerialNumber { get; private set; }

    /// <summary>
    /// DescNo of the ItemSerialNumber
    /// DescNo الخاص بـ ItemSerialNumber
    /// </summary>
    public decimal? DescNo { get; private set; }

    /// <summary>
    /// CostCenterCode of the ItemSerialNumber
    /// CostCenterCode الخاص بـ ItemSerialNumber
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the ItemSerialNumber
    /// ProjectNumber الخاص بـ ItemSerialNumber
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ExpireDate of the ItemSerialNumber
    /// ExpireDate الخاص بـ ItemSerialNumber
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the ItemSerialNumber
    /// BatchNumber الخاص بـ ItemSerialNumber
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// FreeFlag of the ItemSerialNumber
    /// FreeFlag الخاص بـ ItemSerialNumber
    /// </summary>
    public decimal? FreeFlag { get; private set; }

    /// <summary>
    /// BillCost of the ItemSerialNumber
    /// BillCost الخاص بـ ItemSerialNumber
    /// </summary>
    public decimal? BillCost { get; private set; }

    /// <summary>
    /// OutgoingNumber of the ItemSerialNumber
    /// OutgoingNumber الخاص بـ ItemSerialNumber
    /// </summary>
    public decimal? OutgoingNumber { get; private set; }

    /// <summary>
    /// OutgoingGroupSerial of the ItemSerialNumber
    /// OutgoingGroupSerial الخاص بـ ItemSerialNumber
    /// </summary>
    public decimal? OutgoingGroupSerial { get; private set; }

    /// <summary>
    /// InOutFlag of the ItemSerialNumber
    /// InOutFlag الخاص بـ ItemSerialNumber
    /// </summary>
    public decimal? InOutFlag { get; private set; }

    /// <summary>
    /// RecordNumber of the ItemSerialNumber
    /// RecordNumber الخاص بـ ItemSerialNumber
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// RecordNumberDocument of the ItemSerialNumber
    /// RecordNumberDocument الخاص بـ ItemSerialNumber
    /// </summary>
    public decimal? RecordNumberDocument { get; private set; }

    /// <summary>
    /// ActiveFlag of the ItemSerialNumber
    /// ActiveFlag الخاص بـ ItemSerialNumber
    /// </summary>
    public decimal? ActiveFlag { get; private set; }

    /// <summary>
    /// ActiveUserId of the ItemSerialNumber
    /// ActiveUserId الخاص بـ ItemSerialNumber
    /// </summary>
    public decimal? ActiveUserId { get; private set; }

    /// <summary>
    /// ActiveDate of the ItemSerialNumber
    /// ActiveDate الخاص بـ ItemSerialNumber
    /// </summary>
    public DateTime? ActiveDate { get; private set; }

    /// <summary>
    /// ActiveNote of the ItemSerialNumber
    /// ActiveNote الخاص بـ ItemSerialNumber
    /// </summary>
    public string ActiveNote { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the ItemSerialNumber
    /// ExternalPostFlag الخاص بـ ItemSerialNumber
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ItemSerialNumber
    /// CompanyNumberShort الخاص بـ ItemSerialNumber
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ItemSerialNumber
    /// BranchNumber الخاص بـ ItemSerialNumber
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ItemSerialNumber
    /// BranchYear الخاص بـ ItemSerialNumber
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ItemSerialNumber
    /// BranchUser الخاص بـ ItemSerialNumber
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// QrCode of the ItemSerialNumber
    /// QrCode الخاص بـ ItemSerialNumber
    /// </summary>
    public string QrCode { get; private set; }

    /// <summary>
    /// SerialSequence of the ItemSerialNumber
    /// SerialSequence الخاص بـ ItemSerialNumber
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
    public ItemDetail ItemDetail { get; private set; }
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
