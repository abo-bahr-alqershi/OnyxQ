using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TaxFees.Entities
{
/// <summary>
/// GstReportDetail Entity
/// </summary>
public class GstReportDetail : Entity<GstReportDetailId>
{

    private GstReportDetail() { }

    public GstReportDetail(GstReportDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the GstReportDetail
    /// المعرف الفريد لـ GstReportDetail
    /// </summary>
    public GstReportDetailId Id { get; private set; }

    /// <summary>
    /// R1Column of the GstReportDetail
    /// R1Column الخاص بـ GstReportDetail
    /// </summary>
    public string R1Column { get; private set; }

    /// <summary>
    /// R2Column of the GstReportDetail
    /// R2Column الخاص بـ GstReportDetail
    /// </summary>
    public string R2Column { get; private set; }

    /// <summary>
    /// R3Column of the GstReportDetail
    /// R3Column الخاص بـ GstReportDetail
    /// </summary>
    public string R3Column { get; private set; }

    /// <summary>
    /// R4Number of the GstReportDetail
    /// R4Number الخاص بـ GstReportDetail
    /// </summary>
    public decimal? R4Number { get; private set; }

    /// <summary>
    /// R5Date of the GstReportDetail
    /// R5Date الخاص بـ GstReportDetail
    /// </summary>
    public DateTime? R5Date { get; private set; }

    /// <summary>
    /// R6Number of the GstReportDetail
    /// R6Number الخاص بـ GstReportDetail
    /// </summary>
    public decimal? R6Number { get; private set; }

    /// <summary>
    /// R7Column of the GstReportDetail
    /// R7Column الخاص بـ GstReportDetail
    /// </summary>
    public string R7Column { get; private set; }

    /// <summary>
    /// R8Column of the GstReportDetail
    /// R8Column الخاص بـ GstReportDetail
    /// </summary>
    public string R8Column { get; private set; }

    /// <summary>
    /// R9Column of the GstReportDetail
    /// R9Column الخاص بـ GstReportDetail
    /// </summary>
    public string R9Column { get; private set; }

    /// <summary>
    /// R10Column of the GstReportDetail
    /// R10Column الخاص بـ GstReportDetail
    /// </summary>
    public string R10Column { get; private set; }

    /// <summary>
    /// R11Column of the GstReportDetail
    /// R11Column الخاص بـ GstReportDetail
    /// </summary>
    public string R11Column { get; private set; }

    /// <summary>
    /// R12Number of the GstReportDetail
    /// R12Number الخاص بـ GstReportDetail
    /// </summary>
    public decimal? R12Number { get; private set; }

    /// <summary>
    /// R13Number of the GstReportDetail
    /// R13Number الخاص بـ GstReportDetail
    /// </summary>
    public decimal? R13Number { get; private set; }

    /// <summary>
    /// R14Number of the GstReportDetail
    /// R14Number الخاص بـ GstReportDetail
    /// </summary>
    public decimal? R14Number { get; private set; }

    /// <summary>
    /// R15Number of the GstReportDetail
    /// R15Number الخاص بـ GstReportDetail
    /// </summary>
    public decimal? R15Number { get; private set; }

    /// <summary>
    /// R16Number of the GstReportDetail
    /// R16Number الخاص بـ GstReportDetail
    /// </summary>
    public decimal? R16Number { get; private set; }

    /// <summary>
    /// R17Number of the GstReportDetail
    /// R17Number الخاص بـ GstReportDetail
    /// </summary>
    public decimal? R17Number { get; private set; }

    /// <summary>
    /// R18Number of the GstReportDetail
    /// R18Number الخاص بـ GstReportDetail
    /// </summary>
    public decimal? R18Number { get; private set; }

    /// <summary>
    /// R19Number of the GstReportDetail
    /// R19Number الخاص بـ GstReportDetail
    /// </summary>
    public decimal? R19Number { get; private set; }

    /// <summary>
    /// R20Number of the GstReportDetail
    /// R20Number الخاص بـ GstReportDetail
    /// </summary>
    public decimal? R20Number { get; private set; }

    /// <summary>
    /// R22Number of the GstReportDetail
    /// R22Number الخاص بـ GstReportDetail
    /// </summary>
    public decimal? R22Number { get; private set; }

    /// <summary>
    /// R23Number of the GstReportDetail
    /// R23Number الخاص بـ GstReportDetail
    /// </summary>
    public decimal? R23Number { get; private set; }

    /// <summary>
    /// R24Column of the GstReportDetail
    /// R24Column الخاص بـ GstReportDetail
    /// </summary>
    public string R24Column { get; private set; }

    /// <summary>
    /// R25Column of the GstReportDetail
    /// R25Column الخاص بـ GstReportDetail
    /// </summary>
    public string R25Column { get; private set; }

    /// <summary>
    /// R21Column of the GstReportDetail
    /// R21Column الخاص بـ GstReportDetail
    /// </summary>
    public string R21Column { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
