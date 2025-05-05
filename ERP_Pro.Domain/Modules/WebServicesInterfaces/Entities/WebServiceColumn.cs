using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.WebServicesInterfaces.ValueObjects;
namespace ERP_Pro.Domain.ERP.WebServicesInterfaces.Entities
{
/// <summary>
/// WebServiceColumn Entity
/// </summary>
public class WebServiceColumn : Entity<WebServiceColumnId>
{

    private WebServiceColumn() { }

    public WebServiceColumn(WebServiceColumnId id, decimal? columnOrder)
    {
        Id = id;
        ColumnOrder = columnOrder;
    }

    /// <summary>
    /// The unique identifier for the WebServiceColumn
    /// المعرف الفريد لـ WebServiceColumn
    /// </summary>
    public WebServiceColumnId Id { get; private set; }

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
    /// Reference relationship: ManyToOne
    /// </summary>
    public WebServiceMaster WebServiceMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

