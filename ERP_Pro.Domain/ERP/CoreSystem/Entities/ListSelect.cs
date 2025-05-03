using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a ListSelect entity
/// يمثل كيان اختيار القائمة
/// </summary>
public class ListSelect : AuditableEntity
{
    /// <summary>
    /// Gets the unique identifier for the ListSelect
    /// المعرف الفريد لاختيار القائمة
    /// !# LST_NM
    /// </summary>
    public ListSelectId Id { get; private set; }

    /// <summary>
    /// Gets the SQL query for the list
    /// استعلام SQL للقائمة
    /// !# LST_SQL
    /// </summary>
    public string SqlQuery { get; private set; }

    /// <summary>
    /// Gets the WHERE clause for the list
    /// شرط WHERE للقائمة
    /// !# LST_WHR
    /// </summary>
    public string WhereClause { get; private set; }

    /// <summary>
    /// Gets the ORDER BY clause for the list
    /// شرط ORDER BY للقائمة
    /// !# LST_ORDRBY
    /// </summary>
    public string OrderByClause { get; private set; }

    /// <summary>
    /// Gets the previous SQL query for the list
    /// استعلام SQL السابق للقائمة
    /// !# LST_SQL_PRV
    /// </summary>
    public string PreviousSqlQuery { get; private set; }

    private ListSelect() { } // For EF Core

    public ListSelect(
        string listName,
        string sqlQuery,
        string whereClause,
        string orderByClause,
        string previousSqlQuery)
    {
        Id = new ListSelectId(listName);
        SqlQuery = sqlQuery ?? throw new ArgumentNullException(nameof(sqlQuery));
        WhereClause = whereClause ?? string.Empty;
        OrderByClause = orderByClause ?? string.Empty;
        PreviousSqlQuery = previousSqlQuery ?? string.Empty;
        AddDomainEvent(new ListSelectCreatedEvent(this));
    }

    public void Update(
        string sqlQuery,
        string whereClause,
        string orderByClause,
        string previousSqlQuery)
    {
        SqlQuery = sqlQuery ?? throw new ArgumentNullException(nameof(sqlQuery));
        WhereClause = whereClause ?? string.Empty;
        OrderByClause = orderByClause ?? string.Empty;
        PreviousSqlQuery = previousSqlQuery ?? string.Empty;
        AddDomainEvent(new ListSelectUpdatedEvent(this));
    }

    public void Delete()
    {
        AddDomainEvent(new ListSelectDeletedEvent(this));
    }
} 