using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SettingsParameters.Entities
{
/// <summary>
/// ParameterReportMaster Entity
/// </summary>
public class ParameterReportMaster : Entity<ParameterReportMasterId>
{

    private ParameterReportMaster() { }

    public ParameterReportMaster(ParameterReportMasterId id, decimal? parameterSerial)
    {
        Id = id;
        ParameterSerial = parameterSerial;
    }

    /// <summary>
    /// The unique identifier for the ParameterReportMaster
    /// المعرف الفريد لـ ParameterReportMaster
    /// </summary>
    public ParameterReportMasterId Id { get; private set; }

    /// <summary>
    /// ParameterNumber of the ParameterReportMaster
    /// ParameterNumber الخاص بـ ParameterReportMaster
    /// </summary>
    public decimal? ParameterNumber { get; private set; }

    /// <summary>
    /// ParameterDate of the ParameterReportMaster
    /// ParameterDate الخاص بـ ParameterReportMaster
    /// </summary>
    public DateTime? ParameterDate { get; private set; }

    /// <summary>
    /// ParameterSerial of the ParameterReportMaster
    /// ParameterSerial الخاص بـ ParameterReportMaster
    /// </summary>
    public decimal? ParameterSerial { get; private set; }

    /// <summary>
    /// AccountDescription of the ParameterReportMaster
    /// AccountDescription الخاص بـ ParameterReportMaster
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// FormNumber of the ParameterReportMaster
    /// FormNumber الخاص بـ ParameterReportMaster
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// ParameterFromTables of the ParameterReportMaster
    /// ParameterFromTables الخاص بـ ParameterReportMaster
    /// </summary>
    public string ParameterFromTables { get; private set; }

    /// <summary>
    /// ParameterAllowColumn of the ParameterReportMaster
    /// ParameterAllowColumn الخاص بـ ParameterReportMaster
    /// </summary>
    public string ParameterAllowColumn { get; private set; }

    /// <summary>
    /// ParameterExceedColumn of the ParameterReportMaster
    /// ParameterExceedColumn الخاص بـ ParameterReportMaster
    /// </summary>
    public string ParameterExceedColumn { get; private set; }

    /// <summary>
    /// ParameterCondition of the ParameterReportMaster
    /// ParameterCondition الخاص بـ ParameterReportMaster
    /// </summary>
    public string ParameterCondition { get; private set; }

    /// <summary>
    /// ParameterDescription of the ParameterReportMaster
    /// ParameterDescription الخاص بـ ParameterReportMaster
    /// </summary>
    public string ParameterDescription { get; private set; }

    /// <summary>
    /// BranchNumber of the ParameterReportMaster
    /// BranchNumber الخاص بـ ParameterReportMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ParameterReportMaster
    /// BranchYear الخاص بـ ParameterReportMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ParameterReportMaster
    /// CompanyNumberShort الخاص بـ ParameterReportMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchUser of the ParameterReportMaster
    /// BranchUser الخاص بـ ParameterReportMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
