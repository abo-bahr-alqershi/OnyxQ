using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.WebServicesInterfaces.Entities
{
/// <summary>
/// WebServiceRequestBody Entity
/// </summary>
public class WebServiceRequestBody : Entity<WebServiceRequestBodyId>
{
    private WebServiceRequestBody() { }

    /// <summary>
    /// The unique identifier for the WebServiceRequestBody
    /// المعرف الفريد لـ WebServiceRequestBody
    /// </summary>
    public WebServiceRequestBodyId Id { get; private set; }

    /// <summary>
    /// ServiceNumber of the WebServiceRequestBody
    /// ServiceNumber الخاص بـ WebServiceRequestBody
    /// </summary>
    public decimal? ServiceNumber { get; private set; }

    /// <summary>
    /// Alias of the WebServiceRequestBody
    /// Alias الخاص بـ WebServiceRequestBody
    /// </summary>
    public string Alias { get; private set; }

    /// <summary>
    /// ObjectName of the WebServiceRequestBody
    /// ObjectName الخاص بـ WebServiceRequestBody
    /// </summary>
    public string ObjectName { get; private set; }

    /// <summary>
    /// IsArrayFlag of the WebServiceRequestBody
    /// IsArrayFlag الخاص بـ WebServiceRequestBody
    /// </summary>
    public decimal? IsArrayFlag { get; private set; }

    /// <summary>
    /// QueryText of the WebServiceRequestBody
    /// QueryText الخاص بـ WebServiceRequestBody
    /// </summary>
    public string QueryText { get; private set; }

    /// <summary>
    /// QueryWhere of the WebServiceRequestBody
    /// QueryWhere الخاص بـ WebServiceRequestBody
    /// </summary>
    public string QueryWhere { get; private set; }

    /// <summary>
    /// QueryOrder of the WebServiceRequestBody
    /// QueryOrder الخاص بـ WebServiceRequestBody
    /// </summary>
    public string QueryOrder { get; private set; }

    /// <summary>
    /// Placeholder of the WebServiceRequestBody
    /// Placeholder الخاص بـ WebServiceRequestBody
    /// </summary>
    public string Placeholder { get; private set; }

    /// <summary>
    /// TemporaryKeys of the WebServiceRequestBody
    /// TemporaryKeys الخاص بـ WebServiceRequestBody
    /// </summary>
    public string TemporaryKeys { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to WebServiceMaster
    /// </summary>
    public WebServiceMaster WebServiceMaster { get; private set; }
    #endregion
}
}
