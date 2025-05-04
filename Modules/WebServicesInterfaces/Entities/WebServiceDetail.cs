using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.WebServicesInterfaces.Entities
{
/// <summary>
/// WebServiceDetail Entity
/// </summary>
public class WebServiceDetail : Entity<WebServiceDetailId>
{
    private WebServiceDetail() { }

    /// <summary>
    /// The unique identifier for the WebServiceDetail
    /// المعرف الفريد لـ WebServiceDetail
    /// </summary>
    public WebServiceDetailId Id { get; private set; }

    /// <summary>
    /// ServiceNumber of the WebServiceDetail
    /// ServiceNumber الخاص بـ WebServiceDetail
    /// </summary>
    public decimal? ServiceNumber { get; private set; }

    /// <summary>
    /// DocTyp of the WebServiceDetail
    /// DocTyp الخاص بـ WebServiceDetail
    /// </summary>
    public decimal? DocTyp { get; private set; }

    /// <summary>
    /// ServiceQuery of the WebServiceDetail
    /// ServiceQuery الخاص بـ WebServiceDetail
    /// </summary>
    public string ServiceQuery { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to WebServiceMaster
    /// </summary>
    public WebServiceMaster WebServiceMaster { get; private set; }
    #endregion
}
}
