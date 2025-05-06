using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects;
namespace ERP_Pro.Domain.ERP.FormsSurveys.Entities
{
/// <summary>
/// ReportSampleUser Entity
/// </summary>
public class ReportSampleUser : Entity<ReportSampleUserId>
{

    private ReportSampleUser() { }

    public ReportSampleUser(ReportSampleUserId id, decimal? userId, decimal? formNumber, decimal? repSampleNumber)
    {
        Id = id;
        UserId = userId;
        FormNumber = formNumber;
        RepSampleNumber = repSampleNumber;
    }

    /// <summary>
    /// The unique identifier for the ReportSampleUser
    /// المعرف الفريد لـ ReportSampleUser
    /// </summary>
    public ReportSampleUserId Id { get; private set; }

    /// <summary>
    /// UserId of the ReportSampleUser
    /// UserId الخاص بـ ReportSampleUser
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// FormNumber of the ReportSampleUser
    /// FormNumber الخاص بـ ReportSampleUser
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// RepSampleNumber of the ReportSampleUser
    /// RepSampleNumber الخاص بـ ReportSampleUser
    /// </summary>
    public decimal? RepSampleNumber { get; private set; }

    /// <summary>
    /// RepSampleDefault of the ReportSampleUser
    /// RepSampleDefault الخاص بـ ReportSampleUser
    /// </summary>
    public decimal? RepSampleDefault { get; private set; }

    /// <summary>
    /// PrivateFlag of the ReportSampleUser
    /// PrivateFlag الخاص بـ ReportSampleUser
    /// </summary>
    public decimal? PrivateFlag { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

