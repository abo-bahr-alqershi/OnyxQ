using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// AuditReportTemp Entity
/// </summary>
public class AuditReportTemp : Entity<AuditReportTempId>
{

    private AuditReportTemp() { }

    public AuditReportTemp(AuditReportTempId id, decimal? repSerial)
    {
        Id = id;
        RepSerial = repSerial;
    }

    /// <summary>
    /// The unique identifier for the AuditReportTemp
    /// المعرف الفريد لـ AuditReportTemp
    /// </summary>
    public AuditReportTempId Id { get; private set; }

    /// <summary>
    /// FSystemNumber of the AuditReportTemp
    /// FSystemNumber الخاص بـ AuditReportTemp
    /// </summary>
    public decimal? FSystemNumber { get; private set; }

    /// <summary>
    /// PostType of the AuditReportTemp
    /// PostType الخاص بـ AuditReportTemp
    /// </summary>
    public decimal? PostType { get; private set; }

    /// <summary>
    /// GroupType of the AuditReportTemp
    /// GroupType الخاص بـ AuditReportTemp
    /// </summary>
    public decimal? GroupType { get; private set; }

    /// <summary>
    /// GroupBy of the AuditReportTemp
    /// GroupBy الخاص بـ AuditReportTemp
    /// </summary>
    public decimal? GroupBy { get; private set; }

    /// <summary>
    /// SumDetail of the AuditReportTemp
    /// SumDetail الخاص بـ AuditReportTemp
    /// </summary>
    public decimal? SumDetail { get; private set; }

    /// <summary>
    /// RepType of the AuditReportTemp
    /// RepType الخاص بـ AuditReportTemp
    /// </summary>
    public decimal? RepType { get; private set; }

    /// <summary>
    /// RepSerial of the AuditReportTemp
    /// RepSerial الخاص بـ AuditReportTemp
    /// </summary>
    public decimal? RepSerial { get; private set; }

    /// <summary>
    /// RepName of the AuditReportTemp
    /// RepName الخاص بـ AuditReportTemp
    /// </summary>
    public string RepName { get; private set; }

    /// <summary>
    /// ColumnMaster of the AuditReportTemp
    /// ColumnMaster الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnMaster { get; private set; }

    /// <summary>
    /// ColumnMaster0 of the AuditReportTemp
    /// ColumnMaster0 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnMaster0 { get; private set; }

    /// <summary>
    /// ColumnMaster1 of the AuditReportTemp
    /// ColumnMaster1 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnMaster1 { get; private set; }

    /// <summary>
    /// ColumnMaster2 of the AuditReportTemp
    /// ColumnMaster2 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnMaster2 { get; private set; }

    /// <summary>
    /// ColumnMaster3 of the AuditReportTemp
    /// ColumnMaster3 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnMaster3 { get; private set; }

    /// <summary>
    /// ColumnMaster4 of the AuditReportTemp
    /// ColumnMaster4 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnMaster4 { get; private set; }

    /// <summary>
    /// ColumnMaster5 of the AuditReportTemp
    /// ColumnMaster5 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnMaster5 { get; private set; }

    /// <summary>
    /// ColumnMaster6 of the AuditReportTemp
    /// ColumnMaster6 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnMaster6 { get; private set; }

    /// <summary>
    /// ColumnMaster7 of the AuditReportTemp
    /// ColumnMaster7 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnMaster7 { get; private set; }

    /// <summary>
    /// ColumnMaster8 of the AuditReportTemp
    /// ColumnMaster8 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnMaster8 { get; private set; }

    /// <summary>
    /// ColumnMaster9 of the AuditReportTemp
    /// ColumnMaster9 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnMaster9 { get; private set; }

    /// <summary>
    /// PFromMaster of the AuditReportTemp
    /// PFromMaster الخاص بـ AuditReportTemp
    /// </summary>
    public string PFromMaster { get; private set; }

    /// <summary>
    /// PWhereMaster of the AuditReportTemp
    /// PWhereMaster الخاص بـ AuditReportTemp
    /// </summary>
    public string PWhereMaster { get; private set; }

    /// <summary>
    /// PGroupBy of the AuditReportTemp
    /// PGroupBy الخاص بـ AuditReportTemp
    /// </summary>
    public string PGroupBy { get; private set; }

    /// <summary>
    /// ColumnDetail of the AuditReportTemp
    /// ColumnDetail الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnDetail { get; private set; }

    /// <summary>
    /// ColumnDetail0 of the AuditReportTemp
    /// ColumnDetail0 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnDetail0 { get; private set; }

    /// <summary>
    /// ColumnDetail1 of the AuditReportTemp
    /// ColumnDetail1 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnDetail1 { get; private set; }

