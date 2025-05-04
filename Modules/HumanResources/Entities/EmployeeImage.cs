using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.HumanResources.Entities
{
/// <summary>
/// EmployeeImage Entity
/// </summary>
public class EmployeeImage : Entity<EmployeeImageId>
{
    private EmployeeImage() { }

    /// <summary>
    /// The unique identifier for the EmployeeImage
    /// المعرف الفريد لـ EmployeeImage
    /// </summary>
    public EmployeeImageId Id { get; private set; }

    /// <summary>
    /// EmpNo of the EmployeeImage
    /// EmpNo الخاص بـ EmployeeImage
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// EmpImg of the EmployeeImage
    /// EmpImg الخاص بـ EmployeeImage
    /// </summary>
    public byte[] EmpImg { get; private set; }

    /// <summary>
    /// FileNameShort of the EmployeeImage
    /// FileNameShort الخاص بـ EmployeeImage
    /// </summary>
    public string FileNameShort { get; private set; }

    /// <summary>
    /// MimeType of the EmployeeImage
    /// MimeType الخاص بـ EmployeeImage
    /// </summary>
    public string MimeType { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// OneToOne relationship to Employee
    /// </summary>
    public Employee Employee { get; private set; }
    #endregion
}
}
