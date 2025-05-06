using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

using ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects;
namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Entities
{
/// <summary>
/// FormField Entity
/// </summary>
public class FormField : Entity<FormFieldId>
{

    private FormField() { }

    public FormField(FormFieldId id, string tabName, string fieldName)
    {
        Id = id;
        TabName = tabName;
        FieldName = fieldName;
    }

    /// <summary>
    /// The unique identifier for the FormField
    /// المعرف الفريد لـ FormField
    /// </summary>
    public FormFieldId Id { get; private set; }

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
    /// Reference relationship: ManyToOne
    /// </summary>
    public FormDetail FormDetail { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

