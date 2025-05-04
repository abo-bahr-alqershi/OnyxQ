using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.DoctorsPatients.Entities
{
/// <summary>
/// DoctorPrivilege Entity
/// </summary>
public class DoctorPrivilege : Entity<DoctorPrivilegeId>
{

    private DoctorPrivilege() { }

    public DoctorPrivilege(DoctorPrivilegeId id, decimal? userId)
    {
        Id = id;
        UserId = userId;
    }

    /// <summary>
    /// The unique identifier for the DoctorPrivilege
    /// المعرف الفريد لـ DoctorPrivilege
    /// </summary>
    public DoctorPrivilegeId Id { get; private set; }

    /// <summary>
    /// UserId of the DoctorPrivilege
    /// UserId الخاص بـ DoctorPrivilege
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// AdditionalFlag of the DoctorPrivilege
    /// AdditionalFlag الخاص بـ DoctorPrivilege
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the DoctorPrivilege
    /// ViewFlag الخاص بـ DoctorPrivilege
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Doctor Doctor { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
