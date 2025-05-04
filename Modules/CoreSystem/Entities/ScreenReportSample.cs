using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// ScreenReportSample Entity
/// </summary>
public class ScreenReportSample : Entity<ScreenReportSampleId>
{
    private ScreenReportSample() { }

    /// <summary>
    /// The unique identifier for the ScreenReportSample
    /// المعرف الفريد لـ ScreenReportSample
    /// </summary>
    public ScreenReportSampleId Id { get; private set; }

    /// <summary>
    /// FormNumber of the ScreenReportSample
    /// FormNumber الخاص بـ ScreenReportSample
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// SampleNumber of the ScreenReportSample
    /// SampleNumber الخاص بـ ScreenReportSample
    /// </summary>
    public decimal? SampleNumber { get; private set; }

    /// <summary>
    /// SampleLastName of the ScreenReportSample
    /// SampleLastName الخاص بـ ScreenReportSample
    /// </summary>
    public string SampleLastName { get; private set; }

    /// <summary>
    /// SampleFirstName of the ScreenReportSample
    /// SampleFirstName الخاص بـ ScreenReportSample
    /// </summary>
    public string SampleFirstName { get; private set; }

    /// <summary>
    /// SampleStatus of the ScreenReportSample
    /// SampleStatus الخاص بـ ScreenReportSample
    /// </summary>
    public decimal? SampleStatus { get; private set; }

    /// <summary>
    /// SampleOrder of the ScreenReportSample
    /// SampleOrder الخاص بـ ScreenReportSample
    /// </summary>
    public decimal? SampleOrder { get; private set; }
}
}
