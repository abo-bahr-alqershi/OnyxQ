using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.HumanResources.ValueObjects;
namespace ERP_Pro.Domain.ERP.HumanResources.Entities
{
/// <summary>
/// EmployeeKnowledge Entity
/// </summary>
public class EmployeeKnowledge : Entity<EmployeeKnowledgeId>
{

    private EmployeeKnowledge() { }

    public EmployeeKnowledge(EmployeeKnowledgeId id, decimal? codeType, decimal? codeNumber)
    {
        Id = id;
        CodeType = codeType;
        CodeNumber = codeNumber;
    }

    /// <summary>
    /// The unique identifier for the EmployeeKnowledge
    /// المعرف الفريد لـ EmployeeKnowledge
    /// </summary>
    public EmployeeKnowledgeId Id { get; private set; }

    /// <summary>
    /// CodeType of the EmployeeKnowledge
    /// CodeType الخاص بـ EmployeeKnowledge
    /// </summary>
    public decimal? CodeType { get; private set; }

    /// <summary>
    /// CodeNumber of the EmployeeKnowledge
    /// CodeNumber الخاص بـ EmployeeKnowledge
    /// </summary>
    public decimal? CodeNumber { get; private set; }

    /// <summary>
    /// Notes of the EmployeeKnowledge
    /// Notes الخاص بـ EmployeeKnowledge
    /// </summary>
    public string Notes { get; private set; }

    /// <summary>
    /// GradeYearNumber of the EmployeeKnowledge
    /// GradeYearNumber الخاص بـ EmployeeKnowledge
    /// </summary>
    public decimal? GradeYearNumber { get; private set; }

    /// <summary>
    /// GradeMonthNumber of the EmployeeKnowledge
    /// GradeMonthNumber الخاص بـ EmployeeKnowledge
    /// </summary>
    public decimal? GradeMonthNumber { get; private set; }

    /// <summary>
    /// GradeSideName of the EmployeeKnowledge
    /// GradeSideName الخاص بـ EmployeeKnowledge
    /// </summary>
    public string GradeSideName { get; private set; }

    /// <summary>
    /// FYearNumber of the EmployeeKnowledge
    /// FYearNumber الخاص بـ EmployeeKnowledge
    /// </summary>
    public decimal? FYearNumber { get; private set; }

    /// <summary>
    /// TYearNumber of the EmployeeKnowledge
    /// TYearNumber الخاص بـ EmployeeKnowledge
    /// </summary>
    public decimal? TYearNumber { get; private set; }

    /// <summary>
    /// FMonthNumber of the EmployeeKnowledge
    /// FMonthNumber الخاص بـ EmployeeKnowledge
    /// </summary>
    public decimal? FMonthNumber { get; private set; }

    /// <summary>
    /// TMonthNumber of the EmployeeKnowledge
    /// TMonthNumber الخاص بـ EmployeeKnowledge
    /// </summary>
    public decimal? TMonthNumber { get; private set; }

    /// <summary>
    /// CountryNumber of the EmployeeKnowledge
    /// CountryNumber الخاص بـ EmployeeKnowledge
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// CtyNm of the EmployeeKnowledge
    /// CtyNm الخاص بـ EmployeeKnowledge
    /// </summary>
    public string CtyNm { get; private set; }

    /// <summary>
    /// FDate of the EmployeeKnowledge
    /// FDate الخاص بـ EmployeeKnowledge
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the EmployeeKnowledge
    /// TDate الخاص بـ EmployeeKnowledge
    /// </summary>
    public DateTime? TDate { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Employee Employee { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

