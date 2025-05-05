using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// IncomingOutgoingMaster Entity
/// </summary>
public class IncomingOutgoingMaster : AggregateRoot<IncomingOutgoingMasterId>
{

    private IncomingOutgoingMaster() { }

    public IncomingOutgoingMaster(IncomingOutgoingMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the IncomingOutgoingMaster
    /// المعرف الفريد لـ IncomingOutgoingMaster
    /// </summary>
    public IncomingOutgoingMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the IncomingOutgoingMaster
    /// DocNo الخاص بـ IncomingOutgoingMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the IncomingOutgoingMaster
    /// DocSer الخاص بـ IncomingOutgoingMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocType of the IncomingOutgoingMaster
    /// DocType الخاص بـ IncomingOutgoingMaster
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// DocDate of the IncomingOutgoingMaster
    /// DocDate الخاص بـ IncomingOutgoingMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AccountCurrency of the IncomingOutgoingMaster
    /// AccountCurrency الخاص بـ IncomingOutgoingMaster
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the IncomingOutgoingMaster
    /// AccountRate الخاص بـ IncomingOutgoingMaster
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// StockRateShort of the IncomingOutgoingMaster
    /// StockRateShort الخاص بـ IncomingOutgoingMaster
    /// </summary>
    public decimal? StockRateShort { get; private set; }

    /// <summary>
    /// AccountCode of the IncomingOutgoingMaster
    /// AccountCode الخاص بـ IncomingOutgoingMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the IncomingOutgoingMaster
    /// AccountDetailCode الخاص بـ IncomingOutgoingMaster
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the IncomingOutgoingMaster
    /// AccountDetailType الخاص بـ IncomingOutgoingMaster
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// VendorCode of the IncomingOutgoingMaster
    /// VendorCode الخاص بـ IncomingOutgoingMaster
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// DocDueDate of the IncomingOutgoingMaster
    /// DocDueDate الخاص بـ IncomingOutgoingMaster
    /// </summary>
    public DateTime? DocDueDate { get; private set; }

    /// <summary>
    /// DocAmt of the IncomingOutgoingMaster
    /// DocAmt الخاص بـ IncomingOutgoingMaster
    /// </summary>
    public decimal? DocAmt { get; private set; }

    /// <summary>
    /// ReceiverName of the IncomingOutgoingMaster
    /// ReceiverName الخاص بـ IncomingOutgoingMaster
    /// </summary>
    public string ReceiverName { get; private set; }

    /// <summary>
    /// ReferenceNumber of the IncomingOutgoingMaster
    /// ReferenceNumber الخاص بـ IncomingOutgoingMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// AccountDescription of the IncomingOutgoingMaster
    /// AccountDescription الخاص بـ IncomingOutgoingMaster
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// CName of the IncomingOutgoingMaster
    /// CName الخاص بـ IncomingOutgoingMaster
    /// </summary>
    public string CName { get; private set; }

    /// <summary>
    /// RegionCode of the IncomingOutgoingMaster
    /// RegionCode الخاص بـ IncomingOutgoingMaster
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// RepCode of the IncomingOutgoingMaster
    /// RepCode الخاص بـ IncomingOutgoingMaster
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the IncomingOutgoingMaster
    /// ExternalPostFlag الخاص بـ IncomingOutgoingMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the IncomingOutgoingMaster
    /// ProcessedFlagFull الخاص بـ IncomingOutgoingMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// BranchNumber of the IncomingOutgoingMaster
    /// BranchNumber الخاص بـ IncomingOutgoingMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the IncomingOutgoingMaster
    /// BranchYear الخاص بـ IncomingOutgoingMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the IncomingOutgoingMaster
    /// CompanyNumberShort الخاص بـ IncomingOutgoingMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchUser of the IncomingOutgoingMaster
    /// BranchUser الخاص بـ IncomingOutgoingMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Customer Customer { get; private set; }
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

