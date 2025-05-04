using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.WebServicesInterfaces.Entities
{
/// <summary>
/// WebServiceMaster Entity
/// </summary>
public class WebServiceMaster : Entity<WebServiceMasterId>
{
    private WebServiceMaster() { }

    /// <summary>
    /// The unique identifier for the WebServiceMaster
    /// المعرف الفريد لـ WebServiceMaster
    /// </summary>
    public WebServiceMasterId Id { get; private set; }

    /// <summary>
    /// ServiceNumber of the WebServiceMaster
    /// ServiceNumber الخاص بـ WebServiceMaster
    /// </summary>
    public decimal? ServiceNumber { get; private set; }

    /// <summary>
    /// ServiceLastDescription of the WebServiceMaster
    /// ServiceLastDescription الخاص بـ WebServiceMaster
    /// </summary>
    public string ServiceLastDescription { get; private set; }

    /// <summary>
    /// ServiceFullDescription of the WebServiceMaster
    /// ServiceFullDescription الخاص بـ WebServiceMaster
    /// </summary>
    public string ServiceFullDescription { get; private set; }

    /// <summary>
    /// ServiceUrl of the WebServiceMaster
    /// ServiceUrl الخاص بـ WebServiceMaster
    /// </summary>
    public string ServiceUrl { get; private set; }

    /// <summary>
    /// ServiceMethod of the WebServiceMaster
    /// ServiceMethod الخاص بـ WebServiceMaster
    /// </summary>
    public string ServiceMethod { get; private set; }

    /// <summary>
    /// ServiceSynchronize of the WebServiceMaster
    /// ServiceSynchronize الخاص بـ WebServiceMaster
    /// </summary>
    public decimal? ServiceSynchronize { get; private set; }

    /// <summary>
    /// ServiceTypeShort of the WebServiceMaster
    /// ServiceTypeShort الخاص بـ WebServiceMaster
    /// </summary>
    public decimal? ServiceTypeShort { get; private set; }

    /// <summary>
    /// RequestBodyTemplate of the WebServiceMaster
    /// RequestBodyTemplate الخاص بـ WebServiceMaster
    /// </summary>
    public string RequestBodyTemplate { get; private set; }

    /// <summary>
    /// ContentType of the WebServiceMaster
    /// ContentType الخاص بـ WebServiceMaster
    /// </summary>
    public string ContentType { get; private set; }

    /// <summary>
    /// HttpSuccessResponseCode of the WebServiceMaster
    /// HttpSuccessResponseCode الخاص بـ WebServiceMaster
    /// </summary>
    public string HttpSuccessResponseCode { get; private set; }

    /// <summary>
    /// TextSuccessResponse of the WebServiceMaster
    /// TextSuccessResponse الخاص بـ WebServiceMaster
    /// </summary>
    public string TextSuccessResponse { get; private set; }

    /// <summary>
    /// UserName of the WebServiceMaster
    /// UserName الخاص بـ WebServiceMaster
    /// </summary>
    public string UserName { get; private set; }

    /// <summary>
    /// Password of the WebServiceMaster
    /// Password الخاص بـ WebServiceMaster
    /// </summary>
    public string Password { get; private set; }

    /// <summary>
    /// AuthType of the WebServiceMaster
    /// AuthType الخاص بـ WebServiceMaster
    /// </summary>
    public string AuthType { get; private set; }

    /// <summary>
    /// DocTyp of the WebServiceMaster
    /// DocTyp الخاص بـ WebServiceMaster
    /// </summary>
    public decimal? DocTyp { get; private set; }

    /// <summary>
    /// WalletPath of the WebServiceMaster
    /// WalletPath الخاص بـ WebServiceMaster
    /// </summary>
    public string WalletPath { get; private set; }

    /// <summary>
    /// WalletPassword of the WebServiceMaster
    /// WalletPassword الخاص بـ WebServiceMaster
    /// </summary>
    public string WalletPassword { get; private set; }

    /// <summary>
    /// RootObjectName of the WebServiceMaster
    /// RootObjectName الخاص بـ WebServiceMaster
    /// </summary>
    public string RootObjectName { get; private set; }

    /// <summary>
    /// NonArrayObjects of the WebServiceMaster
    /// NonArrayObjects الخاص بـ WebServiceMaster
    /// </summary>
    public string NonArrayObjects { get; private set; }

    /// <summary>
    /// ESystemNumber of the WebServiceMaster
    /// ESystemNumber الخاص بـ WebServiceMaster
    /// </summary>
    public decimal? ESystemNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: WebServiceMaster to WebServiceColumn
    /// </summary>
    public IReadOnlyCollection<WebServiceColumn> WebServiceColumns { get; private set; }
    /// <summary>
    /// One-to-many relationship: WebServiceMaster to WebServiceDetail
    /// </summary>
    public IReadOnlyCollection<WebServiceDetail> WebServiceDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: WebServiceMaster to WebServiceRequestBody
    /// </summary>
    public IReadOnlyCollection<WebServiceRequestBody> WebServiceRequestBodies { get; private set; }
    #endregion
}
}
