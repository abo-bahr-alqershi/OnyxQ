using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ArchivingDocuments.Entities;

using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;
namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// FormFieldPrivilege Entity
/// </summary>
public class FormFieldPrivilege : Entity<FormFieldPrivilegeId>
{

    private FormFieldPrivilege() { }

    public FormFieldPrivilege(FormFieldPrivilegeId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the FormFieldPrivilege
    /// المعرف الفريد لـ FormFieldPrivilege
    /// </summary>
    public FormFieldPrivilegeId Id { get; private set; }

    /// <summary>
    /// PrivateFlag of the FormFieldPrivilege
    /// PrivateFlag الخاص بـ FormFieldPrivilege
    /// </summary>
    public decimal? PrivateFlag { get; private set; }

    /// <summary>
    /// FOrderNumber of the FormFieldPrivilege
    /// FOrderNumber الخاص بـ FormFieldPrivilege
    /// </summary>
    public decimal? FOrderNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public FormDetail FormDetail { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public User User { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public FormField FormField { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

