using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// كيان يمثل عينة تقرير الشاشة ويحتوي على جميع خصائص العينة المرتبطة بالنماذج والتقارير.
/// </summary>
public class ScreenReportSample : Entity<ScreenReportSampleId>
{

    private ScreenReportSample() { }

    public ScreenReportSample(ScreenReportSampleId id, decimal? formNumber, decimal? sampleNumber)
    {
        Id = id;
        FormNumber = formNumber;
        SampleNumber = sampleNumber;
    }

    /// <summary>
    /// المعرف الفريد لعينة تقرير الشاشة (مفتاح رئيسي).
    /// </summary>
    public ScreenReportSampleId Id { get; private set; }

    /// <summary>
    /// رقم النموذج المرتبط بالعينة.
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// رقم العينة.
    /// </summary>
    public decimal? SampleNumber { get; private set; }

    /// <summary>
    /// الاسم الأخير للعينة.
    /// </summary>
    public string SampleLastName { get; private set; }

    /// <summary>
    /// الاسم الأول للعينة.
    /// </summary>
    public string SampleFirstName { get; private set; }

    /// <summary>
    /// حالة العينة.
    /// </summary>
    public decimal? SampleStatus { get; private set; }

    /// <summary>
    /// ترتيب العينة.
    /// </summary>
    public decimal? SampleOrder { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
