using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.ProductionManufacturing.ValueObjects;
namespace ERP_Pro.Domain.ERP.ProductionManufacturing.Entities
{
/// <summary>
/// AssembleItemExpand Entity
/// </summary>
public class AssembleItemExpand : Entity<AssembleItemExpandId>
{

    private AssembleItemExpand() { }

    public AssembleItemExpand(AssembleItemExpandId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AssembleItemExpand
    /// المعرف الفريد لـ AssembleItemExpand
    /// </summary>
    public AssembleItemExpandId Id { get; private set; }

    /// <summary>
    /// DocNo of the AssembleItemExpand
    /// DocNo الخاص بـ AssembleItemExpand
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocDesc of the AssembleItemExpand
    /// DocDesc الخاص بـ AssembleItemExpand
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the AssembleItemExpand
    /// ReferenceNumber الخاص بـ AssembleItemExpand
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// AccountCode of the AssembleItemExpand
    /// AccountCode الخاص بـ AssembleItemExpand
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the AssembleItemExpand
    /// AccountDetailCode الخاص بـ AssembleItemExpand
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the AssembleItemExpand
    /// AccountDetailType الخاص بـ AssembleItemExpand
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCurrency of the AssembleItemExpand
    /// AccountCurrency الخاص بـ AssembleItemExpand
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the AssembleItemExpand
    /// AccountRate الخاص بـ AssembleItemExpand
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// CostCenterCode of the AssembleItemExpand
    /// CostCenterCode الخاص بـ AssembleItemExpand
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the AssembleItemExpand
    /// ProjectNumber الخاص بـ AssembleItemExpand
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the AssembleItemExpand
    /// ActivityNumber الخاص بـ AssembleItemExpand
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// Amount of the AssembleItemExpand
    /// Amount الخاص بـ AssembleItemExpand
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// InvoiceAmount of the AssembleItemExpand
    /// InvoiceAmount الخاص بـ AssembleItemExpand
    /// </summary>
    public decimal? InvoiceAmount { get; private set; }

    /// <summary>
    /// RecordNumber of the AssembleItemExpand
    /// RecordNumber الخاص بـ AssembleItemExpand
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// BranchNumber of the AssembleItemExpand
    /// BranchNumber الخاص بـ AssembleItemExpand
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AssembleItemExpand
    /// BranchYear الخاص بـ AssembleItemExpand
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AssembleItemExpand
    /// BranchUser الخاص بـ AssembleItemExpand
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AssembleItemExpand
    /// CompanyNumberShort الخاص بـ AssembleItemExpand
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AssembleKitItem AssembleKitItem { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