    /// <summary>
    /// ColumnDetail2 of the AuditReportTemp
    /// ColumnDetail2 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnDetail2 { get; private set; }

    /// <summary>
    /// ColumnDetail3 of the AuditReportTemp
    /// ColumnDetail3 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnDetail3 { get; private set; }

    /// <summary>
    /// ColumnDetail4 of the AuditReportTemp
    /// ColumnDetail4 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnDetail4 { get; private set; }

    /// <summary>
    /// ColumnDetail5 of the AuditReportTemp
    /// ColumnDetail5 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnDetail5 { get; private set; }

    /// <summary>
    /// ColumnDetail6 of the AuditReportTemp
    /// ColumnDetail6 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnDetail6 { get; private set; }

    /// <summary>
    /// ColumnDetail7 of the AuditReportTemp
    /// ColumnDetail7 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnDetail7 { get; private set; }

    /// <summary>
    /// ColumnDetail8 of the AuditReportTemp
    /// ColumnDetail8 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnDetail8 { get; private set; }

    /// <summary>
    /// ColumnDetail9 of the AuditReportTemp
    /// ColumnDetail9 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnDetail9 { get; private set; }

    /// <summary>
    /// ColumnDetail10 of the AuditReportTemp
    /// ColumnDetail10 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnDetail10 { get; private set; }

    /// <summary>
    /// ColumnDetail11 of the AuditReportTemp
    /// ColumnDetail11 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnDetail11 { get; private set; }

    /// <summary>
    /// ColumnDetail12 of the AuditReportTemp
    /// ColumnDetail12 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnDetail12 { get; private set; }

    /// <summary>
    /// ColumnDetail13 of the AuditReportTemp
    /// ColumnDetail13 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnDetail13 { get; private set; }

    /// <summary>
    /// ColumnDetail14 of the AuditReportTemp
    /// ColumnDetail14 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnDetail14 { get; private set; }

    /// <summary>
    /// ColumnDetail15 of the AuditReportTemp
    /// ColumnDetail15 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnDetail15 { get; private set; }

    /// <summary>
    /// ColumnDetail16 of the AuditReportTemp
    /// ColumnDetail16 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnDetail16 { get; private set; }

    /// <summary>
    /// ColumnDetail17 of the AuditReportTemp
    /// ColumnDetail17 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnDetail17 { get; private set; }

    /// <summary>
    /// ColumnDetail18 of the AuditReportTemp
    /// ColumnDetail18 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnDetail18 { get; private set; }

    /// <summary>
    /// ColumnDetail19 of the AuditReportTemp
    /// ColumnDetail19 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnDetail19 { get; private set; }

    /// <summary>
    /// ColumnDetail20 of the AuditReportTemp
    /// ColumnDetail20 الخاص بـ AuditReportTemp
    /// </summary>
    public string ColumnDetail20 { get; private set; }

    /// <summary>
    /// PFromDetail of the AuditReportTemp
    /// PFromDetail الخاص بـ AuditReportTemp
    /// </summary>
    public string PFromDetail { get; private set; }

    /// <summary>
    /// PWhereDetail of the AuditReportTemp
    /// PWhereDetail الخاص بـ AuditReportTemp
    /// </summary>
    public string PWhereDetail { get; private set; }

    /// <summary>
    /// PTableDetail of the AuditReportTemp
    /// PTableDetail الخاص بـ AuditReportTemp
    /// </summary>
    public string PTableDetail { get; private set; }

    /// <summary>
    /// RepSelect1 of the AuditReportTemp
    /// RepSelect1 الخاص بـ AuditReportTemp
    /// </summary>
    public string RepSelect1 { get; private set; }

    /// <summary>
    /// RepSelect2 of the AuditReportTemp
    /// RepSelect2 الخاص بـ AuditReportTemp
    /// </summary>
    public string RepSelect2 { get; private set; }

    /// <summary>
    /// RepSelect3 of the AuditReportTemp
    /// RepSelect3 الخاص بـ AuditReportTemp
    /// </summary>
    public string RepSelect3 { get; private set; }

    /// <summary>
    /// RepSelect4 of the AuditReportTemp
    /// RepSelect4 الخاص بـ AuditReportTemp
    /// </summary>
    public string RepSelect4 { get; private set; }

    /// <summary>
    /// BranchNumber of the AuditReportTemp
    /// BranchNumber الخاص بـ AuditReportTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AuditReportTemp
    /// BranchYear الخاص بـ AuditReportTemp
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AuditReportTemp
    /// CompanyNumberShort الخاص بـ AuditReportTemp
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchUser of the AuditReportTemp
    /// BranchUser الخاص بـ AuditReportTemp
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
