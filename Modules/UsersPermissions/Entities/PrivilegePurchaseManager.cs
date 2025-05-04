using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// PrivilegePurchaseManager Entity
/// </summary>
public class PrivilegePurchaseManager : Entity<PrivilegePurchaseManagerId>
{
    private PrivilegePurchaseManager() { }

    /// <summary>
    /// The unique identifier for the PrivilegePurchaseManager
    /// المعرف الفريد لـ PrivilegePurchaseManager
    /// </summary>
    public PrivilegePurchaseManagerId Id { get; private set; }

    /// <summary>
    /// UserId of the PrivilegePurchaseManager
    /// UserId الخاص بـ PrivilegePurchaseManager
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// PersonManagerCode of the PrivilegePurchaseManager
    /// PersonManagerCode الخاص بـ PrivilegePurchaseManager
    /// </summary>
    public string PersonManagerCode { get; private set; }

    /// <summary>
    /// AdditionalFlag of the PrivilegePurchaseManager
    /// AdditionalFlag الخاص بـ PrivilegePurchaseManager
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the PrivilegePurchaseManager
    /// ViewFlag الخاص بـ PrivilegePurchaseManager
    /// </summary>
    public decimal? ViewFlag { get; private set; }
}
}
