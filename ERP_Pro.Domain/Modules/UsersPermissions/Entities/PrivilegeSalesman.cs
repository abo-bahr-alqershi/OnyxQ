using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// PrivilegeSalesman Entity
/// </summary>
public class PrivilegeSalesman : Entity<PrivilegeSalesmanId>
{

    private PrivilegeSalesman() { }

    public PrivilegeSalesman(PrivilegeSalesmanId id, decimal? userId, string repCode)
    {
        Id = id;
        UserId = userId;
        RepCode = repCode;
    }

    /// <summary>
    /// The unique identifier for the PrivilegeSalesman
    /// المعرف الفريد لـ PrivilegeSalesman
    /// </summary>
    public PrivilegeSalesmanId Id { get; private set; }

    /// <summary>
    /// UserId of the PrivilegeSalesman
    /// UserId الخاص بـ PrivilegeSalesman
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// RepCode of the PrivilegeSalesman
    /// RepCode الخاص بـ PrivilegeSalesman
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// AdditionalFlag of the PrivilegeSalesman
    /// AdditionalFlag الخاص بـ PrivilegeSalesman
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the PrivilegeSalesman
    /// ViewFlag الخاص بـ PrivilegeSalesman
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
