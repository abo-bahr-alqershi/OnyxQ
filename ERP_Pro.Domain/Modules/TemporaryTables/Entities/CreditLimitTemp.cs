using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;
namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// CreditLimitTemp Entity
/// </summary>
public class CreditLimitTemp : Entity<CreditLimitTempId>
{

    private CreditLimitTemp() { }

    public CreditLimitTemp(CreditLimitTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the CreditLimitTemp
    /// المعرف الفريد لـ CreditLimitTemp
    /// </summary>
    public CreditLimitTempId Id { get; private set; }

    /// <summary>
    /// CCode of the CreditLimitTemp
    /// CCode الخاص بـ CreditLimitTemp
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the CreditLimitTemp
    /// AccountCurrency الخاص بـ CreditLimitTemp
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// DocNo of the CreditLimitTemp
    /// DocNo الخاص بـ CreditLimitTemp
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocType of the CreditLimitTemp
    /// DocType الخاص بـ CreditLimitTemp
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// DocJvType of the CreditLimitTemp
    /// DocJvType الخاص بـ CreditLimitTemp
    /// </summary>
    public decimal? DocJvType { get; private set; }

    /// <summary>
    /// DocSer of the CreditLimitTemp
    /// DocSer الخاص بـ CreditLimitTemp
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the CreditLimitTemp
    /// DocDate الخاص بـ CreditLimitTemp
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DrAmt of the CreditLimitTemp
    /// DrAmt الخاص بـ CreditLimitTemp
    /// </summary>
    public decimal? DrAmt { get; private set; }

    /// <summary>
    /// DrAmtf of the CreditLimitTemp
    /// DrAmtf الخاص بـ CreditLimitTemp
    /// </summary>
    public decimal? DrAmtf { get; private set; }

    /// <summary>
    /// DocDesc of the CreditLimitTemp
    /// DocDesc الخاص بـ CreditLimitTemp
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the CreditLimitTemp
    /// ReferenceNumber الخاص بـ CreditLimitTemp
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the CreditLimitTemp
    /// RecordNumber الخاص بـ CreditLimitTemp
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the CreditLimitTemp
    /// CostCenterCode الخاص بـ CreditLimitTemp
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the CreditLimitTemp
    /// ProjectNumber الخاص بـ CreditLimitTemp
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the CreditLimitTemp
    /// ActivityNumber الخاص بـ CreditLimitTemp
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ChequeValuedFlag of the CreditLimitTemp
    /// ChequeValuedFlag الخاص بـ CreditLimitTemp
    /// </summary>
    public decimal? ChequeValuedFlag { get; private set; }

    /// <summary>
    /// PeriodNumber of the CreditLimitTemp
    /// PeriodNumber الخاص بـ CreditLimitTemp
    /// </summary>
    public decimal? PeriodNumber { get; private set; }

    /// <summary>
    /// TerminalName of the CreditLimitTemp
    /// TerminalName الخاص بـ CreditLimitTemp
    /// </summary>
    public string TerminalName { get; private set; }

    /// <summary>
    /// DocDueDate of the CreditLimitTemp
    /// DocDueDate الخاص بـ CreditLimitTemp
    /// </summary>
    public DateTime? DocDueDate { get; private set; }

    /// <summary>
    /// DocTypeRef of the CreditLimitTemp
    /// DocTypeRef الخاص بـ CreditLimitTemp
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// PaidDate of the CreditLimitTemp
    /// PaidDate الخاص بـ CreditLimitTemp
    /// </summary>
    public DateTime? PaidDate { get; private set; }

    /// <summary>
    /// RepCode of the CreditLimitTemp
    /// RepCode الخاص بـ CreditLimitTemp
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// CommissionAmount of the CreditLimitTemp
    /// CommissionAmount الخاص بـ CreditLimitTemp
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the CreditLimitTemp
    /// ColumnNumberShort الخاص بـ CreditLimitTemp
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// DocNoRef of the CreditLimitTemp
    /// DocNoRef الخاص بـ CreditLimitTemp
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the CreditLimitTemp
    /// DocSerRef الخاص بـ CreditLimitTemp
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CreditLimitTemp
    /// CompanyNumberShort الخاص بـ CreditLimitTemp
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CreditLimitTemp
    /// BranchNumber الخاص بـ CreditLimitTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CreditLimitTemp
    /// BranchYear الخاص بـ CreditLimitTemp
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CreditLimitTemp
    /// BranchUser الخاص بـ CreditLimitTemp
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

