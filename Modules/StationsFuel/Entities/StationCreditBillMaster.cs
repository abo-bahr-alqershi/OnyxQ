using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.StationsFuel.Entities
{
/// <summary>
/// StationCreditBillMaster Entity
/// </summary>
public class StationCreditBillMaster : Entity<StationCreditBillMasterId>
{
    private StationCreditBillMaster() { }

    /// <summary>
    /// The unique identifier for the StationCreditBillMaster
    /// المعرف الفريد لـ StationCreditBillMaster
    /// </summary>
    public StationCreditBillMasterId Id { get; private set; }

    /// <summary>
    /// DocSer of the StationCreditBillMaster
    /// DocSer الخاص بـ StationCreditBillMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the StationCreditBillMaster
    /// DocDate الخاص بـ StationCreditBillMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// FuelTypeNumber of the StationCreditBillMaster
    /// FuelTypeNumber الخاص بـ StationCreditBillMaster
    /// </summary>
    public decimal? FuelTypeNumber { get; private set; }

    /// <summary>
    /// DocNo of the StationCreditBillMaster
    /// DocNo الخاص بـ StationCreditBillMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// FBillNumber of the StationCreditBillMaster
    /// FBillNumber الخاص بـ StationCreditBillMaster
    /// </summary>
    public decimal? FBillNumber { get; private set; }

    /// <summary>
    /// TBillNumber of the StationCreditBillMaster
    /// TBillNumber الخاص بـ StationCreditBillMaster
    /// </summary>
    public decimal? TBillNumber { get; private set; }

    /// <summary>
    /// ReferenceNumber of the StationCreditBillMaster
    /// ReferenceNumber الخاص بـ StationCreditBillMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DocDsc of the StationCreditBillMaster
    /// DocDsc الخاص بـ StationCreditBillMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// CCode of the StationCreditBillMaster
    /// CCode الخاص بـ StationCreditBillMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// IssueDate of the StationCreditBillMaster
    /// IssueDate الخاص بـ StationCreditBillMaster
    /// </summary>
    public DateTime? IssueDate { get; private set; }

    /// <summary>
    /// ExpireDate of the StationCreditBillMaster
    /// ExpireDate الخاص بـ StationCreditBillMaster
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// TFuelTypeNumber of the StationCreditBillMaster
    /// TFuelTypeNumber الخاص بـ StationCreditBillMaster
    /// </summary>
    public decimal? TFuelTypeNumber { get; private set; }

    /// <summary>
    /// MoveDocumentPaymentYear of the StationCreditBillMaster
    /// MoveDocumentPaymentYear الخاص بـ StationCreditBillMaster
    /// </summary>
    public decimal? MoveDocumentPaymentYear { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the StationCreditBillMaster
    /// CompanyNumberShort الخاص بـ StationCreditBillMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the StationCreditBillMaster
    /// BranchNumber الخاص بـ StationCreditBillMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the StationCreditBillMaster
    /// BranchYear الخاص بـ StationCreditBillMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the StationCreditBillMaster
    /// BranchUser الخاص بـ StationCreditBillMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: StationCreditBillMaster to StationCreditBillDetail
    /// </summary>
    public IReadOnlyCollection<StationCreditBillDetail> StationCreditBillDetails { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Customer
    /// </summary>
    public Customer Customer { get; private set; }
    #endregion
}
}
