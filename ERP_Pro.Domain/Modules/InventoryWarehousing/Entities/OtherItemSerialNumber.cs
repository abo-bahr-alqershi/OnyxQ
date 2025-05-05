using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// OtherItemSerialNumber Entity
/// </summary>
public class OtherItemSerialNumber : Entity<OtherItemSerialNumberId>
{

    private OtherItemSerialNumber() { }

    public OtherItemSerialNumber(OtherItemSerialNumberId id, decimal? docSer, string serialNumber)
    {
        Id = id;
        DocSer = docSer;
        SerialNumber = serialNumber;
    }

    /// <summary>
    /// The unique identifier for the OtherItemSerialNumber
    /// المعرف الفريد لـ OtherItemSerialNumber
    /// </summary>
    public OtherItemSerialNumberId Id { get; private set; }

    /// <summary>
    /// DocType of the OtherItemSerialNumber
    /// DocType الخاص بـ OtherItemSerialNumber
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the OtherItemSerialNumber
    /// BillDocumentTypeFull الخاص بـ OtherItemSerialNumber
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// DocNo of the OtherItemSerialNumber
    /// DocNo الخاص بـ OtherItemSerialNumber
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the OtherItemSerialNumber
    /// DocSer الخاص بـ OtherItemSerialNumber
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the OtherItemSerialNumber
    /// DocDate الخاص بـ OtherItemSerialNumber
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// SerialNumber of the OtherItemSerialNumber
    /// SerialNumber الخاص بـ OtherItemSerialNumber
    /// </summary>
    public string SerialNumber { get; private set; }

    /// <summary>
    /// DescNo of the OtherItemSerialNumber
    /// DescNo الخاص بـ OtherItemSerialNumber
    /// </summary>
    public decimal? DescNo { get; private set; }

    /// <summary>
    /// CostCenterCode of the OtherItemSerialNumber
    /// CostCenterCode الخاص بـ OtherItemSerialNumber
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the OtherItemSerialNumber
    /// ProjectNumber الخاص بـ OtherItemSerialNumber
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ExpireDate of the OtherItemSerialNumber
    /// ExpireDate الخاص بـ OtherItemSerialNumber
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the OtherItemSerialNumber
    /// BatchNumber الخاص بـ OtherItemSerialNumber
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// FreeFlag of the OtherItemSerialNumber
    /// FreeFlag الخاص بـ OtherItemSerialNumber
    /// </summary>
    public decimal? FreeFlag { get; private set; }

    /// <summary>
    /// BillCost of the OtherItemSerialNumber
    /// BillCost الخاص بـ OtherItemSerialNumber
    /// </summary>
    public decimal? BillCost { get; private set; }

    /// <summary>
    /// OutgoingNumber of the OtherItemSerialNumber
    /// OutgoingNumber الخاص بـ OtherItemSerialNumber
    /// </summary>
    public decimal? OutgoingNumber { get; private set; }

    /// <summary>
    /// OutgoingGroupSerial of the OtherItemSerialNumber
    /// OutgoingGroupSerial الخاص بـ OtherItemSerialNumber
    /// </summary>
    public decimal? OutgoingGroupSerial { get; private set; }

    /// <summary>
    /// InOutFlag of the OtherItemSerialNumber
    /// InOutFlag الخاص بـ OtherItemSerialNumber
    /// </summary>
    public decimal? InOutFlag { get; private set; }

    /// <summary>
    /// RecordNumber of the OtherItemSerialNumber
    /// RecordNumber الخاص بـ OtherItemSerialNumber
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// RecordNumberDocument of the OtherItemSerialNumber
    /// RecordNumberDocument الخاص بـ OtherItemSerialNumber
    /// </summary>
    public decimal? RecordNumberDocument { get; private set; }

    /// <summary>
    /// ActiveFlag of the OtherItemSerialNumber
    /// ActiveFlag الخاص بـ OtherItemSerialNumber
    /// </summary>
    public decimal? ActiveFlag { get; private set; }

    /// <summary>
    /// ActiveUserId of the OtherItemSerialNumber
    /// ActiveUserId الخاص بـ OtherItemSerialNumber
    /// </summary>
    public decimal? ActiveUserId { get; private set; }

    /// <summary>
    /// ActiveDate of the OtherItemSerialNumber
    /// ActiveDate الخاص بـ OtherItemSerialNumber
    /// </summary>
    public DateTime? ActiveDate { get; private set; }

    /// <summary>
    /// ActiveNote of the OtherItemSerialNumber
    /// ActiveNote الخاص بـ OtherItemSerialNumber
    /// </summary>
    public string ActiveNote { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the OtherItemSerialNumber
    /// ExternalPostFlag الخاص بـ OtherItemSerialNumber
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the OtherItemSerialNumber
    /// CompanyNumberShort الخاص بـ OtherItemSerialNumber
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the OtherItemSerialNumber
    /// BranchNumber الخاص بـ OtherItemSerialNumber
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the OtherItemSerialNumber
    /// BranchYear الخاص بـ OtherItemSerialNumber
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the OtherItemSerialNumber
    /// BranchUser الخاص بـ OtherItemSerialNumber
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ItemUnit of the OtherItemSerialNumber
    /// ItemUnit الخاص بـ OtherItemSerialNumber
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the OtherItemSerialNumber
    /// PSize الخاص بـ OtherItemSerialNumber
    /// </summary>
    public decimal? PSize { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
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

