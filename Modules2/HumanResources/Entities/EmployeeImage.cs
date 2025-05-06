using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.HumanResources.ValueObjects;
namespace ERP_Pro.Domain.ERP.HumanResources.Entities
{
/// <summary>
/// EmployeeImage Entity
/// </summary>
public class EmployeeImage : Entity<EmployeeImageId>
{

    private EmployeeImage() { }

    public EmployeeImage(EmployeeImageId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the EmployeeImage
    /// المعرف الفريد لـ EmployeeImage
    /// </summary>
    public EmployeeImageId Id { get; private set; }

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
    /// Reference relationship: OneToOne
    /// </summary>
    public Employee Employee { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

