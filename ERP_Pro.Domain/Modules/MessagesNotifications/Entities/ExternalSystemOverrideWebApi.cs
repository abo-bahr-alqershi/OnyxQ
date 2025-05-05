using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects;
namespace ERP_Pro.Domain.ERP.MessagesNotifications.Entities
{
/// <summary>
/// ExternalSystemOverrideWebApi Entity
/// </summary>
public class ExternalSystemOverrideWebApi : Entity<ExternalSystemOverrideWebApiId>
{

    private ExternalSystemOverrideWebApi() { }

    public ExternalSystemOverrideWebApi(ExternalSystemOverrideWebApiId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the ExternalSystemOverrideWebApi
    /// المعرف الفريد لـ ExternalSystemOverrideWebApi
    /// </summary>
    public ExternalSystemOverrideWebApiId Id { get; private set; }

    /// <summary>
    /// ESystemNumber of the ExternalSystemOverrideWebApi
    /// ESystemNumber الخاص بـ ExternalSystemOverrideWebApi
    /// </summary>
    public decimal? ESystemNumber { get; private set; }

    /// <summary>
    /// ESystemName of the ExternalSystemOverrideWebApi
    /// ESystemName الخاص بـ ExternalSystemOverrideWebApi
    /// </summary>
    public string ESystemName { get; private set; }

    /// <summary>
    /// ApiKey of the ExternalSystemOverrideWebApi
    /// ApiKey الخاص بـ ExternalSystemOverrideWebApi
    /// </summary>
    public string ApiKey { get; private set; }

    /// <summary>
    /// ApiSecret of the ExternalSystemOverrideWebApi
    /// ApiSecret الخاص بـ ExternalSystemOverrideWebApi
    /// </summary>
    public string ApiSecret { get; private set; }

    /// <summary>
    /// AccountsPayableToken of the ExternalSystemOverrideWebApi
    /// AccountsPayableToken الخاص بـ ExternalSystemOverrideWebApi
    /// </summary>
    public string AccountsPayableToken { get; private set; }

    /// <summary>
    /// BaseApiUrl of the ExternalSystemOverrideWebApi
    /// BaseApiUrl الخاص بـ ExternalSystemOverrideWebApi
    /// </summary>
    public string BaseApiUrl { get; private set; }

    /// <summary>
    /// PricingLevel of the ExternalSystemOverrideWebApi
    /// PricingLevel الخاص بـ ExternalSystemOverrideWebApi
    /// </summary>
    public decimal? PricingLevel { get; private set; }

    /// <summary>
    /// GetTokenServiceNumber of the ExternalSystemOverrideWebApi
    /// GetTokenServiceNumber الخاص بـ ExternalSystemOverrideWebApi
    /// </summary>
    public decimal? GetTokenServiceNumber { get; private set; }

    /// <summary>
    /// UpdateItemsServiceNumber of the ExternalSystemOverrideWebApi
    /// UpdateItemsServiceNumber الخاص بـ ExternalSystemOverrideWebApi
    /// </summary>
    public decimal? UpdateItemsServiceNumber { get; private set; }

    /// <summary>
    /// UpdateItemServiceNumber of the ExternalSystemOverrideWebApi
    /// UpdateItemServiceNumber الخاص بـ ExternalSystemOverrideWebApi
    /// </summary>
    public decimal? UpdateItemServiceNumber { get; private set; }

    /// <summary>
    /// ProxyServiceUrl of the ExternalSystemOverrideWebApi
    /// ProxyServiceUrl الخاص بـ ExternalSystemOverrideWebApi
    /// </summary>
    public string ProxyServiceUrl { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

