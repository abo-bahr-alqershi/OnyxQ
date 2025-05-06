using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;

using ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects;
namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Entities
{
/// <summary>
/// DocumentDeletion Entity
/// </summary>
public class DocumentDeletion : Entity<DocumentDeletionId>
{

    private DocumentDeletion() { }

    public DocumentDeletion(DocumentDeletionId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the DocumentDeletion
    /// المعرف الفريد لـ DocumentDeletion
    /// </summary>
    public DocumentDeletionId Id { get; private set; }

    /// <summary>
    /// FormNumber of the DocumentDeletion
    /// FormNumber الخاص بـ DocumentDeletion
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// DocType of the DocumentDeletion
    /// DocType الخاص بـ DocumentDeletion
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// DocJvType of the DocumentDeletion
    /// DocJvType الخاص بـ DocumentDeletion
    /// </summary>
    public decimal? DocJvType { get; private set; }

    /// <summary>
    /// DocNo of the DocumentDeletion
    /// DocNo الخاص بـ DocumentDeletion
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the DocumentDeletion
    /// DocSer الخاص بـ DocumentDeletion
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the DocumentDeletion
    /// DocDate الخاص بـ DocumentDeletion
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocAmt of the DocumentDeletion
    /// DocAmt الخاص بـ DocumentDeletion
    /// </summary>
    public decimal? DocAmt { get; private set; }

    /// <summary>
    /// PurchaseType of the DocumentDeletion
    /// PurchaseType الخاص بـ DocumentDeletion
    /// </summary>
    public decimal? PurchaseType { get; private set; }

    /// <summary>
    /// CostCenterCode of the DocumentDeletion
    /// CostCenterCode الخاص بـ DocumentDeletion
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the DocumentDeletion
    /// ProjectNumber الخاص بـ DocumentDeletion
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// WarehouseCode of the DocumentDeletion
    /// WarehouseCode الخاص بـ DocumentDeletion
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CashNumber of the DocumentDeletion
    /// CashNumber الخاص بـ DocumentDeletion
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// ReferenceNumber of the DocumentDeletion
    /// ReferenceNumber الخاص بـ DocumentDeletion
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DocDesc of the DocumentDeletion
    /// DocDesc الخاص بـ DocumentDeletion
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// AccountCode of the DocumentDeletion
    /// AccountCode الخاص بـ DocumentDeletion
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the DocumentDeletion
    /// AccountDetailCode الخاص بـ DocumentDeletion
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the DocumentDeletion
    /// AccountDetailType الخاص بـ DocumentDeletion
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCurrency of the DocumentDeletion
    /// AccountCurrency الخاص بـ DocumentDeletion
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// VendorCode of the DocumentDeletion
    /// VendorCode الخاص بـ DocumentDeletion
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// CCode of the DocumentDeletion
    /// CCode الخاص بـ DocumentDeletion
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// DelUId of the DocumentDeletion
    /// DelUId الخاص بـ DocumentDeletion
    /// </summary>
    public decimal? DelUId { get; private set; }

    /// <summary>
    /// DelDate of the DocumentDeletion
    /// DelDate الخاص بـ DocumentDeletion
    /// </summary>
    public DateTime? DelDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the DocumentDeletion
    /// CompanyNumberShort الخاص بـ DocumentDeletion
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the DocumentDeletion
    /// BranchNumber الخاص بـ DocumentDeletion
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchUser of the DocumentDeletion
    /// BranchUser الخاص بـ DocumentDeletion
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// BranchYear of the DocumentDeletion
    /// BranchYear الخاص بـ DocumentDeletion
    /// </summary>
    public decimal? BranchYear { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

