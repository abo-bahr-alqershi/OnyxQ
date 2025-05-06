using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects;
namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Entities
{
/// <summary>
/// FormName Entity
/// </summary>
public class FormName : Entity<FormNameId>
{

    private FormName() { }

    public FormName(FormNameId id, decimal? languageNumber)
    {
        Id = id;
        LanguageNumber = languageNumber;
    }

    /// <summary>
    /// The unique identifier for the FormName
    /// المعرف الفريد لـ FormName
    /// </summary>
    public FormNameId Id { get; private set; }

    /// <summary>
    /// LanguageNumber of the FormName
    /// LanguageNumber الخاص بـ FormName
    /// </summary>
    public decimal? LanguageNumber { get; private set; }

    /// <summary>
    /// FormName of the FormName
    /// FormName الخاص بـ FormName
    /// </summary>
    public string FormName { get; private set; }

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

