using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// ListSelect Entity
/// </summary>
public class ListSelect : Entity<ListSelectId>
{
    private ListSelect() { }

    /// <summary>
    /// The unique identifier for the ListSelect
    /// المعرف الفريد لـ ListSelect
    /// </summary>
    public ListSelectId Id { get; private set; }

    /// <summary>
    /// LastName of the ListSelect
    /// LastName الخاص بـ ListSelect
    /// </summary>
    public string LastName { get; private set; }

    /// <summary>
    /// LastSql of the ListSelect
    /// LastSql الخاص بـ ListSelect
    /// </summary>
    public string LastSql { get; private set; }

    /// <summary>
    /// LastWhere of the ListSelect
    /// LastWhere الخاص بـ ListSelect
    /// </summary>
    public string LastWhere { get; private set; }

    /// <summary>
    /// LastOrderBy of the ListSelect
    /// LastOrderBy الخاص بـ ListSelect
    /// </summary>
    public string LastOrderBy { get; private set; }

    /// <summary>
    /// LastSqlPrevious of the ListSelect
    /// LastSqlPrevious الخاص بـ ListSelect
    /// </summary>
    public string LastSqlPrevious { get; private set; }
}
}
