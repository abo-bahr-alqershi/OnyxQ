using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// CheckIncomeMaster Entity
/// </summary>
public class CheckIncomeMaster : Entity<CheckIncomeMasterId>
{

    private CheckIncomeMaster() { }

    public CheckIncomeMaster(CheckIncomeMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the CheckIncomeMaster
    /// المعرف الفريد لـ CheckIncomeMaster
    /// </summary>
    public CheckIncomeMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the CheckIncomeMaster
    /// DocNo الخاص بـ CheckIncomeMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the CheckIncomeMaster
    /// DocSer الخاص بـ CheckIncomeMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocType of the CheckIncomeMaster
    /// DocType الخاص بـ CheckIncomeMaster
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// DocDate of the CheckIncomeMaster
    /// DocDate الخاص بـ CheckIncomeMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AccountDetailCode of the CheckIncomeMaster
    /// AccountDetailCode الخاص بـ CheckIncomeMaster
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the CheckIncomeMaster
    /// AccountDetailType الخاص بـ CheckIncomeMaster
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// VendorCode of the CheckIncomeMaster
    /// VendorCode الخاص بـ CheckIncomeMaster
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// VendorName of the CheckIncomeMaster
    /// VendorName الخاص بـ CheckIncomeMaster
    /// </summary>
    public string VendorName { get; private set; }

    /// <summary>
    /// WarehouseCode of the CheckIncomeMaster
    /// WarehouseCode الخاص بـ CheckIncomeMaster
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// ReferenceNumber of the CheckIncomeMaster
    /// ReferenceNumber الخاص بـ CheckIncomeMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DocDesc of the CheckIncomeMaster
    /// DocDesc الخاص بـ CheckIncomeMaster
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// CostCenterCode of the CheckIncomeMaster
    /// CostCenterCode الخاص بـ CheckIncomeMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the CheckIncomeMaster
    /// ProjectNumber الخاص بـ CheckIncomeMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the CheckIncomeMaster
    /// ActivityNumber الخاص بـ CheckIncomeMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the CheckIncomeMaster
    /// ProcessedFlagFull الخاص بـ CheckIncomeMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CheckIncomeMaster
    /// CompanyNumberShort الخاص بـ CheckIncomeMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CheckIncomeMaster
    /// BranchNumber الخاص بـ CheckIncomeMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CheckIncomeMaster
    /// BranchYear الخاص بـ CheckIncomeMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CheckIncomeMaster
    /// BranchUser الخاص بـ CheckIncomeMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
