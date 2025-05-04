using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ArchivingDocuments.Entities;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// FormFieldPrivilege Entity
/// </summary>
public class FormFieldPrivilege : Entity<FormFieldPrivilegeId>
{
    private FormFieldPrivilege() { }

    /// <summary>
    /// The unique identifier for the FormFieldPrivilege
    /// المعرف الفريد لـ FormFieldPrivilege
    /// </summary>
    public FormFieldPrivilegeId Id { get; private set; }

    /// <summary>
    /// UserId of the FormFieldPrivilege
    /// UserId الخاص بـ FormFieldPrivilege
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// FormNumber of the FormFieldPrivilege
    /// FormNumber الخاص بـ FormFieldPrivilege
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// TabName of the FormFieldPrivilege
    /// TabName الخاص بـ FormFieldPrivilege
    /// </summary>
    public string TabName { get; private set; }

    /// <summary>
    /// FieldName of the FormFieldPrivilege
    /// FieldName الخاص بـ FormFieldPrivilege
    /// </summary>
    public string FieldName { get; private set; }

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
    /// ManyToOne relationship to FormDetail
    /// </summary>
    public FormDetail FormDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    /// <summary>
    /// ManyToOne relationship to FormField
    /// </summary>
    public FormField FormField { get; private set; }
    #endregion
}
}
