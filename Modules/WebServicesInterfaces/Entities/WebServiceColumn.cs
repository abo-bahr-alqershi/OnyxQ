using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.WebServicesInterfaces.Entities
{
/// <summary>
/// WebServiceColumn Entity
/// </summary>
public class WebServiceColumn : Entity<WebServiceColumnId>
{
    private WebServiceColumn() { }

    /// <summary>
    /// The unique identifier for the WebServiceColumn
    /// المعرف الفريد لـ WebServiceColumn
    /// </summary>
    public WebServiceColumnId Id { get; private set; }

    /// <summary>
    /// ServiceNumber of the WebServiceColumn
    /// ServiceNumber الخاص بـ WebServiceColumn
    /// </summary>
    public decimal? ServiceNumber { get; private set; }

    /// <summary>
    /// ColumnOrder of the WebServiceColumn
    /// ColumnOrder الخاص بـ WebServiceColumn
    /// </summary>
    public decimal? ColumnOrder { get; private set; }

    /// <summary>
    /// ColumnNameShort of the WebServiceColumn
    /// ColumnNameShort الخاص بـ WebServiceColumn
    /// </summary>
    public string ColumnNameShort { get; private set; }

    /// <summary>
    /// ColumnNameOnyx of the WebServiceColumn
    /// ColumnNameOnyx الخاص بـ WebServiceColumn
    /// </summary>
    public string ColumnNameOnyx { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to WebServiceMaster
    /// </summary>
    public WebServiceMaster WebServiceMaster { get; private set; }
    #endregion
}
}
