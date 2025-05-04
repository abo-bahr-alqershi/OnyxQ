using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Entities
{
/// <summary>
/// FormField Entity
/// </summary>
public class FormField : Entity<FormFieldId>
{
    private FormField() { }

    /// <summary>
    /// The unique identifier for the FormField
    /// المعرف الفريد لـ FormField
    /// </summary>
    public FormFieldId Id { get; private set; }

    /// <summary>
    /// FormNumber of the FormField
    /// FormNumber الخاص بـ FormField
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// TabName of the FormField
    /// TabName الخاص بـ FormField
    /// </summary>
    public string TabName { get; private set; }

    /// <summary>
    /// FieldName of the FormField
    /// FieldName الخاص بـ FormField
    /// </summary>
    public string FieldName { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: FormField to FormFieldPrivilege
    /// </summary>
    public IReadOnlyCollection<FormFieldPrivilege> FormFieldPrivileges { get; private set; }
    /// <summary>
    /// ManyToOne relationship to FormDetail
    /// </summary>
    public FormDetail FormDetail { get; private set; }
    /// <summary>
    /// One-to-many relationship: FormField to FormDetail
    /// </summary>
    public IReadOnlyCollection<FormDetail> FormDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: FormField to User
    /// </summary>
    public IReadOnlyCollection<User> Users { get; private set; }
    #endregion
}
}
