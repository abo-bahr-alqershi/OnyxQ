using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.Entities
{
/// <summary>
/// DisassembleKitItem Entity
/// </summary>
public class DisassembleKitItem : Entity<DisassembleKitItemId>
{

    private DisassembleKitItem() { }

    public DisassembleKitItem(DisassembleKitItemId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the DisassembleKitItem
    /// المعرف الفريد لـ DisassembleKitItem
    /// </summary>
    public DisassembleKitItemId Id { get; private set; }

    /// <summary>
    /// DocNo of the DisassembleKitItem
    /// DocNo الخاص بـ DisassembleKitItem
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the DisassembleKitItem
    /// DocSer الخاص بـ DisassembleKitItem
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the DisassembleKitItem
    /// DocDate الخاص بـ DisassembleKitItem
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// FromWarehouse of the DisassembleKitItem
    /// FromWarehouse الخاص بـ DisassembleKitItem
    /// </summary>
    public decimal? FromWarehouse { get; private set; }

    /// <summary>
    /// ToWarehouse of the DisassembleKitItem
    /// ToWarehouse الخاص بـ DisassembleKitItem
    /// </summary>
    public decimal? ToWarehouse { get; private set; }

    /// <summary>
    /// CostCenterCode of the DisassembleKitItem
    /// CostCenterCode الخاص بـ DisassembleKitItem
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// StockRate of the DisassembleKitItem
    /// StockRate الخاص بـ DisassembleKitItem
    /// </summary>
    public decimal? StockRate { get; private set; }

    /// <summary>
    /// DocDesc of the DisassembleKitItem
    /// DocDesc الخاص بـ DisassembleKitItem
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the DisassembleKitItem
    /// ReferenceNumber الخاص بـ DisassembleKitItem
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// AssetDocumentNumber of the DisassembleKitItem
    /// AssetDocumentNumber الخاص بـ DisassembleKitItem
    /// </summary>
    public decimal? AssetDocumentNumber { get; private set; }

    /// <summary>
    /// AssetDocumentSerial of the DisassembleKitItem
    /// AssetDocumentSerial الخاص بـ DisassembleKitItem
    /// </summary>
    public decimal? AssetDocumentSerial { get; private set; }

    /// <summary>
    /// DocPost of the DisassembleKitItem
    /// DocPost الخاص بـ DisassembleKitItem
    /// </summary>
    public decimal? DocPost { get; private set; }

    /// <summary>
    /// HungFlag of the DisassembleKitItem
    /// HungFlag الخاص بـ DisassembleKitItem
    /// </summary>
    public decimal? HungFlag { get; private set; }

    /// <summary>
    /// EmpNo of the DisassembleKitItem
    /// EmpNo الخاص بـ DisassembleKitItem
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// PostUserId of the DisassembleKitItem
    /// PostUserId الخاص بـ DisassembleKitItem
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the DisassembleKitItem
    /// PostDate الخاص بـ DisassembleKitItem
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the DisassembleKitItem
    /// UnpostUserId الخاص بـ DisassembleKitItem
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the DisassembleKitItem
    /// UnpostDate الخاص بـ DisassembleKitItem
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// AuditReference of the DisassembleKitItem
    /// AuditReference الخاص بـ DisassembleKitItem
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the DisassembleKitItem
    /// AuditReferenceDescription الخاص بـ DisassembleKitItem
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the DisassembleKitItem
    /// AuditReferenceUserId الخاص بـ DisassembleKitItem
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the DisassembleKitItem
    /// AuditReferenceDate الخاص بـ DisassembleKitItem
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the DisassembleKitItem
    /// CompanyNumberShort الخاص بـ DisassembleKitItem
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the DisassembleKitItem
    /// BranchNumber الخاص بـ DisassembleKitItem
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the DisassembleKitItem
    /// BranchYear الخاص بـ DisassembleKitItem
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the DisassembleKitItem
    /// BranchUser الخاص بـ DisassembleKitItem
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// TypeNumberShort of the DisassembleKitItem
    /// TypeNumberShort الخاص بـ DisassembleKitItem
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// DocSequenceM of the DisassembleKitItem
    /// DocSequenceM الخاص بـ DisassembleKitItem
    /// </summary>
    public decimal? DocSequenceM { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Project Project { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
