using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// CollectorImportExcelTemplate Entity
/// </summary>
public class CollectorImportExcelTemplate : Entity<CollectorImportExcelTemplateId>
{

    private CollectorImportExcelTemplate() { }

    public CollectorImportExcelTemplate(CollectorImportExcelTemplateId id, decimal? formNumber, string columnName)
    {
        Id = id;
        FormNumber = formNumber;
        ColumnName = columnName;
    }

    /// <summary>
    /// The unique identifier for the CollectorImportExcelTemplate
    /// المعرف الفريد لـ CollectorImportExcelTemplate
    /// </summary>
    public CollectorImportExcelTemplateId Id { get; private set; }

    /// <summary>
    /// FormNumber of the CollectorImportExcelTemplate
    /// FormNumber الخاص بـ CollectorImportExcelTemplate
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// ColumnNumber of the CollectorImportExcelTemplate
    /// ColumnNumber الخاص بـ CollectorImportExcelTemplate
    /// </summary>
    public decimal? ColumnNumber { get; private set; }

    /// <summary>
    /// ColumnName of the CollectorImportExcelTemplate
    /// ColumnName الخاص بـ CollectorImportExcelTemplate
    /// </summary>
    public string ColumnName { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
