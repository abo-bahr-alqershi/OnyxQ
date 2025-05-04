using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.HumanResources.Entities;

namespace ERP_Pro.Domain.ERP.StationsFuel.Entities
{
/// <summary>
/// StationJournalDiffEmployeeDetail Entity
/// </summary>
public class StationJournalDiffEmployeeDetail : Entity<StationJournalDiffEmployeeDetailId>
{
    private StationJournalDiffEmployeeDetail() { }

    /// <summary>
    /// The unique identifier for the StationJournalDiffEmployeeDetail
    /// المعرف الفريد لـ StationJournalDiffEmployeeDetail
    /// </summary>
    public StationJournalDiffEmployeeDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the StationJournalDiffEmployeeDetail
    /// DocNo الخاص بـ StationJournalDiffEmployeeDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the StationJournalDiffEmployeeDetail
    /// DocSer الخاص بـ StationJournalDiffEmployeeDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// AccountCode of the StationJournalDiffEmployeeDetail
    /// AccountCode الخاص بـ StationJournalDiffEmployeeDetail
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the StationJournalDiffEmployeeDetail
    /// AccountCurrency الخاص بـ StationJournalDiffEmployeeDetail
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// DocDsc of the StationJournalDiffEmployeeDetail
    /// DocDsc الخاص بـ StationJournalDiffEmployeeDetail
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// DrAmt of the StationJournalDiffEmployeeDetail
    /// DrAmt الخاص بـ StationJournalDiffEmployeeDetail
    /// </summary>
    public decimal? DrAmt { get; private set; }

    /// <summary>
    /// CreditAmount of the StationJournalDiffEmployeeDetail
    /// CreditAmount الخاص بـ StationJournalDiffEmployeeDetail
    /// </summary>
    public decimal? CreditAmount { get; private set; }

    /// <summary>
    /// AccountRate of the StationJournalDiffEmployeeDetail
    /// AccountRate الخاص بـ StationJournalDiffEmployeeDetail
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// JournalDocumentNumber of the StationJournalDiffEmployeeDetail
    /// JournalDocumentNumber الخاص بـ StationJournalDiffEmployeeDetail
    /// </summary>
    public decimal? JournalDocumentNumber { get; private set; }

    /// <summary>
    /// JournalDocumentSerial of the StationJournalDiffEmployeeDetail
    /// JournalDocumentSerial الخاص بـ StationJournalDiffEmployeeDetail
    /// </summary>
    public decimal? JournalDocumentSerial { get; private set; }

    /// <summary>
    /// EmpNo of the StationJournalDiffEmployeeDetail
    /// EmpNo الخاص بـ StationJournalDiffEmployeeDetail
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// RecordNumber of the StationJournalDiffEmployeeDetail
    /// RecordNumber الخاص بـ StationJournalDiffEmployeeDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// AccountDetailCode of the StationJournalDiffEmployeeDetail
    /// AccountDetailCode الخاص بـ StationJournalDiffEmployeeDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the StationJournalDiffEmployeeDetail
    /// CostCenterCode الخاص بـ StationJournalDiffEmployeeDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the StationJournalDiffEmployeeDetail
    /// ProjectNumber الخاص بـ StationJournalDiffEmployeeDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the StationJournalDiffEmployeeDetail
    /// ActivityNumber الخاص بـ StationJournalDiffEmployeeDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// NetAmountSale of the StationJournalDiffEmployeeDetail
    /// NetAmountSale الخاص بـ StationJournalDiffEmployeeDetail
    /// </summary>
    public decimal? NetAmountSale { get; private set; }

    /// <summary>
    /// NetAmountValue of the StationJournalDiffEmployeeDetail
    /// NetAmountValue الخاص بـ StationJournalDiffEmployeeDetail
    /// </summary>
    public decimal? NetAmountValue { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the StationJournalDiffEmployeeDetail
    /// CompanyNumberShort الخاص بـ StationJournalDiffEmployeeDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the StationJournalDiffEmployeeDetail
    /// BranchNumber الخاص بـ StationJournalDiffEmployeeDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the StationJournalDiffEmployeeDetail
    /// BranchYear الخاص بـ StationJournalDiffEmployeeDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the StationJournalDiffEmployeeDetail
    /// BranchUser الخاص بـ StationJournalDiffEmployeeDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Employee
    /// </summary>
    public Employee Employee { get; private set; }
    /// <summary>
    /// ManyToOne relationship to StationJournalDiffEmployeeMaster
    /// </summary>
    public StationJournalDiffEmployeeMaster StationJournalDiffEmployeeMaster { get; private set; }
    #endregion
}
}
