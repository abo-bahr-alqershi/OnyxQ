using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Entities
{
/// <summary>
/// FormName Entity
/// </summary>
public class FormName : Entity<FormNameId>
{
    private FormName() { }

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
    /// FormNumber of the FormName
    /// FormNumber الخاص بـ FormName
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// FormName of the FormName
    /// FormName الخاص بـ FormName
    /// </summary>
    public string FormName { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to FormDetail
    /// </summary>
    public FormDetail FormDetail { get; private set; }
    #endregion
}
}
